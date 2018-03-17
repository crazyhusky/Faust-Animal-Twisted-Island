namespace FATI_beta.JsonClasses
{
    public class LocationClass : MainGameObject
    {
        protected LocationConnections[] Connections;
        protected int UnlockLevel;
    }

    public class LocationConnections : MainGameObject
    {
        protected string Direction;
    }
}