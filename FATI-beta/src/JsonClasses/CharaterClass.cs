﻿using System.Collections.Generic;

namespace FATIbeta.JsonClasses
{
    public class CharaterClass : MainGameObject
    {
        protected float Health;
        protected float MaxHealth;
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
