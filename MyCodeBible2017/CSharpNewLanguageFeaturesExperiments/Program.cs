//  This is the my experiments after the 1-day course at Apex on Wednesday 20th February 2013 on the subject
//  C# New Language Features & Coding Standards
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;


namespace CSharpNewLanguageFeaturesExperiments
{
    //The delegate "Delegate_Prod" is declared with double return type and accepts only two integer parameters. 
    public delegate double Delegate_Prod(int x, int y);

    class Program
    {

        // create a delegate
        delegate int Transform(int x);


        //the method named fn_Prodvalues is defined with double return type and two integer parameters. 
        static double fn_ProdValues(int val1, int val2)
        {
            return val1 * val2;
        }



        static void Main(string[] args)
        {
            Program p = new Program();

            p.addressExtensionMethod();

            Example example = new Example();
            example.Number = 5; // set { }
            Console.WriteLine(example.Number); // get { }

            Person per = new Person();
            per.Name = "Jim";        // the set accessor is invoked here 
            per.Age = 25;
            Console.WriteLine(per.Name);  // the get accessor is invoked here
            Console.WriteLine(per.Age);

            // Intialize a new object.
            Customer cust1 = new Customer(4987.63, "Northwind", 90108);

            //Modify a property
            cust1.TotalPurchases += 499.99;

            Console.WriteLine(cust1.TotalPurchases + " " + cust1.Name);

            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "What is your name?");
            dict.Add(3, "What is your age?");
            dict.Add(4, "Where do you live?");
            dict.Add(2, "What are your hobbies?");

            var items = dict.OrderBy(s => s.Key);
            foreach (var item in items)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }

            Transform t = Square;
            int result = t(3);
            Console.WriteLine(result);

            //the delegate instance is created and the function name is passed to the delegate instance
            //Creating the Delegate Instance
            Delegate_Prod delObj = new Delegate_Prod(fn_ProdValues);
            //use a delegate for processing
            //pass two values to the delegate 
            //Here delegate object encapsulates the method functionalities and returns the result as we specified in the method. 
            double res = delObj(5, 10);
            Console.WriteLine(res);

            List<int> l = new List<int> { 1, 2, 3, 4, 5 };
            Dictionary<int, string> dict2 = new Dictionary<int, string>();
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(4, "dd");
            sl.Add(3, "cc");
            sl.Add(2, "bb");
            sl.Add(1, "aa");
            foreach (var item in sl)
            {
                Console.WriteLine(item.Key);
            }

            SortedList<string, string> sl1 = new SortedList<string, string>();
            sl1.Add("ddd", "ddd");
            sl1.Add("aaa", "aaa");
            foreach (var item in sl1)
            {
                Console.WriteLine(item.Key);
            }


            List<int> list = new List<int> { 1, 2, 3, 9, 10, 11, 12 };

            //The list gets populated with values
            List<int> matches = list.FindAll(val => val != 9);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }

            p.GetWordCountExtensionMethod();


            string test = "this is some text without a capital letter";
            Console.WriteLine(test + ": " + test.HasCapitals());
            test = "This is some text WITH a capital letter";
            Console.WriteLine(test + ": " + test.HasCapitals());




            Func<string, string> toUpper = s => s.ToUpper();
            string upperText = toUpper("Hello world!");
            Console.WriteLine(upperText);

            Func<DateTime, int> month = d => d.Month;
            int m = month(new DateTime(2011, 3, 14));
            Console.WriteLine(m);

            Console.ReadLine();


        }

        static int Square(int y)
        {
            return y * y;
        }

        // Extension methods
        public void addressExtensionMethod()
        {
            Address a = new Address();
            Console.WriteLine(a.GetStreet());
        }

        // Extension methods
        public void GetWordCountExtensionMethod()
        {
            String s = "Here is some text";
            Console.WriteLine("Total number of words: " + s.GetWordCount());
        }
    }

    public sealed class Address
    {
        public string GetHomeTown()
        {
            return "Leeds";
        }
    }

    public static class AddressExtended
    {
        public static string GetStreet(this Address dc)
        {
            return "Sharp Mews";
        }
    }

    //Extension methods must be defined in a static class
    public static class WordCount
    {
        // This is the extension method.
        // The first parameter takes the "this" modifier
        // and specifies the type for which the method is defined.
        public static int GetWordCount(this string s)
        {
            return s.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static bool HasCapitals(this string text)
        {
            foreach (char c in text)
            {
                if (char.IsUpper(c))
                {
                    return true;
                }
            }
            return false;
        }

        // no option for end date in Staff room
    }

    class Example
    {
        int _number;
        public int Number
        {
            get
            {
                return this._number;
            }
            set
            {
                this._number = value;
            }
        }


    }

    class Person
    {
        private string name;    // the name field 
        public string Name      // the Name property
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        // auto-implemented property.  Note that this does exactly the same as the above
        public int Age { get; set; }
    }

    // This class is mutable. Its data can be modified from 
    // outside the class. 
    class Customer
    {
        // Auto-Impl Properties for trivial get and set 
        public double TotalPurchases { get; set; }
        public string Name { get; set; }
        public int CustomerID { get; set; }

        // Constructor 
        public Customer(double purchases, string name, int ID)
        {
            TotalPurchases = purchases;
            Name = name;
            CustomerID = ID;
        }
        // Methods 
        public string GetContactInfo() { return "ContactInfo"; }
        public string GetTransactionHistory() { return "History"; }

        // .. Additional methods, events, etc.
    }


}
