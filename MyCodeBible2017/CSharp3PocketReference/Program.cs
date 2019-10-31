using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp3PocketReference
{
    class Program
    {

        public enum BorderSide
        { Left, Right, Top, Bottom }


        public enum Vowel
        { a, e, i, o, u }

        const int JANUARY = 1;

        static void Main(string[] args)
        {
            UnitConverter feetToInches = new UnitConverter(12);
            UnitConverter milesToFeet = new UnitConverter(5280);

            Console.WriteLine(feetToInches.Convert(30)); // 360
            Console.WriteLine(feetToInches.Convert(100)); // 1200
            Console.WriteLine(feetToInches.Convert(milesToFeet.Convert(1))); // 63360

            Panda p1 = new Panda("Pan Dee");
            Panda p2 = new Panda("Pan Dah");

            Console.WriteLine(p1.Name);
            Console.WriteLine(p2.Name);
            Console.WriteLine(Panda.Population);

            BorderSide topSide = BorderSide.Top;
            bool isTrue = (topSide == BorderSide.Top); // true

            foreach (char s in "house")
            {
                Console.Write(s + " ");
            }

            Stock msft = new Stock();
            msft.CurrentPrice = 30;
            msft.CurrentPrice -= 3;
            Console.WriteLine(msft.CurrentPrice);


            string msc = MyStaticClass.MyMethod();
            Console.WriteLine(msc);

            MyNonStaticClass mnsc = new MyNonStaticClass();
            Console.WriteLine(mnsc.MyMethod());

            Shares share = new Shares { Name = "MyShares", SharesOwned = 1000 };
            Console.WriteLine(share.Name);
            Console.WriteLine(share.SharesOwned);

            House mansion = new House { Name = "Mansion", Mortage = 250000 };

            Console.WriteLine(mansion.Name);
            Console.WriteLine(mansion.Mortage);

            Console.ReadLine();

        }
    }

    public class UnitConverter
    {
        int ratio;

        public UnitConverter(int unitRatio)  // Constructor
        {
            ratio = unitRatio;
        }

        public int Convert(int unit) // Method
        {
            return unit * ratio;
        }
    }

    public class Panda
    {
        public string Name; // Instance field
        public static int Population;  // Static field

        public Panda(string n) // Constructor
        {
            Name = n;
            Population = Population + 1;
        }
    }

    public class Stock
    {
        private decimal currentPrice;  // the private "backing" field

        public Stock()
        { }

        public decimal CurrentPrice // the public property
        {
            get { return currentPrice; }
            set { currentPrice = value; }
        }

    }

    public static class MyStaticClass
    {
        public static string MyMethod()
        {
            return "This is data from a static class.  Note how it is called in Main";
        }
    }

    public class MyNonStaticClass
    {
        public string MyMethod()
        {
            return "This is data from a NON static class.  Note how it is called in Main";
        }
    }

    public class Assett
    {
        public string Name;
    }

    public class Shares : Assett // inherits from Assett
    {
        public long SharesOwned;
    }

    public class House : Assett // inherits from Assett
    {
        public decimal Mortage;
    }



}
