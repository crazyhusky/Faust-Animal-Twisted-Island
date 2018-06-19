using System;
using FATIbeta.JsonClasses;

namespace FATIbeta.src.UI
{
    public class winformLink : UIConnectionInterface
    {
        private TestFormX winformInstance;
        private static winformLink instance;

        public winformLink( TestFormX formInstance)
        {
            winformInstance = formInstance;
            instance = this;
        }

        public void ClearPlayerDescriptionScreen()
        {
            winformInstance.SetPlayerText("");
        }

        public void ClearWorldScreen()
        {
            winformInstance.SetworldText("");
        }

        public void UpdatePlayerData(PlayerClass PlayerClassData)
        {
            winformInstance.SetPlayerText(PlayerClassData.ToString());
            winformInstance.UpdatePlayerHealth(PlayerClassData.Health, PlayerClassData.MaxHealth);
            winformInstance.UpdatePlayerLust(PlayerClassData.Lust,PlayerClassData.MaxLust);
            winformInstance.UpdatePlayerFatigue(PlayerClassData.Fatique, PlayerClassData.MaxFatique);
        }

        public void UpdateWorldDescription(string WorldDescription)
        {
            winformInstance.SetworldText(WorldDescription);
        }
        public static winformLink Instance => instance;
    }

}