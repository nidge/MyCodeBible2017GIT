using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractExample
{
    public abstract class Vehicle
    {
        // FixBrakes is marked as Abstract as all deriving classes need to provide their 
        // own unique implementation (Car and Bike will have very different ways of fixing brakes)
        public abstract void FixBrakes();

        // This is in Base class as all deriving classes will implement the same Drive Method
        public void Drive()
        {
            Console.WriteLine("In the Drive method in Base (Vehicle) class");
        }
    }
}
