using System.Collections.Generic;
using FATIbeta.JsonClasses;

namespace FATIbeta.CoreEngine
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