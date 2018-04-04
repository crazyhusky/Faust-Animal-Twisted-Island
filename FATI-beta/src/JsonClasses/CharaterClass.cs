using System.Collections.Generic;

namespace FATI_beta.JsonClasses
{
    public class CharaterClass : MainGameObject
    {
        protected float Health;
        protected float Lust;
        protected int Coins;
        protected int Level;
        protected List<BodyPartBaseClass> BodyParts;
        protected List<ItemClass> Inventory;
        protected Location CurrentLocation;
        public CharaterClass()
        {
        }

        public void MoveToLocation(Location newlocation)
        {
            CurrentLocation = newlocation;
        }

        public int GetLevel()
        {
            return Level;
        }
    }
}
