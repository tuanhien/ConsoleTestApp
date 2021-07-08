using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleTestApp
{
    class Program
    {
        //a program that show how many times a char appear.
        public static void CountCharInput(string a) 
        {
            ArrayList arrTemp = new ArrayList();

            Console.WriteLine($"Chuoi truoc khi dem co {a.Length} ki tu");
            var b = a.Replace(" ", "");
            while(b.Length > 0)
            {
                arrTemp.Add(b[0]);
                for (int j = 1; j < b.Length; j++)
                {
                    if (b[0] == b[j])
                    {
                        arrTemp.Add(b[j]);
                        b.Remove(j,1);
                    }
                }
                b = b.Replace($"{b[0]}", "");
                Console.WriteLine($"Ki tu {arrTemp[0]} co {arrTemp.Count} phan tu");
                arrTemp.Clear();
            }
        }

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

        //Write a C# Sharp program to remove all "a" in each string in given list of strings and return the new string
        public static void RemoveACharacter(List<string> vs)
        {
            ArrayList temp = new ArrayList();
            foreach (string r in vs)
            {
                for(int i = 0; i < r.Length; i++)
                {
                    if(Convert.ToString(r[i]) == "a") { }
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

        static void Main(string[] args)
        {
            List<string> test = new List<string> { "abc", "cdaef", "js", "php" };
            RemoveACharacter(test);
        }
    }
}
