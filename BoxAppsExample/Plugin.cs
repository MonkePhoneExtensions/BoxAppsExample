using BepInEx;

namespace BoxAppsExample
{
    [BepInDependency("eh.boxapps", "1.0.0")]
    [BepInPlugin(Constants.GUID, Constants.Name, Constants.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public void Awake() 
        {
            GorillaTagger.OnPlayerSpawned(() =>
            {
                /// <summary>
                /// Write any other code related to your mod here.
                /// </summary>
            });
        }
    }
}
