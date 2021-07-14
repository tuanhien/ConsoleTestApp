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

        //Write a program in C# Sharp to count the frequency of each element of an array
        public static void Exercise8()
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

            Hashtable htTemp = new Hashtable();

            for (int i = 0; i < arrInput.Count; i++)  
            {
                int t = 1;
                if (htTemp.Count > 0 && htTemp.ContainsKey(arrInput[i]))
                {
                    t = Convert.ToInt32(htTemp[arrInput[i]]);
                    t++;
                    htTemp[arrInput[i]] = t;
                }
                else
                {
                    htTemp.Add(arrInput[i], t);
                }
            }

            Console.Write("Frequency of all elements of array: \n");
            foreach(DictionaryEntry r in htTemp)
            {
                Console.Write($"{r.Key} occurs {r.Value} times\n");
            }
        }

        //Write a C# Sharp program to re-arrange the elements in a given array of numbers
        //and check the numbers are consecutive or not
        public static void Exercise36(ArrayList arrInput)
        {
            foreach(var r in arrInput)
            {
                //if (!int.TryParse(r, out int result))
                //{

                //}
            }
        }
    }
}
