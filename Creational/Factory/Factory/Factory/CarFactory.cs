using Factory.Factory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory
{
     class CarFactory:AbstractCarFactory
    {

        public string SelectYourCar()
        {
            Console.WriteLine("Select your car:\n" +
             "S = SUV\n" +
             "U = Sedan\n" +
             "T = Truck");

            string trype = Console.ReadLine();
            return trype;
        }

        public Car GetCar(string Type)
        {
            switch (Type)
            {
                case "S":
                 return new SUVCar();
                case "U":
                return new SedanCar();
                default:
                return new TruckCar();
            }
        }

        public void drawTire(string Type)
        {
            switch (Type)
            {
                case "S":
                   new SmallTire().drawSmallTire();
                    break;
                case "U":
                    new LargeTire().drawLargeTire();
                    break;
                default:
                    new XLargeTire().drawXLargeTire();
                    break;
            }
        }
    }
}
