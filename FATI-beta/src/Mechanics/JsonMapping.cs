﻿using System.Collections.Generic;
using FATI_beta.JsonClasses;

namespace FATI_beta.Mechanics
{
    public class JsonMapping
    {
        private static JsonMapping instance;
        public Dictionary<string, BaseAttackClass> Attacks;
        public Dictionary<string, NPCClass> NPCList;
        public Dictionary<string, Location> Locations;
        public Dictionary<string, ItemClass> Items;
        public Dictionary<string, TransformationBook> TransformationBooks;
        public Dictionary<string, TransformationLibrary> TransformationLibraries;
        public Dictionary<string, EnemyClass> Enemies;
        public Dictionary<string, EventClass> Events;
        public Dictionary<string, BodyPartBaseClass> BodyParts;
        public PlayerClass BasePlayer;

        private JsonMapping()
        {
            Attacks = new Dictionary<string, BaseAttackClass>();
            NPCList = new Dictionary<string, NPCClass>();
            Locations = new Dictionary<string, Location>();
            Items = new Dictionary<string, ItemClass>();
            TransformationBooks = new Dictionary<string, TransformationBook>();
            TransformationLibraries = new Dictionary<string, TransformationLibrary>();
            Enemies = new Dictionary<string, EnemyClass>();
            BodyParts = new Dictionary<string, BodyPartBaseClass>();
            Events = new Dictionary<string, EventClass>();
        }

        public static JsonMapping Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JsonMapping();
                }

                return instance;
            }
        }
        public Location GetLocation(string LocationName)
        {
            if (Locations.TryGetValue(LocationName, out var myLocation))
            {
                return myLocation;
            }
            else
            {
                return null;
            }
        }
    }
}