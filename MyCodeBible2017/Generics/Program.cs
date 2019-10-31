using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Generics allow you to delay the specification of the data type of programming elements in a class 
// or a method, until it is actually used in the program. In other words, generics allow you to 
// write a class or method that can work with any data type.

// You write the specifications for the class or the method, with substitute parameters for data types. 
// When the compiler encounters a constructor for the class or a function call for the method, it 
// generates code to handle the specific data type

namespace Generics
{
    public class MyGenericArray<T>
    {
        private T[] array;
        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }
        public T getItem(int index)
        {
            return array[index];
        }
        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {




            //declaring an int array
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);
            //setting values
            for (int c = 0; c < 5; c++)
            {
                intArray.setItem(c, c * 5);
            }
            //retrieving the values
            for (int c = 0; c < 5; c++)
            {
                Console.Write(intArray.getItem(c) + " ");
            }
            Console.WriteLine();
            //declaring a character array
            MyGenericArray<char> charArray = new MyGenericArray<char>(5);
            //setting values
            for (int c = 0; c < 5; c++)
            {
                charArray.setItem(c, (char)(c + 97));
            }
            //retrieving the values
            for (int c = 0; c < 5; c++)
            {
                Console.Write(charArray.getItem(c) + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
