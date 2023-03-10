# DWNO AlwaysRunning Mod

This mod swaps the walking and running speed, causing the player to always run unless the running button is pressed.
Additionally it allows the walking and running speeds to adjusted in a config file.

Note: too high speed values might lead to the camera and Digimon having trouble to catch up.

## Installation

1. Install [BepInEx](https://github.com/BepInEx/BepInEx) ([Tutorial by Yasha-jin](https://github.com/Yasha-jin/DWNOModdingGuides/blob/main/Guides/HowToInstallBepInExForDWNO.md))
2. Download the latest release from the [Releases Tab](https://github.com/SydMontague/DWNO-Mod-AlwaysRunning/releases)
3. Copy the `AlwaysRunning.dll` into the `plugins` folder of BepInEx
4. Start the game and enjoy :)
5. (Optional) change the speed modifiers in the plugin's config inside the `config` folder of BepInEx

## Building

In order to build the plugin yourself you have to

1. Install BepInEx (see instructions above)
2. clone the project
3. copy the `interop` folder into the project
4. run `dotnet build -c Release` inside the folder (or open the .csproj with Visual Studio)

The `FastPickup.dll` should now be in `bin/Release/net6.0`.

You'll have to have .Net 6.0 or higher installed.

## Contact
* Discord: SydMontague#8056, or in either the [Digimon Modding Community](https://discord.gg/cb5AuxU6su) or [Digimon Discord Community](https://discord.gg/0VODO3ww0zghqOCO)
* directly on GitHub
* E-Mail: sydmontague@web.de
* Reddit: [/u/Sydmontague](https://reddit.com/u/sydmontague)