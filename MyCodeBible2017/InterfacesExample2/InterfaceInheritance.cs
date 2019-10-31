using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfacesExample2
{
    

    interface IParentInterface
    {
        void ParentInterfaceMethod();
    }

    interface IChildInterface : IParentInterface
    {
        void MethodToImplement();
    }

    class InterfaceInheritance : IChildInterface
    {
        //static void Main()
        //{
        //    InterfaceInheritance iImp = new InterfaceInheritance();
        //    iImp.MethodToImplement();
        //    iImp.ParentInterfaceMethod();
        //}

        public void MethodToImplement()
        {
            Console.WriteLine("MethodToImplement() called.");
        }

        public void ParentInterfaceMethod()
        {
            Console.WriteLine("ParentInterfaceMethod() called.");
        }
    }
}
