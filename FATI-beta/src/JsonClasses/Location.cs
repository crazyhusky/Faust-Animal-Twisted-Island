using System.Collections.Generic;
using System.Linq;
using FATI_beta.CoreEngine;

namespace FATI_beta.JsonClasses
{
    public class Location: MainGameObject
    {
        protected LocationConnections[] Connections;
        protected int UnlockLevel;
        protected List<ItemClass> Inventory;
        protected bool Discovered;

        public string GetLocationInDirection(string _direction)
        {
            var Location = "Unknown\\Blocked";
            var locationName = Connections.Where(Connection => Connection.Direction == _direction)
                .Select(Connection => Connection.ConnectedLocation).Single();
            var LocationObject = JsonMapping.Instance.GetLocation(locationName);
            if (LocationObject != null)
            {
                if (LocationObject.Discovered)
                {
                    Location = LocationObject.Name;
                }
            }

            return Location;
        }
    }

    public class LocationConnections : MainGameObject
    {
        public string Direction;
        public string ConnectedLocation;
    }
}