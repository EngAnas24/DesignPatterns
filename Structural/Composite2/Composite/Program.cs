using Composite.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployee Anas = new Employee("Anas","Computer Engineer");
            IEmployee eng = new Employee("Anas", "Computer Engineer");
            IEmployee annas = new Employee("Anas", "Computer Engineer");

            IEmployee manager = new Manager("Abdulkareem", "Teacher") { employees = { Anas,eng,annas} };
            manager.GetDetails();

            Console.ReadKey();
        }
    }
}
