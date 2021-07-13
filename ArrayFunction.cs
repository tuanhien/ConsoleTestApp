using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApp
{
    public class ArrayFunction
    {
        //Write a program in C# Sharp to store elements in an array and print it.
        public static void Exercise1()
        {
            Console.WriteLine("Input 10 elements in the array:");
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Element - {i}: ");
                string a = Console.ReadLine();
                arrayList.Add(a);
            }
            Console.Write("Elements in array are: ");
            foreach (var r in arrayList)
            {
                Console.Write(r + " ");
            }
        }

        //Write a program in C# Sharp to print all unique elements in an array
        public static void Exercise6()
        {
            
        }
    }
}
