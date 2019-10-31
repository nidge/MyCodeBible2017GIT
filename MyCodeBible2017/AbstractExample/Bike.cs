using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractExample
{
    class Bike : Vehicle
    {
        public override void FixBrakes()
        {
            // Bike has unique code to fix brakes, hence it is marked as abstract in base (Vehicle) class
            Console.WriteLine("In the FixBrakes method in the Bike class");
        }
    }
}
