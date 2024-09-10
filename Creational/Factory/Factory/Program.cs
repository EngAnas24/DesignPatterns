using Factory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = null;
            string type=new CarFactory().SelectYourCar();
            car = (new CarFactory()).GetCar(type) ;
          new CarFactory().drawTire(type);

            CarCommand(car);
            Console.ReadKey();

        }

        public static void CarCommand(Car car) 
        {
            car.RunCar();
            car.ShowCar();
        }
    }
}
