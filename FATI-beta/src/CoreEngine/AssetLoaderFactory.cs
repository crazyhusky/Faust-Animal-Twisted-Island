using SharpPhysFS;

namespace FATIbeta.CoreEngine
{
    public class AssetLoaderFactory
    {
        public static void LoadFiles(PhysFS physFSInstance, JsonMapping Maps)
        {

            new AssetLoading().LoadResource("attacks", physFSInstance, Maps.Attacks);
            new AssetLoading().LoadResource("bodyparts", physFSInstance, Maps.BodyParts);
            new AssetLoading().LoadResource("events", physFSInstance, Maps.Events);
            new AssetLoading().LoadResource("items", physFSInstance, Maps.Items);
            new AssetLoading().LoadResource("npcs", physFSInstance, Maps.NPCList);
            new AssetLoading().LoadResource("locations", physFSInstance, Maps.Locations);
            new AssetLoading().LoadResource("enemies", physFSInstance, Maps.Enemies);
            new AssetLoading().LoadResource("tfbooks", physFSInstance, Maps.TransformationBooks);
            new AssetLoading().LoadResource("tflibrary", physFSInstance, Maps.TransformationLibraries);

        }
    }
}