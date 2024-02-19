# Note

Note: This git repo is currently outdated. See https://github.com/dtsudo/SuperTux-Advance-Web-Port for a more up-to-date build.

# How to build the codebase

This document explains how to build the web version of SuperTux Advance.

The main component of this codebase is a "WebVersionGenerator" program that does the following things:

* It transpiles Squirrel code into corresponding javascript code. For each `.nut` file, the transpiler will generate a corresponding `.js` file.
* All image files (*.png) are base64-encoded and stored in a new `images.js` file. (This is why `images.js` is so large.)
* Similarly, json files (*.json and *.tsj) have their contents copied into a new `jsonFiles.js` and `tsjFiles.js` file. (This is why `jsonFiles.js` is also so large.)
* Audio files (*.ogg) are copied as-is into a new `audioFiles` folder (and renamed as just `file0.ogg`, `file1.ogg`, `file2.ogg`, etc)
* The Brux API is re-implemented in javascript.

In summary, this "WebVersionGenerator" program takes the SuperTux Advance codebase as input, processes all relevant files (the squirrel code, json data, image files, audio files), and creates a bunch of output files that can be run by a web browser.

Therefore, to create a new web build, it is necessary to (1) update the STA codebase, and then (2) re-run this "WebVersionGenerator" program.

# 1) Update the SuperTux Advance source code

The `SuperTux-Advance-source-code` folder contains the SuperTux Advance source code.

To make a new web build, replace the contents of this folder with the most up-to-date version of the STA codebase.

Note that an additional patch has to be applied to the STA codebase to fix a few issues with the web port. This patch can be found here: https://github.com/dtsudo/SuperTux-Advance/commit/c3046870bd82e923fd41d8e93361cf9c881a868b

This means that a typical process for updating the STA codebase is as follows:
* Clone the git repo for STA (or fetch/pull if the repo already exists) to get the latest commits (`git clone https://github.com/KelvinShadewing/supertux-advance`)
* Cherry-pick the additional patch to apply it to the latest commit (`git remote add dtsudofork https://github.com/dtsudo/SuperTux-Advance.git ; git fetch dtsudofork ; git cherry-pick c3046870bd82e923fd41d8e93361cf9c881a868b`)
* Copy+paste the STA codebase into this git repo's `SuperTux-Advance-source-code` folder
 
# 2) Compile the WebVersionGenerator program

`web-version-source-code/WebVersionGenerator` is a program that creates the web version of SuperTux Advance. Since this program is written in C#, ensure .NET is installed.

Compile this program by running: `MSBuild.exe "./web-version-source-code/WebVersionGenerator/WebVersionGenerator.sln"`

This will create the file `web-version-source-code/WebVersionGenerator/WebVersionGenerator/bin/Debug/WebVersionGenerator.exe`. 

# 3) Execute `WebVersionGenerator.exe`

Run `web-version-source-code/WebVersionGenerator/WebVersionGenerator/bin/Debug/WebVersionGenerator.exe`. This program will create various files in `web-version-source-code/output`.

# 4) Verify that the web version works

Execute the resulting web version by running `web-version-source-code/output/SuperTux-Advance-web-version.html` in a web browser.
