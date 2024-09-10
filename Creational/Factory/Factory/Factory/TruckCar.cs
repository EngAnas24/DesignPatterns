using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory
{
    internal class TruckCar : Car
    {
        public TruckCar()
        {
            CarName = "Truck";
            CarModel = "2019";
        }
    }
}
