using System.Xml.Linq;

namespace carvedrock.bl.principles.FCOI
{
    public class Person
    {
        public string Name;
        public int Age;
        public string Title;
        public Person(string title, string name, int age)
        {
            Title = title;
            Name = name;
            Age = age;
        }
    }
}