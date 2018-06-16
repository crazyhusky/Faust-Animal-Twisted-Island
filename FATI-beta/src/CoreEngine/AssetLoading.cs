using System;
using System.Collections.Generic;
using System.IO;
using FATIbeta.JsonClasses;
using Newtonsoft.Json;
using SharpPhysFS;

namespace FATIbeta.CoreEngine
{
    public class AssetLoading
    {
        public void LoadResource<T>(String filenameToEnum, PhysFS physFSInstance, Dictionary<string, T> MapDictionary) where T: MainGameObject, new()
        {
            var FileList = physFSInstance.EnumerateFiles(filenameToEnum);
            foreach (var file in FileList)
            {
                var filepath = filenameToEnum + "/" + file;
                var locationData = DeserializeJsonFile<T>(physFSInstance, filepath);
                MapDictionary.Add(locationData.Name, locationData);
            }
        }
        public T DeserializeJsonFileData<T>(Stream s)
        {
            var deserializeOptions = new JsonSerializerSettings {DefaultValueHandling = DefaultValueHandling.Populate};
            using (var reader = new StreamReader(s))
            using (var jsonReader = new JsonTextReader(reader))
            {
                JsonSerializer ser = JsonSerializer.CreateDefault(deserializeOptions);
                return ser.Deserialize<T>(jsonReader);
            }
        }
        public T DeserializeJsonFile<T>(PhysFS physFSInstance, string filepath) where T : MainGameObject, new()
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
