namespace FATIbeta.src.UI
{
    public interface UIConnectionInterface
    {
        void ClearPlayerDescriptionScreen();
        void ClearWorldScreen();
        void UpdatePlayerDescription(string PlayerText);
        void UpdateWorldDescription(string WorldDescription);
    }
}