using System;
using System.Collections.Generic;
using System.IO;
using FATIbeta.JsonClasses;
using Newtonsoft.Json;
using SharpPhysFS;

namespace FATIbeta.CoreEngine
{
    class AssetLoading
    {
        public static void LoadFiles(PhysFS physFSInstance, JsonMapping Maps)
        {
            LoadResource("attacks",physFSInstance,Maps.Attacks);
            LoadResource("bodyparts",physFSInstance,Maps.BodyParts);
            LoadResource("events", physFSInstance, Maps.Events);
            LoadResource("items", physFSInstance, Maps.Items);
            LoadResource("npcs", physFSInstance, Maps.NPCList);
            LoadResource("locations", physFSInstance, Maps.Locations);
            LoadResource("enemies", physFSInstance, Maps.Enemies);
            LoadResource("tfbooks", physFSInstance, Maps.TransformationBooks);
            LoadResource("tflibrary", physFSInstance, Maps.TransformationLibraries);

        }
        public static void LoadResource<T>(String filenameToEnum, PhysFS physFSInstance, Dictionary<string, T> MapDictionary) where T: MainGameObject, new()
        {
            var FileList = physFSInstance.EnumerateFiles(filenameToEnum);
            foreach (var file in FileList)
            {
                var filepath = filenameToEnum + "/" + file;
                var locationData = DeserializeJsonFile<T>(physFSInstance, filepath);
                MapDictionary.Add(locationData.Name, locationData);
            }
        }
        public static T DeserializeJsonFileData<T>(Stream s)
        {
            using (var reader = new StreamReader(s))
            using (var jsonReader = new JsonTextReader(reader))
            {
                JsonSerializer ser = new JsonSerializer();
                return ser.Deserialize<T>(jsonReader);
            }
        }
        public static T DeserializeJsonFile<T>(PhysFS physFSInstance, string filepath) where T : MainGameObject, new()
        {
            var filedata = physFSInstance.OpenRead(filepath);
            var jsonObject = DeserializeJsonFileData<T>(filedata);
            if (jsonObject == null)
            {
                return (new T {Name = "null"});
            }

            return jsonObject;
        }
    }
}
