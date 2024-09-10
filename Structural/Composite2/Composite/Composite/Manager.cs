using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Composite
{
    class Manager : IEmployee
    {
       public List<IEmployee> employees;
        public string Name { get; set; }
        public string Department { get; set; }

        public  Manager(string name,string Dep)
        {
            Name= name;
            Department= Dep;
            employees = new List<IEmployee>();
        }

        public void GetDetails()
        {
            Console.WriteLine(" Name :{0} Department {1} -Manager(Composite)", this.Name,this.Department);
            foreach (IEmployee e in employees)
            {
                e.GetDetails();
            }
        }
    }
}
