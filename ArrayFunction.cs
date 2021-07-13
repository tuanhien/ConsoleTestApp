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
            int temp;
            Console.Write("Input the number of elements to be stored in the array: ");
            temp = Convert.ToInt32(Console.ReadLine());
            List<int> arrInput = new List<int>();
            Console.WriteLine($"Input {temp} elements in the array: ");
            for (int i = 0; i < temp; i++)
            {
                Console.Write("element - {0}: ", i);
                arrInput.Add(Convert.ToInt32(Console.ReadLine()));
            }

            while(arrInput.Count > 2)
            {
                for( int i = 0; i < arrInput.Count - 1; i++)
                {
                    for(int j = i+1; j < arrInput.Count; j++)
                    {
                        if(arrInput[i] == arrInput[j])
                        {
                            arrInput.RemoveAt(i);
                            arrInput.RemoveAt(j-1);
                        }
                    }
                }
            }
            Console.WriteLine("The unique elements found in the array are: ");
            foreach(var r in arrInput)
            {
                Console.Write(r + " ");
            }
        }
    }
}
