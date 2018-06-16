using FATIbeta.JsonClasses;

namespace FATIbeta.src.UI
{
    public interface UIConnectionInterface
    {
        void ClearPlayerDescriptionScreen();
        void ClearWorldScreen();
        void UpdatePlayerData(PlayerClass PlayerClassData);
        void UpdateWorldDescription(string WorldDescription);

    }
}