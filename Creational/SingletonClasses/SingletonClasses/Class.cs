using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonClasses
{
    sealed class Class
    {
        private static int counter;
        /*  private static Class Instance = null;
          private static readonly object obj  = new object();*/

        // private static readonly Class Instance = new Class();
        private static readonly Lazy< Class> Instance = new Lazy<Class>( ( ) => new Class());
        private Class()
        {
            counter ++;
            Console.WriteLine("Counter Number: "+counter.ToString());
        }

        public static Class GetInstance()
        {
            /* if (Instance == null)
             lock (obj)
             {
                 if (Instance == null)
                 {
                     Instance = new Class();
                 }
             }
             return Instance;*/
            return Instance.Value; 

        }

        public void print(string text)
        {
            Console.WriteLine(text);
        }

     
    }
}
