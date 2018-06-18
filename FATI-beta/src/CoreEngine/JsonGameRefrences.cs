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


    }
}
