using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApp
{
    public class SearchingAndSortingFunction
    {
        //Write a C# Sharp program to sort a list of elements using Insertion sort
        public static void InsertionSort(int[] arrInput)
        {
            for (int i = 1; i < arrInput.Length; ++i)
            {
                int key = arrInput[i];
                int j = i - 1;

                while (j >= 0 && arrInput[j] > key)
                {
                    arrInput[j + 1] = arrInput[j];
                    j = j - 1;
                }
                arrInput[j + 1] = key;
            }

            foreach (var r in arrInput)
            {
                Console.Write(r + " ");
            }
        }

        //Write a C# Sharp program to sort a list of elements using Bubble sort
        public static void Exercise3()
        {
            Console.Write("Input a string of number: ");
            string temp = Console.ReadLine();
            List<int> arrInput = new List<int>();
            temp = temp.Trim();

            foreach(var r in temp.Split(' '))
            {
                if(r == " " || r == "") { }
                else
                {
                    arrInput.Add(Convert.ToInt32(r));
                }
            }

            for(int i = 0; i < arrInput.Count - 1; i++)
            {
                for(int j = i + 1; j < arrInput.Count; j++)
                {
                    if(arrInput[i] > arrInput[j])
                    {
                        int t = arrInput[i];
                        arrInput[i] = arrInput[j];
                        arrInput[j] = t;
                    }
                }
            }

            foreach(var r in arrInput)
            {
                Console.Write(r + " ");
            }
        }
    }
}
