using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractExample
{
    class Tester
    {
        static void Main(string[] args)
        {
            Vehicle car;
            car = new Car();
            car.Drive();
            car.FixBrakes();

            Vehicle bike;
            bike = new Bike();
            bike.Drive();
            bike.FixBrakes();

            Console.ReadKey();


        }
    }
}
