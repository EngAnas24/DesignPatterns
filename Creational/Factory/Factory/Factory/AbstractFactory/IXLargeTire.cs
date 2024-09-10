using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory.AbstractFactory
{
    interface IXLargeTire
    {
        void drawXLargeTire();
    }

    class XLargeTire : IXLargeTire
    {
        public void drawXLargeTire()
        {
            Console.WriteLine("Is using XLarge Tire");
        }

    }
}
