/*===============================*\
|                                 |
|  BRUX JSON MAP LOADER           |
|                                 |
|  LICENSE: AGPL                  |
|  AUTHOR: Kelvin Shadewing       |
|  DESC: For use in Brux GDK      |
|    games to load JSON maps.     |
|                                 |
\*===============================*/

//TODO:
//Some SuperTux Advance-specific code exists and should be ported to a separate file

////////////////
// TILED MAPS //
////////////////

::tileSearchDir <- ["."]

::findFileName <- function(path) {
	if(typeof path != "string") return ""
	if(path.len() == 0) return ""

	for(local i = path.len() - 1; i >= 0; i--) {
		if(chint(path[i]) == "/" || chint(path[i]) == "\\") return path.slice(i + 1)
	}

	return path
}

///////////////////
// ANIMATED TILE //
///////////////////

::AnimTile <- class {
	frameID = null
	frameList = null
	frameTime = null
	sprite = null

	constructor(animList, _sprite) {
		frameID = animList.id
		frameList = []
		frameTime = []
		if("animation" in animList) {
			for(local i = 0; i < animList.animation.len(); i++) {
				frameList.push(animList.animation[i].tileid)
				if(i == 0) frameTime.push(animList.animation[i].duration)
				else frameTime.push(animList.animation[i].duration + frameTime[i - 1])
			}
		}
		sprite = _sprite
	}

	function draw(x, y, alpha, color = 0xffffffff) {
		local currentTime = wrap(getTicks(), 0, frameTime.top())
		for(local i = 0; i < frameList.len(); i++) {
			if(currentTime >= frameTime[i]) {
				if(i < frameTime.len() - 1) {
					if(currentTime < frameTime[i + 1]) {
						drawSpriteExMod(sprite, frameList[i], floor(x), floor(y), 0, 0, 1, 1, alpha, color)
						return
					}
				}
				else if(currentTime <= frameTime[i] && i == 0) {
					drawSpriteExMod(sprite, frameList[i], floor(x), floor(y), 0, 0, 1, 1, alpha, color)
					return
				}
			}
		}

		drawSpriteExMod(sprite, frameList.top(), floor(x), floor(y), 0, 0, 1, 1, alpha, color)
	}
}

///////////////////
// TILEMAP CLASS //
///////////////////

