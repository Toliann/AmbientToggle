using BepInEx.Configuration;


public static class AmbientToggleConfig
{
    // Configuration setting for the ambient toggle.
    public static ConfigEntry<bool> AmbientEnabled;

    /// <summary>
    /// Initializes configuration parameters.
    /// Called from the mod with the configuration instance.
    /// </summary>
    /// <param name="config">BepInEx configuration file</param>
    public static void Init(ConfigFile config)
    {
        AmbientEnabled = config.Bind<bool>(
            "Ambient Settings",           // Configuration section
            "AmbientEnabled",             // Key
            true,                         // Default value
            "Toggle for enabling/disabling the ambient on the PsychSanctum"  // Description
        );
    }
}
