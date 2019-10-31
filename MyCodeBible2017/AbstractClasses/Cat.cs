using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClasses
{
    public class Cat : Mammal
    {
        public override void Sleep()
        {
            Console.WriteLine("I'm in the Cat class");
        }
    }
}
