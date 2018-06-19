using System.CodeDom;
using System.ComponentModel;
using Jint.Parser.Ast;

namespace FATIbeta.JsonClasses
{
    public class MainGameObject
    {
        [DefaultValue("Thing")]
        public string Name { get; set; }
        [DefaultValue("Thing Description")]
        public string Description { get; set; }
        public MainGameObject()
        {
        }
        public override string ToString() {
            return $"{Name}:{Description}";
        }

        public void UpdateObject()
        {

        }

        public MainGameObject GetShallowCopy()
        {
            return this.MemberwiseClone() as MainGameObject;
        }
    }
}
