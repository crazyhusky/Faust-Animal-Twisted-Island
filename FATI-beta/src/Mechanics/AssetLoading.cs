using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharpPhysFS;

namespace FATI_beta.Mechanics
{
    class AssetLoading
    {
        public static void LoadFiles(PhysFS physFSInstance) {
            LoadBodyParts(physFSInstance);
        }

        public static void LoadBodyParts(PhysFS physFSInstance) {
            var BodyPartFileList = physFSInstance.EnumerateFiles("bodyparts");
            foreach (var file in BodyPartFileList) {
                var filepath = "bodyparts" + "/" + file;
                var bodypart =DeserializeJsonFile<JsonClasses.BodyPartBaseClass>(physFSInstance,filepath);
                Console.WriteLine(bodypart.ToString());
            }
        }
        public static T DeserializeJsonFileData<T>(Stream s)
        {
            using (StreamReader reader = new StreamReader(s))
            using (JsonTextReader jsonReader = new JsonTextReader(reader))
            {
                JsonSerializer ser = new JsonSerializer();
                return ser.Deserialize<T>(jsonReader);
            }
        }
        public static T DeserializeJsonFile<T>(PhysFS physFSInstance,string filepath) {
            var filedata = physFSInstance.OpenRead(filepath);
            var jsonObject = DeserializeJsonFileData<T>(filedata);
            return jsonObject;
        }
    }
}
