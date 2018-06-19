using System.Linq;
using FATIbeta.JsonClasses;
using SharpPhysFS;

namespace FATIbeta.CoreEngine
{
    public class AssetLoaderFactory
    {
        public static void LoadFiles(PhysFS physFSInstance, JsonMapping Maps)
        {
            var assetLoading = new AssetLoading(Maps);
            assetLoading.LoadResource("attacks", physFSInstance, Maps.Attacks);
            assetLoading.LoadResource("bodyparts", physFSInstance, Maps.BodyParts);
            assetLoading.LoadResource("events", physFSInstance, Maps.Events);
            assetLoading.LoadResource("items", physFSInstance, Maps.Items);
            assetLoading.LoadResource("npcs", physFSInstance, Maps.NPCList);
            assetLoading.LoadResource("locations", physFSInstance, Maps.Locations);
            assetLoading.LoadResource("enemies", physFSInstance, Maps.Enemies);
            assetLoading.LoadResource("tfbooks", physFSInstance, Maps.TransformationBooks);
            assetLoading.LoadResource("tflibrary", physFSInstance, Maps.TransformationLibraries);
            Maps.BasePlayer = assetLoading.LoadSingleResource<PlayerClass>("player", physFSInstance).Last();

        }
    }
}