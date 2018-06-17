using System.Collections.Generic;

namespace FATIbeta.JsonClasses
{
    public class CharaterClass : MainGameObject
    {
        private float health;
        private float maxHealth;
        private float lust;
        private float maxlust;
        private float fatique;
        private float maxfatique;
        private int coins;
        private int level;
        private List<BodyPartBaseClass> bodyParts;
        private List<ItemClass> inventory;
        private Location currentLocation;

        public float Health { get => health; set => health = value; }
        public float MaxHealth { get => maxHealth; set => maxHealth = value; }
        public float MaxLust { get => maxlust; set => maxlust = value; }
        public float Lust { get => lust; set => lust = value; }
        public float MaxFatique { get => maxfatique; set => maxfatique = value; }
        public float Fatique { get => fatique; set => fatique = value; }
        public int Coins { get => coins; set => coins = value; }
        public int Level { get => level; set => level = value; }
        public List<BodyPartBaseClass> BodyParts { get => bodyParts; set => bodyParts = value; }
        public List<ItemClass> Inventory { get => inventory; set => inventory = value; }
        public Location CurrentLocation { get => currentLocation; set => currentLocation = value; }

        public CharaterClass()
        {
        }

        public void MoveToLocation(Location newlocation)
        {
            CurrentLocation = newlocation;
        }
    }
}
