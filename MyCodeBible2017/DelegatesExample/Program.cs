﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    class Program
    {
        delegate void TestDelegate(string s);
        delegate int TestDelegate2(int i);
        static void M(string s)
        {
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            // Original delegate syntax required  
            // initialization with a named method.
            TestDelegate testDelA = new TestDelegate(M);

            // C# 2.0: A delegate can be initialized with 
            // inline code, called an "anonymous method." This
            // method takes a string as an input parameter.
            TestDelegate testDelB = delegate(string s) { Console.WriteLine(s); };

            // C# 3.0. A delegate can be initialized with 
            // a lambda expression. The lambda also takes a string 
            // as an input parameter (x). The type of x is inferred by the compiler.
            TestDelegate testDelC = (x) => { Console.WriteLine(x); };

            // Invoke the delegates.
            testDelA("This is TestDelA");
            testDelB("This is TestDelB");
            testDelC("This is TestDelC");

            TestDelegate2 testDelD = x => x * x;

            Console.WriteLine(testDelD(12));

            Console.ReadKey();
        }
    }
}
