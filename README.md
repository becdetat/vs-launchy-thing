vs-launchy-thing
================

Tiny console app to select and launch a Visual Studio solution

## Installation

Grab the [latest release](https://github.com/bendetat/vs-launchy-thing/releases), unzip the exe and drop it into the path somewhere. I have `C:\bin` and `C:\source` on my path for convenience.

## Usage

In your favourite console, type `vs` and hit `<Enter>`. `vs` searches the current path for any files named `*.sln`. If only one solution file is found, it is opened immediately (using `Process.Start`). If there are multiple solutions found it prompts for the solution to open. Enter the number and press enter, or just hit enter to select the first solution.

![](http://i.imgur.com/CGDZ3LV.png)

    ? vs
    [1]: c:\source\REDACTED\REDACTED.Slim.sln
    [2]: c:\source\REDACTED\REDACTED.sln
    Solution [1]:
    
  
