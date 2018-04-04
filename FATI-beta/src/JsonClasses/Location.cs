using System.Collections.Generic;

namespace FATI_beta.JsonClasses
{
    public class Location: MainGameObject
    {
        protected LocationConnections[] Connections;
        protected int UnlockLevel;
        protected List<ItemClass> Inventory;
    }

    public class LocationConnections : MainGameObject
    {
        protected string Direction;
    }
}