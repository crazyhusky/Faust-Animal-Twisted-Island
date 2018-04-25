namespace FATIbeta.JsonClasses
{
    public class MainGameObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public MainGameObject()
        {
        }
        public override string ToString() {
            return $"{Name}:{Description}:{GetType().Name}";
        }
    }
}