::Tilemap <- class {
	data = null
	tileset = null
	image = null
	tilef = null
	tilew = 0
	tileh = 0
	mapw = 0
	maph = 0
	geo = null //List of solid shapes added after loading
	w = 0
	h = 0
	name = ""
	file = ""
	author = ""
	solidfid = 0 //First tile ID for the solid tileset
	shape = null //Movable shape used for collision checking
	anim = null //List of animated tiles
	solidLayer = null //Tile layer used for collision checking
	plat = null //List of platforms
	infinite = false

	constructor(filename) {
		tileset = []
		image = {}
		tilef = []
		geo = []
		data = {}
		anim = {}

		if(fileExists(filename)) {
			data = jsonRead(fileRead(filename))

			mapw = data.width
			maph = data.height
			tilew = data.tilewidth
			tileh = data.tileheight
			w = mapw * tilew
			h = maph * tileh

			file = filename
			name = findFileName(filename)
			name = name.slice(0, -5)

			print("\nLoading map: " + name)

			for(local i = 0; i < data.tilesets.len(); i++) {
				//Check if tileset is not embedded
				if("source" in data.tilesets[i])
				for(local j = 0; j < tileSearchDir.len(); j++) {
					local sourcefile = findFileName(data.tilesets[i].source)
					if(fileExists(tileSearchDir[j] + "/" + sourcefile)) {
						print("Found external tileset: " + sourcefile)
						local newgid = data.tilesets[i].firstgid
						data.tilesets[i] = jsonRead(fileRead(tileSearchDir[j] + "/" + sourcefile))
						data.tilesets[i].firstgid <- newgid
						break
					}
					else print("Unable to find external tile: " + sourcefile + " in " + tileSearchDir[j])
				}

				//Extract filename
				//print("Get filename")
				if(!("image" in data.tilesets[i])) print(jsonWrite(data.tilesets[i]))
				local filename = data.tilesets[i].image
				local shortname = findFileName(filename)
				//print("Full map name: " + filename + ".")
				print("Searching for tileset: " + shortname)

				local tempspr = findSprite(shortname)
				//("Temp sprite: " + shortname)

				if(tempspr != 0) {
					tileset.push(tempspr)
					print("Found " + shortname)
				}
				else { //Search for file
					if(fileExists(filename)) {
						//print("Attempting to add full filename")
						tileset.push(newSprite(filename, data.tilesets[i].tilewidth, data.tilesets[i].tileheight, data.tilesets[i].margin, data.tilesets[i].spacing, 0, data.tilesets[i].tileheight - data.tileheight))
						print("Added tileset " + shortname + ".")
					}
					else for(local j = 0; j < tileSearchDir.len(); j++) {
						if(fileExists(tileSearchDir[j] + "/" + shortname)) {
							print("Adding " + shortname + " from search path: " + tileSearchDir[j])
							tileset.push(newSprite(tileSearchDir[j] + "/" + shortname, data.tilesets[i].tilewidth, data.tilesets[i].tileheight, data.tilesets[i].margin, data.tilesets[i].spacing, 0, data.tilesets[i].tileheight - data.tileheight))
							break
						}
					}
				}

				tilef.push(data.tilesets[i].firstgid)
				if(data.tilesets[i].name == "solid") solidfid = data.tilesets[i].firstgid

				//Add animations
				if(data.tilesets[i].rawin("tiles")) for(local j = 0; j < data.tilesets[i].tiles.len(); j++) {
					if("animation" in data.tilesets[i].tiles[j]) anim[data.tilesets[i].firstgid + data.tilesets[i].tiles[j].id] <- AnimTile(data.tilesets[i].tiles[j], tileset.top())
				}
			}

			//print("Added " + spriteName(tileset[i]) + ".\n")

			shape = (Rec(0, 0, 8, 8, 0))

			//Assign solid layer
			for(local i = 0; i < data.layers.len(); i++) {
				if(data.layers[i].type == "tilelayer" && data.layers[i].name == "solid") {
					solidLayer = data.layers[i]
					break
				}
			}

			//Load image layers
			for(local i = 0; i < data.layers.len(); i++) {
				if(data.layers[i].type == "imagelayer") {
					local imageSource = findTexture(findFileName(data.layers[i].image))
					if(imageSource <= 0) {
						for(local j = 0; j < tileSearchDir.len(); j++) {
							local sourcefile = findFileName(data.layers[i].image)
							if(fileExists(tileSearchDir[j] + "/" + sourcefile)) {
								print("Found external image: " + sourcefile)
								imageSource = loadImage(tileSearchDir[j] + "/" + sourcefile)
								break
							}
							else print("Unable to find external image: " + sourcefile + " in " + tileSearchDir[j])
						}
					}
					image[data.layers[i].name] <- imageSource
				}
			}
		}
		else print("Map file " + filename + " does not exist!")
	}

	// webBrowserVersionChange: made slight changes to this function to make it run faster
	function drawTiles(x, y, mx, my, mw, mh, l, a = 1, sx = 1, sy = 1) { //@mx through @mh are the rectangle of tiles that will be drawn
		//Find layer
		local t = -1; //Target layer
		local dataLayers = data.layers;
		local dataLayersLen = dataLayers.len();
		for(local i = 0; i < dataLayersLen; i++) {
			if(dataLayers[i].type == "tilelayer" && dataLayers[i].name == l) {
				t = i
				break
			}
		}
		if(t == -1) {
			return; //Quit if no tile layer by that name was found
		}

		local dataLayersT = dataLayers[t];
		local dataLayersTWidth = dataLayersT.width;
		local dataLayersTHeight = dataLayersT.height;
		
		//Make sure values are in range
		if(dataLayersTWidth < mx + mw) mw = dataLayersTWidth - mx
		if(dataLayersTHeight < my + mh) mh = dataLayersTHeight - my
		if(mx < 0) mx = 0
		if(my < 0) my = 0
		if(mx > dataLayersTWidth) mx = dataLayersTWidth
		if(my > dataLayersTHeight) my = dataLayersTHeight

		local myPlusMh = my + mh;
		local mxPlusMw = mx + mw;
		
		local dataLayersTData = dataLayersT.data;
		local dataLayersTDataLen = dataLayersTData.len();
		
		local dataTilesetsLen = data.tilesets.len();
		
		local dataLayersTOpacityTimesA = dataLayersT.opacity * a;
		
		for(local i = my; i < myPlusMh; i++) {
			local iTimesDataLayersTWidth = i * dataLayersTWidth;
			local yPlusRoundITimesDataTileheightTimesSy = y + round(i * data.tileheight * sy);
			for(local j = mx; j < mxPlusMw; j++) {
				if(iTimesDataLayersTWidth + j >= dataLayersTDataLen) return
				local n = dataLayersTData[iTimesDataLayersTWidth + j]; //Number value of the tile
				if(n != 0) {
					local xPlusRoundJTimesDataTilewidthTimesSx = x + round(j * data.tilewidth * sx);
					for(local k = dataTilesetsLen - 1; k >= 0; k--) {
						if(n >= data.tilesets[k].firstgid) {
							if(anim.rawin(n)) {
								if(tileset[k] == anim[n].sprite) anim[n].draw(xPlusRoundJTimesDataTilewidthTimesSx, yPlusRoundITimesDataTileheightTimesSy, dataLayersTOpacityTimesA)
								else drawSpriteEx(tileset[k], n - data.tilesets[k].firstgid, xPlusRoundJTimesDataTilewidthTimesSx, yPlusRoundITimesDataTileheightTimesSy, 0, 0, sx, sy, dataLayersTOpacityTimesA)
							}
							else drawSpriteEx(tileset[k], n - data.tilesets[k].firstgid, xPlusRoundJTimesDataTilewidthTimesSx, yPlusRoundITimesDataTileheightTimesSy, 0, 0, sx, sy, dataLayersTOpacityTimesA)
							k = -1
							break
						}
					}
				}
			}
		}
	}

	function drawTilesMod(x, y, mx, my, mw, mh, l, a = 1, sx = 1, sy = 1, c = 0xffffffff) { //@mx through @mh are the rectangle of tiles that will be drawn
		//Find layer
		local t = -1; //Target layer
		for(local i = 0; i < data.layers.len(); i++) {
			if(data.layers[i].type == "tilelayer" && data.layers[i].name == l) {
				t = i
				break
			}
		}
		if(t == -1) {
			return; //Quit if no tile layer by that name was found
		}

		//Make sure values are in range
		if(data.layers[t].width < mx + mw) mw = data.layers[t].width - mx
		if(data.layers[t].height < my + mh) mh = data.layers[t].height - my
		if(mx < 0) mx = 0
		if(my < 0) my = 0
		if(mx > data.layers[t].width) mx = data.layers[t].width
		if(my > data.layers[t].height) my = data.layers[t].height

		for(local i = my; i < my + mh; i++) {
			for(local j = mx; j < mx + mw; j++) {
				if(i * data.layers[t].width + j >= data.layers[t].data.len()) return
				local n = data.layers[t].data[(i * data.layers[t].width) + j]; //Number value of the tile
				if(n != 0) {
					for(local k = data.tilesets.len() - 1; k >= 0; k--) {
						if(n >= data.tilesets[k].firstgid) {
							if(anim.rawin(n)) {
								if(tileset[k] == anim[n].sprite) anim[n].draw(x + floor(j * data.tilewidth * sx), y + floor(i * data.tileheight * sy), data.layers[t].opacity * a, c)
								else drawSpriteExMod(tileset[k], n - data.tilesets[k].firstgid, x + floor(j * data.tilewidth * sx), y + floor(i * data.tileheight * sy), 0, 0, sx, sy, data.layers[t].opacity * a, c)
							}
							else drawSpriteExMod(tileset[k], n - data.tilesets[k].firstgid, x + floor(j * data.tilewidth * sx), y + floor(i * data.tileheight * sy), 0, 0, sx, sy, data.layers[t].opacity * a, c)
							k = -1
							break
						}
					}
				}
			}
		}
	}

	function drawImageLayer(l, x, y) {
		if(l in image)
			drawImage(image[l], x, y)
	}

	function del() {
		return //Needs fix on Brux side

		for(local i = 0; i < tileset.len(); i++) {
			deleteSprite(tileset[i])
		}
	}

	function _typeof() { return "Tilemap" }
}

