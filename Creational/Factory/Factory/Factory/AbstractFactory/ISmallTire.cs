using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory.AbstractFactory
{
     interface ISmallTire
    {
        void drawSmallTire();
    }

    class SmallTire: ISmallTire
    {
        public void drawSmallTire()
        {
            Console.WriteLine("Is using SmallTire");
        }

    }
}
