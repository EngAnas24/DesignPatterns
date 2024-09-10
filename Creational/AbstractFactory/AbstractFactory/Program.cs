using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();

    }

    class ConcreteFactoryA:AbstractFactory
    {
        public override  AbstractProductA CreateProductA()
        {
            return new ProductA();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB();
        }
    }

    abstract class AbstractProductA
    {

    }
    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);

    }
    class ProductA: AbstractProductA
    {

    }
    class ProductB: AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine($" {this.GetType().Name} interact with {a.GetType().Name}");
        }

    }


    class Client
    {
        private AbstractProductA abstractProductA;
        private AbstractProductB abstractProductB;
        public Client(AbstractFactory abstractFactory)
        {
             abstractProductA = abstractFactory.CreateProductA();
             abstractProductB = abstractFactory.CreateProductB();
        }
        public  void Run()
        {
            abstractProductB.Interact(abstractProductA);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory abstractFactory=new ConcreteFactoryA();
            Client client=new Client(abstractFactory);
            client.Run();
            

            Console.ReadKey();

        }
    }
}
