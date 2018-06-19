using System;
using System.Collections.Generic;
using System.IO;
using FATIbeta.JsonClasses;
using FATIbeta.src.CoreEngine;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SharpPhysFS;

namespace FATIbeta.CoreEngine
{
    public class AssetLoading
    {
        private JsonMapping MapsInstance;
        public AssetLoading(JsonMapping maps)
        {
            MapsInstance = maps;
        }

        public void LoadResource<T>(String filenameToEnum, PhysFS physFSInstance, Dictionary<string, T> MapDictionary) where T: MainGameObject, new()
        {
            var FileList = physFSInstance.EnumerateFiles(filenameToEnum);
            foreach (var file in FileList)
            {
                var filepath = filenameToEnum + "/" + file;
                var locationData = DeserializeJsonFile<T>(physFSInstance, filepath);
                MapDictionary.Add(locationData.Name.Replace(" ","-"), locationData);
            }
        }
        public List<T> LoadSingleResource<T>(String filenameToEnum, PhysFS physFSInstance) where T : MainGameObject, new()
        {
            var dataset = new List<T>();
            var FileList = physFSInstance.EnumerateFiles(filenameToEnum);
            foreach (var file in FileList)
            {
                var filepath = filenameToEnum + "/" + file;
                var locationData = DeserializeJsonFile<T>(physFSInstance, filepath);
                dataset.Add(locationData);
            }

            return dataset;
        }
        public T DeserializeJsonFileData<T>(Stream s)
        {
            ITraceWriter traceWriter = new MemoryTraceWriter();
            var deserializeOptions = new JsonSerializerSettings
            {
                TraceWriter = traceWriter,
                DefaultValueHandling = DefaultValueHandling.Populate,
                NullValueHandling = NullValueHandling.Include,
                PreserveReferencesHandling = PreserveReferencesHandling.All,
                
            };
            using (var reader = new StreamReader(s))
            using (var jsonReader = new JsonTextReader(reader))
            {
                JsonSerializer ser = JsonSerializer.CreateDefault(deserializeOptions);
                var output = ser.Deserialize<T>(jsonReader);
                Console.WriteLine(traceWriter);
                return output;

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
