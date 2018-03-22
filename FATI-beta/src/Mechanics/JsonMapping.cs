using System.Collections.Generic;
using FATI_beta.JsonClasses;
namespace FATI_beta.Mechanics
{
    public class JsonMapping
    {
        protected Dictionary<string,NPCClass> NPCLists;
        protected Dictionary<string,Location> Locations;
        protected Dictionary<string,ItemClass> Items;
        protected Dictionary<string,TransformationBook> TransformationBooks;
        protected Dictionary<string,TransformationLibrary> TransformationLibraries;
    }
}