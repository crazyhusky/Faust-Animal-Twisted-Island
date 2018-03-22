using System.Collections.Generic;

namespace FATI_beta.JsonClasses
{
    public class CharaterClass : MainGameObject
    {
        protected float Health;
        protected float Lust;
        protected int Coins;
        protected List<BodyPartBaseClass> BodyParts;
        protected List<ItemClass> Inventory;
        public CharaterClass()
        {
        }
    }
}
