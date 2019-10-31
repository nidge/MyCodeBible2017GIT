using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfacesExample2
{
    class InterfaceImplementer : IMyInterface
    {
        static void Main()
        {
            InterfaceImplementer iImp = new InterfaceImplementer();
            iImp.MethodToImplement();
        }

        public void MethodToImplement()
        {
            Console.WriteLine("MethodToImplement() called.");
        }
    }

    interface IMyInterface
    {
        void MethodToImplement();
    }
}
