using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using System.ComponentModel;

namespace AlwaysRunning;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInProcess("Digimon World Next Order.exe")]
public class Plugin : BasePlugin
{
    public static Plugin Instance { get; private set; }

    public ConfigEntry<float> runningSpeed { get; private set;  }
    public ConfigEntry<float> walkingSpeed { get; private set; }

    public override void Load()
    {
        Instance = this;

        runningSpeed = Config.Bind("General", "RunningSpeed", 1.4f, "Speed modifier while running.");
        walkingSpeed = Config.Bind("General", "WalkingSpeed", 1.0f, "Speed modifier while walking.");

        // Plugin startup logic
        Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
        Harmony.CreateAndPatchAll(typeof(Patches));
    }
}
