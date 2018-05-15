using System.Linq;
namespace FATIbeta.CoreEngine
{
    public class GameLoop
    {
        public void GameLoopLoop()
        {
            UpdateWorld();
        }

        public void UpdateWorld()
        {
            //UpdatePlayer
            JsonMapping.Instance.BasePlayer.UpdateObject();
            //Update Enemies
            foreach (var Enemy in JsonMapping.Instance.Enemies.Values)
            {
                Enemy.UpdateObject();
            }
            //UpdateLocations
            foreach (var Location in JsonMapping.Instance.Locations.Values)
            {
                Location.UpdateObject();
            }
            //UpdateEvents
            foreach (var Event in JsonMapping.Instance.Events.Values)
            {
                Event.UpdateObject();
            }
        }
    }
}