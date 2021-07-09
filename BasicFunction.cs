using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApp
{
    public class BasicFunction
    {
        //A program that add "if" in the first string if it's not contains if in first element.
        public static void CheckFirstChar(string a)
        {
            string b = null;
            if (a.StartsWith("if"))
            {
                b = a;
            }
            else
            {
                b = "if " + a;
            }
            Console.WriteLine(b);
        }

        //a program that clear value if given list of int end with 7
        public static void RemoveValueEndWithSeven(List<int> vs)
        {
            ArrayList temp = new ArrayList();
            foreach (int a in vs)
            {
                if (Convert.ToString(a).EndsWith("7")) { }
                else
                {
                    temp.Add(a);
                }
            }
            foreach (int r in temp)
            {
                Console.WriteLine(r);
            }
        }

        //Write a C Sharp program to remove all "a" in each string in given list of strings and return the new string
        public static void RemoveACharacter(List<string> vs)
        {
            ArrayList temp = new ArrayList();
            foreach (string r in vs)
            {
                for (int i = 0; i < r.Length; i++)
                {
                    if (Convert.ToString(r[i]) == "a") { }
                    else
                    {
                        temp.Add(r[i]);
                    }
                }
            }
            if (temp == null)
            {
                Console.WriteLine("Nothing were remain");
            }
            else
            {
                Console.Write("New string: ");
                foreach (var t in temp)
                {
                    Console.Write(t);
                }
            }
        }

        //Write a C# Sharp program to create a new list from a given list of integers
        //where each integer multiplied by itself three times
        public static void MultipleThreeTimes(List<int> listInput)
        {
            ArrayList arrNew = new ArrayList();
            foreach (var r in listInput)
            {
                Convert.ToInt32(r);
                arrNew.Add(r * r * r);
            }
            Console.Write("New list is: ");
            foreach (var a in arrNew)
            {
                Console.Write(a + " ");
            }
        }

        //Write a C# Sharp program to check a given array (length will be at least 2) of integers
        //and return true if there are two values 15, 15 next to each other
        public static bool Check15(List<int> vs)
        {
            bool result;
            ArrayList t = new ArrayList();
            for (int i = 0; i < vs.Count - 1; i++)
            {
                if (vs[i] == vs[i + 1] && vs[i] == 15)
                {
                    result = true;
                    Console.Write(result);
                    return result;
                }
            }
            result = false;
            Console.Write(result);
            return result;
        }

        //Write a C# Sharp program that takes a number and a width also a number,
        //as input and then displays a triangle of that width, using that number.
        public static void HinhTamGiac(int a)
        {
            for (int i = 0; i <= a; i++)
            {
                for (int j = i + 1; j <= a; j++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
            }
        }
    }
}
