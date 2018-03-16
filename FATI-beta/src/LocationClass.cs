namespace FATI_beta.src
{
    public class LocationClass : MainGameObject
    {
        protected LocationConnections[] Connections;
    }

    public class LocationConnections : MainGameObject
    {
        protected string Direction;
    }
}