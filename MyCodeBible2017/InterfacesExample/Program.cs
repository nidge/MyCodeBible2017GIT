using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfacesExample
{

    // Consider the concept of data hiding. Let's say you want to provide a class to some client code, 
    // but don't want to give them full access. One way to restrict access without limiting the 
    // functionality of your class is to implement an interface and require the client code to get 
    // objects through a factory:
    public class Program
    {
        static void Main()
        {
            IFoo myfoo = FooFactory.GetFoo();
            Bar mybar = new Bar();
            myfoo.Print();
            mybar.Print();
            mybar.Test();
        }
    }

    // Restricted type for clients
    public interface IFoo
    {
        void Print();
    }

    // Factory for clients
    public class FooFactory
    {
        public static IFoo GetFoo()
        {
            return new Bar();
        }
    }

    // Fully functional type for us
    internal class Bar : IFoo
    {
        public void Print()
        {
            Console.WriteLine("Foo!");
        }
        public void Test()
        {
            Console.WriteLine("Test");
        }
    }
}






