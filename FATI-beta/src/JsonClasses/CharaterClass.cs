using System;
using System.Collections.Generic;
using System.ComponentModel;
using FATIbeta.CoreEngine;
using FATIbeta.src.CoreEngine;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FATIbeta.JsonClasses
{
    public class CharaterClass : MainGameObject
    {
        [DefaultValue(100)]
        public float Health { get; set; } = 100;

        [DefaultValue(100)]
        public float MaxHealth { get; set; } = 100;

        [DefaultValue(100)]
        public float MaxLust { get; set; } = 100;

        [DefaultValue(0)]
        public float Lust { get; set; } = 0;

        [DefaultValue(100)]
        public float MaxFatique { get; set; } = 100;

        [DefaultValue(0)]
        public float Fatique { get; set; } = 0;

        [DefaultValue(0)]
        public int Coins { get; set; } = 0;

        [DefaultValue(0)]
        public int Level { get; set; } = 0;
        [JsonConverter(typeof(JsonGameRefrences.BodyPartRefrences))]
        public List<BodyPartBaseClass> BodyParts { get; set; }

        public List<ItemClass> Inventory { get; set; }
        [JsonConverter(typeof(JsonGameRefrences.LocationRefrences))]
        public Location CurrentLocation { get; set; } = new Location();

        public CharaterClass()
        {
        }

        public void MoveToLocation(Location newlocation)
        {
            CurrentLocation = newlocation;
        }

        public override string ToString()
        {
            var newline = "\n";
            var health = $"{Health}/{MaxHealth}";
            var lust = $"{Lust}/{MaxLust}";
            var fatigue = $"{Fatique}/{MaxFatique}";
            var coins = $"{Coins}";
            var level = $"{Level}";
            var bodyparts = $"{string.Join($"{newline}", BodyParts)}";
            var inventory = $"{Inventory}";
            var location = $"{CurrentLocation}";

            var baseStats =
                $"BaseStats{newline}{health}{newline}{lust}{newline}{fatigue}{newline}{coins}{newline}{level}{newline}{bodyparts}{newline}{inventory}{newline}{location}";
            return $"{base.ToString()}:{newline}{baseStats}";
        }
    }
}
