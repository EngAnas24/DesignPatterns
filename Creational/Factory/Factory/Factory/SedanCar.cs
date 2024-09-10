using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory
{
    internal class SedanCar : Car
    {
        public SedanCar()
        {
            CarName = "BMW";
            CarModel = "2020";
        }
    }
}
