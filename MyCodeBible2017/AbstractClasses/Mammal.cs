using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClasses
{
    public abstract class Mammal
    {
        public abstract void Sleep();

        public void Eat()
        {
            Console.WriteLine("In the Mammal Eat method");
        }
    }
}
