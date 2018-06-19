using System.Collections.Generic;
using System.Linq;
using FATIbeta.CoreEngine;

namespace FATIbeta.JsonClasses
{
    public class Location: MainGameObject
    {
        private LocationConnections[] connections;
        private List<ItemClass> inventory;
        private bool discovered;

        public LocationConnections[] Connections { get => connections; set => connections = value; }
        public int UnlockLevel { get; set; }

        public List<ItemClass> Inventory { get => inventory; set => inventory = value; }
        public bool Discovered { get => discovered; set => discovered = value; }

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