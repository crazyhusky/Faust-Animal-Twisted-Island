namespace FATI_beta.JsonClasses
{
    public class Location: MainGameObject
    {
        protected LocationConnections[] Connections;
        protected int UnlockLevel;
    }

    public class LocationConnections : MainGameObject
    {
        protected string Direction;
    }
}