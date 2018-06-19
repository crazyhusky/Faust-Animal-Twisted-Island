using System.Collections.Generic;
using FATIbeta.JsonClasses;

namespace FATIbeta.CoreEngine
{
    public class JsonMapping
    {
        private static JsonMapping instance;
        public Dictionary<string, BaseAttackClass> Attacks { get; set; }
        public Dictionary<string, NPCClass> NPCList { get; set; }
        public Dictionary<string, Location> Locations { get; set; }
        public Dictionary<string, ItemClass> Items { get; set; }
        public Dictionary<string, TransformationBook> TransformationBooks { get; set; }
        public Dictionary<string, TransformationLibrary> TransformationLibraries { get; set; }
        public Dictionary<string, EnemyClass> Enemies { get; set; }
        public Dictionary<string, EventClass> Events { get; set; }
        public Dictionary<string, BodyPartBaseClass> BodyParts { get; set; }
        public PlayerClass BasePlayer { get; set; }

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
            BasePlayer = new PlayerClass();
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

            return null;
        }
        public ItemClass GetItem(string ItemName)
        {
            if (Items.TryGetValue(ItemName, out var myItem))
            {
                return myItem;
            }

            return null;
        }
        public NPCClass GetNPC(string NpcName)
        {
            if (NPCList.TryGetValue(NpcName, out var myNpc))
            {
                return myNpc;
            }

            return null;
        }
        public BaseAttackClass GetAttack(string AttackName)
        {
            if (Attacks.TryGetValue(AttackName, out var myAttack))
            {
                return myAttack;
            }

            return null;
        }

        public TransformationBook GetTransformationBook(string BookName)
        {
            if (TransformationBooks.TryGetValue(BookName, out var myBook))
            {
                return myBook;
            }

            return null;
        }

        public TransformationLibrary GetTransformationLibrary(string LibraryName)
        {
            if (TransformationLibraries.TryGetValue(LibraryName, out var myLibrary))
            {
                return myLibrary;
            }

            return null;
        }

        public EnemyClass GetEnemy(string enemyName)
        {
            if (Enemies.TryGetValue(enemyName, out var myEnemy))
            {
                return myEnemy;
            }

            return null;
        }

        public EventClass GetEvent(string eventName)
        {
            if (Events.TryGetValue(eventName, out var myEvent))
            {
                return myEvent;
            }

            return null;
        }

        public BodyPartBaseClass GetBodyPart(string bodyPartName)
        {
            if (BodyParts.TryGetValue(bodyPartName, out var myBodyPart))
            {
                return myBodyPart;
            }

            return null;
        }
    }
}