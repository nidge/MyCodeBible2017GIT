using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractExample
{
    class Car : Vehicle
    {
        public override void FixBrakes()
        {
            // Car has unique code to fix brakes, hence it is marked as abstract in base (Vehicle) class
            Console.WriteLine("In the FixBrakes method in the Car class");
        }
    }
}
