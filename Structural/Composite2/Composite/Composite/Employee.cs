using System;

namespace Composite.Composite
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee(string name, string dep)
        {
            Name = name;
            Department = dep;
        }

        public void GetDetails()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Name: {Name}, Department: {Department} (Leaf)";
        }
    }
}
