using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory
{
    abstract class Car
    {
        public string CarName { get; set; }
        public string CarModel { get; set; }

        
        public void RunCar()
        {
            Console.WriteLine(CarName + ": Is running ");
        }
         public void ShowCar()
        {
            Console.WriteLine(CarModel + ": Is showing ");
        }
    }
}
