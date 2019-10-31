using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClasses
{
    public class Dog : Mammal
    {
        public override void Sleep()
        {
            Console.WriteLine("I'm in the Dog class");
        }

        public void OtherStuff()
        {
            Dog d = new Dog();
            d.Eat();   // This uses the method in the Mammal class (since we are inheriting from it)
            d.Sleep(); // This uses our own implementation (since it is an abstract class)
        }

    }

    
}
