using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        public void Constructor(Builder builder)
        {
            builder.BuilderPartA();
            builder.BuilderPartB();
        }

    }
    public abstract class Builder
    {
        public abstract void BuilderPartA();
        public abstract void BuilderPartB();
        public abstract Product GetResult();


    }

    public  class ConcreteBuilder : Builder
    {
        private Product _product =new Product();
        public override void BuilderPartA()
        {
            _product.Add("PartA");
        }

        public override void BuilderPartB()
        {
            _product.Add("PartB");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

    public class Product
    {
        private List<string> _parts = new List<string>();
        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct Parts -------");
            foreach (string part in _parts)
                Console.WriteLine(part);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder builder=new ConcreteBuilder();
            director.Constructor(builder);
            Product product = builder.GetResult();
            product.Show();

            Console.ReadKey();
        }
    }
}
