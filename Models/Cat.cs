using System.Collections.Generic;

namespace Test.Models
{
    public class Cat
    {
        public string name;
        public string breed;
        public int age;
        public bool canFly;
        public List<string> favoriteFoods = new List<string>();
        public Dictionary<string, string> data = new Dictionary<string, string>();

        public Cat(string name)
        {
            this.name = name;
            this.breed = "Fying Tabby";
            this.age = 4;
            this.canFly = true;
        }
    }
}
