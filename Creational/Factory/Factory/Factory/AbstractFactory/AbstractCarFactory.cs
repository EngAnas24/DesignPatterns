using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory.AbstractFactory
{
     interface AbstractCarFactory
    {
        void drawTire(string Type);
        Car GetCar(string Type);
        string SelectYourCar();
    }
}
