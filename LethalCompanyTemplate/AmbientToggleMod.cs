using BepInEx;
using UnityEngine;
namespace AmbientToggleMod
{
    [BepInPlugin("com.Toliann.AmbientToggle", "Ambient Toggle Mod", "0.0.1")]
    public class AmbientToggleMod : BaseUnityPlugin
    {
        public GameObject targetObject;

        private void Awake()
        {
           
            AmbientToggleConfig.Init(Config);

            // If the object is not assigned, try to find it by name.
            if (targetObject == null)
            {
                targetObject = GameObject.Find("AmbientObject");
            }

            if (targetObject != null)
            {
                // Apply the setting: enable or disable the object.
                targetObject.SetActive(AmbientToggleConfig.AmbientEnabled.Value);
                Logger.LogInfo($"AmbientToggleMod: Object '{targetObject.name}' is now {(AmbientToggleConfig.AmbientEnabled.Value ? "active" : "inactive")}.");
            }
            else
            {
                Logger.LogWarning("AmbientToggleMod: Target object not found!");
            }
        }
    }
}
