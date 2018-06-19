using System;
namespace FATIbeta.JsonClasses
{
    public class BodyPartBaseClass : MainGameObject
    {
        public string PartType { get; set; }
        public BodyPartBaseClass()
        {
        }
        public new BodyPartBaseClass GetShallowCopy()
        {
            return this.MemberwiseClone() as BodyPartBaseClass;
        }
    }
}
