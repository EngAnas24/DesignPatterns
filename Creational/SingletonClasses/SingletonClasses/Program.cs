using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => Method1(),
                () => Method2()
                );

            

           
            Console.ReadKey();
        }

        public static void Method1()
        {
            Class c1 = Class.GetInstance();
            c1.print("Hi am c1");
        }

        public static void Method2()
        {
            Class c2 = Class.GetInstance();
            c2.print("Hi am c2");
        }
    }
}
