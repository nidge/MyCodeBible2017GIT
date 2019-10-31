using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Example1();

            Student.Example2();

            Console.ReadKey();

            
        }

        private static void Example1()
        {
            string[] names = { "Tom", "Dick", "Harry" };
            var filteredNames = names.Where(n => n.Length >= 4);
            foreach (string name in filteredNames) Console.WriteLine(name);
        }
    }

    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public List<int> Scores;

        static List<Student> students = new List<Student>()
        {
             new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
             new Student{First="Nigel", Last="Smyth", ID=1, Scores= new List<int>{91,2,3,4,90}}
        };

        public static void Example2()
        {
            // Create the query
            IEnumerable<Student> studentQuery =
                from student in students
                where student.Scores[0] > 90
                orderby student.First
                select student;

            foreach (Student student in studentQuery)
            {
                Console.WriteLine("{0} {1}", student.First, student.Last);

            }

        }
    }
}
