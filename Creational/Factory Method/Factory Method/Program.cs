using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Factory
    {
        public abstract Product FactoryMethod();
    }
     class ConcreteFactory1:Factory
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
    class ConcreteFactory2 : Factory
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
    abstract class Product
    {

    }
    class ConcreteProduct1:Product {}
     class ConcreteProduct2 : Product { }

    public class Program
    {
        
        static void Main(string[] args)
        {
            Factory[] creators = new Factory[2];
            creators[0] = new ConcreteFactory1();
            creators[1] = new ConcreteFactory2();
            // Iterate over creators and create products
            foreach (Factory creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  product.GetType().Name);
            }
            Console.ReadKey();
        }
    }
}
