using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualAndOverrideMethods
{
    class Program
    {
        public class Shape
        {
            public const double PI = Math.PI;
            protected double x, y;
            public Shape()
            {
            }
            public Shape(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public virtual double Area()
            {
                return x * y;
            }
        }

        public class Circle : Shape
        {
            public Circle(double r)
                : base(r, 0)
            {
            }

            public override double Area()
            {
                return PI * x * x;
            }
        }

        class Sphere : Shape
        {
            public Sphere(double r)
                : base(r, 0)
            {
            }

            public override double Area()
            {
                return 4 * PI * x * x;
            }
        }

        class Cylinder : Shape
        {
            public Cylinder(double r, double h)
                : base(r, h)
            {
            }

            public override double Area()
            {
                return 2 * PI * x * x + 2 * PI * x * y;
            }
        }

        static void Main()
        {
            double r = 3.0, h = 5.0;

            Shape s = new Shape(r, h);
            Shape c = new Circle(r);
            Shape sp = new Sphere(r);
            Shape l = new Cylinder(r, h);
            // Display results:
            Console.WriteLine("Area of Shape    = {0:F2}", s.Area());
            Console.WriteLine("Area of Circle   = {0:F2}", c.Area());
            Console.WriteLine("Area of Sphere   = {0:F2}", sp.Area());
            Console.WriteLine("Area of Cylinder = {0:F2}", l.Area());

            Console.ReadLine();
        }
    }
    /*
        Output:
        Area of Circle   = 28.27
        Area of Sphere   = 113.10
        Area of Cylinder = 150.80
    */
}
