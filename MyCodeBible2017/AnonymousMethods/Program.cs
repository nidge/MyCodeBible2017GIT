using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnonymousMethods
{
    // Declare a delegate
    delegate void Printer(string s);
    delegate int Transformer (int i);

    class Program
    {
        // The following example demonstrates two ways of instantiating a delegate:
        //     Associating the delegate with an anonymous method.
        //     Associating the delegate with a named method (DoWork).
        // In each case, a message is displayed when the delegate is invoked.

        static void Main(string[] args)
        {
            // Instatiate the delegate type using an anonymous method.
            Printer p = delegate(string j)
            {
                Console.WriteLine("J = " + j);
            };

            // Results from the anonymous delegate call.
            p("The delegate using the anonymous method is called.");

            // The delegate instantiation using a named method "DoWork".
            p = new Printer(DoWork);

            // Results from the old style delegate call.
            p("The delegate using the named method is called.");


            // Another example of an anonymous method
            Transformer sqr = delegate(int x)
            {
                return x * x;
            };
            Console.WriteLine(sqr(3));

            // Lambda expression which is equivalent to the above
            Transformer sqr1 = (int x) => { return x * x; };
            Console.WriteLine(sqr(3));

            Console.ReadLine();
        }

        // The method associated with the named delegate.
        static void DoWork(string k)
        {
            System.Console.WriteLine("In DoWork " + k);
        }

        static void OtherLambdaExamples()
        {
            // the first int is the x' type
            // the second int is the return type
            Func<int, int> foo = x => x * x;
            Console.WriteLine(foo(7));

            // Initialize the list:
            var values = new List<int>() { 7, 13, 4, 9, 3 };
            // Map the anonymous function over all elements in the list, return the new list
            var foo1 = values.ConvertAll(d => d * d);
            // the result of the foo variable is of type System.Collections.Generic.List<Int32>
        }

    }
}

/* Output:
    J = The delegate using the anonymous method is called.
    In DoWork The delegate using the named method is called.
*/