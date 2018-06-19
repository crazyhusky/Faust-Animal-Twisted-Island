using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FATIbeta.CoreEngine;
using FATIbeta.JsonClasses;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace FATIbeta.src.CoreEngine
{
    class JsonGameRefrences
    {
        public class LocationRefrences : JsonConverter<Location>
        {

            public override void WriteJson(JsonWriter writer, Location value, JsonSerializer serializer)
            {
                writer.WriteValue(value.Name);
            }

            public override Location ReadJson(JsonReader reader, Type objectType, Location existingValue, bool hasExistingValue,
                JsonSerializer serializer)
            {
                return Program.MainGame.GetJsonMappingInstance().GetLocation(reader.Value as string);
            }
        }
        public class BodyPartRefrences : JsonConverter<List<BodyPartBaseClass>>
        {

            public override void WriteJson(JsonWriter writer, List<BodyPartBaseClass> value, JsonSerializer serializer)
            {
                writer.WriteValue(value);
            }

            public override List<BodyPartBaseClass> ReadJson(JsonReader reader, Type objectType, List<BodyPartBaseClass> existingValue, bool hasExistingValue,
                JsonSerializer serializer)
            {
                var parts = JArray.Load(reader).ToObject<List<string>>();
                var newlist = new List<BodyPartBaseClass>();
                foreach (var bodypart in parts)
                {
                    var output = Program.MainGame.GetJsonMappingInstance().GetBodyPart(bodypart).GetShallowCopy();
                    newlist.Add(output);
                }
                return newlist;
            }
        }

    }
}
