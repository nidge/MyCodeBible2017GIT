using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSearchLibraryConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface based programming example");
            ISearch mySearch = new Search();
            List<string> results = mySearch.GetSearchResult("F");
            Console.WriteLine("Search results : ");
            foreach (string result in results)
            {
                Console.WriteLine(result);
            }

            Console.Read();

        }
    }
}
