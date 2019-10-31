using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyBagExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Properties["SocialSecurityNumber"].Value = "123"; 
            emp1.name = "Jim";

            Console.WriteLine(emp1.Properties["SocialSecurityNumber"].Value);

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
