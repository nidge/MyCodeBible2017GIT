//  This is the code for the 1-day course at Apex on Wednesday 20th February 2013 on the subject
//  C# New Language Features & Coding Standards
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace CSharpNewLanguageFeaturesAndCodingStandardsCourse
{
    class Program
    {
        private Dictionary<int, string> questions = new Dictionary<int, string>();
        private SortedList sl = new SortedList();
        List<string> strings = new List<string>
        {
            "One", "two", "ten"
        };

        static void Main(string[] args)
        {
            IDictionary<double, int> x1 = new Dictionary<double, int>();

            // y is effectively Dictionary<double, int> below 
            var y = new Dictionary<double, int>();

            Program p = new Program();

            p.questions.Add(1, "How old are you1?");
            p.questions.Add(5, "How old are you5?");
            p.questions.Add(4, "How old are you4?");
            p.questions.Add(3, "How old are you3?");
            p.questions.Add(2, "How old are you2?");
            p.Answer1();
            p.Answer2();
            p.Answer3();
            p.PredicateSample();
            p.myExtensionMethod();

            try
            {
                IgnoreCaseonStringComparison();
            }
            catch (ApplicationException ex)
            {
                throw;
            }





            Console.ReadLine();
        }

        private void myPrivateTest()
        {
            int x = 10 + 10;
        }

        private static void IgnoreCaseonStringComparison()
        {
            string val1 = "ABC";
            string val2 = "abc";

            if (val1.Equals(val2, StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Items are equal - test using InvariantCultureIgnoreCase");
            }
        }

        // Lambda
        public void Answer1()
        {
            var x = questions.OrderBy(k => k.Key);
            foreach (var item in x)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }

        public void Answer2()
        {
            var d = questions.Where((w) => w.Key % 2 == 0).OrderBy(m => m.Key).Take(2);
            foreach (var item in d)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }

        //Lambda (Order descending)
        public void Answer3()
        {
            var d = questions.Where((w) => w.Key % 2 == 0).OrderByDescending(m => m.Key).Take(2);
            foreach (var item in d)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }

        // Action
        public void ActionSample()
        {
            Action a = new Action(() =>
            {

            });

            Action<string> a2 = new Action<string>((s) =>
            {
                Console.WriteLine(s);
            });

            a2.Invoke("Print me");
            a2("Print me again");   // same as above line
        }

        //Func
        public void FuncSample()
        {
            Func<string> f = new Func<string>(() =>
            {
                return "";
            });

            var s = f();
        }

        public void FuncSample1()
        {
            Func<int, int, string> f1 = new Func<int, int, string>((x, y) =>
            {
                return (x + y).ToString();
            });

            var s = f1(1, 5);
            var s2 = f1(10, 20);
            var s3 = f1(10, 40);

            TestFunc(f1);
        }

        public void TestFunc(Func<int, int, string> func1)
        {
            Console.WriteLine(func1(10, 70));
        }

        // Predicate
        public void PredicateSample()
        {
            Predicate<string> hasThreeLetters = new Predicate<string>((s) =>
            {
                return (s.Length == 3);
            });

            Console.WriteLine(strings.TrueForAll(hasThreeLetters));

            Console.WriteLine(strings.TrueForAll((s) =>
            {
                return s.Length < 6;
            }));
        }

        // Extension methods
        public void myExtensionMethod()
        {
            DataClass c = new DataClass();
            Console.WriteLine(c.GetId());
        }

        // Parallel stuff
        public void parallelMethod()
        {
            IEnumerable<string> mystrings = new List<string>()
            {
                "Test1",
                "Test2",
                "Test3"
            };

            var x = mystrings.Where(w => w.Length == 3).AsParallel();

            List<string> mystrings1 = new List<string>()
            {
                "Test1",
                "Test2",
                "Test3"
            };

            var x1 = mystrings1.Where(y => y.Length == 3).AsParallel();

            Parallel.ForEach(mystrings1, (s) =>
            {
                // s.Length 
            });

            //////
            Task t = Task.Factory.StartNew(() =>
            {
                //
            });
            t.ContinueWith((taskWithResult) =>
            {
                //
            });

            ///////
            Task<string> t1 = Task<string>.Factory.StartNew(() =>
            {
                return string.Empty;

            });
            t1.ContinueWith((taskWithResult1) =>
            {
                var b = taskWithResult1.Result;
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

    }

    public static class MyExtensionClass
    {
        // the word 'this' indicates it is extending the class DataClass
        public static int GetId(this DataClass dc)
        {
            return 10;
        }
    }

    public sealed class DataClass
    {
        public string GetName()
        {
            return "Bob";
        }
    }

}
