using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{

    // this code is taken from http://msdn.microsoft.com/en-us/library/ms173172.aspx
    class Program
    {
        public delegate void Del(string message);

        public delegate void DelWriteName(string name);

        delegate int Transformer (int x);

        delegate bool delLeapYear(int y);

        static void Main(string[] args)
        {
            // Instantiate the delegate.
            DelWriteName dwn = WriteMyName;
            Console.WriteLine("Enter your name");
            // Call the delegate.
            dwn(Console.ReadLine());

            // Instantiate the delegate.
            Del handler = DelegateMethod;
            // Call the delegate.
            handler("Hello World");
            MethodWithCallback(1, 2, handler);

            MethodClass obj = new MethodClass();
            Del d1 = obj.Method1;
            Del d2 = obj.Method2;
            Del d3 = DelegateMethod;

            //Both types of assignment are valid.
            Del allMethodsDelegate = d1 + d2;
            allMethodsDelegate += d3;

            //remove Method1
            allMethodsDelegate -= d1;

            // copy AllMethodsDelegate while removing d2
            Del oneMethodDelegate = allMethodsDelegate - d2;

            int invocationCount = d1.GetInvocationList().GetLength(0);



            Transformer t = Square;  // create delegate instance
            int result = t(3);  //invoke delegate
            Console.WriteLine(result); // 9



            delLeapYear ly = LeapYear;
            Console.WriteLine(ly(2008));  // true;



            Console.ReadLine();

            

        }

        private static void WriteMyName(string name)
        {
            Console.WriteLine("Your name is " + name);
        }

        static int Square(int x)
        {
            return x * x;
        }

        // Create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            System.Console.WriteLine(message);
        }

        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }

        static bool LeapYear(int year)
        {
            if (year % 4 == 0)
                return true;
            else
                return false;
        }

        
    }

    public class MethodClass
    {
        public void Method1(string message) { }
        public void Method2(string message) { }
    }
}



