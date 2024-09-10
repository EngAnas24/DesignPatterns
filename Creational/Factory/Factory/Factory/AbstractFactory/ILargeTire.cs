using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory.AbstractFactory
{
    interface ILargeTire
    {
        void drawLargeTire();
    }

    class LargeTire : ILargeTire
    {
        public void drawLargeTire()
        {
            Console.WriteLine("Is using Large Tire");
        }

    }
}