///////////////
// FUNCTIONS //
///////////////

::mapNewSolid <- function(shape) {
	gvMap.geo.push(shape)
	return gvMap.geo.len() - 1
}

::mapDeleteSolid <- function(index) {
	if(index in gvMap.geo && index >= 0 && index < gvMap.geo.len() && gvMap.geo.len() > 0) {
		gvMap.geo[index] = null
	}
}

::tileSetSolid <- function(tx, ty, st) { //Tile X, tile Y, solid type
	if(st < 0) return
	local cx = floor(tx / 16)
	local cy = floor(ty / 16)
	local tile = cx + (cy * gvMap.solidLayer.width)

	if(st == 0) {
		if(tile >= 0 && tile < gvMap.solidLayer.data.len()) gvMap.solidLayer.data[tile] = 0
	}
	else if(tile >= 0 && tile < gvMap.solidLayer.data.len()) gvMap.solidLayer.data[tile] = gvMap.solidfid + (st - 1)
}

::tileGetSolid <- function(tx, ty) {
	local tile = floor(tx / 16) + (floor(ty / 16) * gvMap.solidLayer.width)

	if(tile >= 0 && tile < gvMap.solidLayer.data.len()) {
		if(gvMap.solidLayer.data[tile] == 0) return 0
		else return (gvMap.solidLayer.data[tile] - gvMap.solidfid + 1)
	}
}

::loadTileMapWorld <- function(filename) {
	if(!fileExists(filename)) return {}

	local file = jsonRead(fileRead(filename))
	local nw = {}

	if(!"maps" in file) return {}
	for(local i = 0; i < file.maps.len(); i++) {
		local name = findFileName(file.maps[i]["fileName"])
		nw[name] <- [file.maps[i]["x"], file.maps[i]["y"]]
	}
}