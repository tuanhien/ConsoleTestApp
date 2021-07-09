using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApp
{
    public class FPTRequiredClass
    {
        //a program that show how many times a char appear.
        public static void CountCharInput(string a)
        {
            ArrayList arrTemp = new ArrayList();

            Console.WriteLine($"Chuoi truoc khi dem co {a.Length} ki tu");
            var b = a.Replace(" ", "");
            while (b.Length > 0)
            {
                arrTemp.Add(b[0]);
                for (int j = 1; j < b.Length; j++)
                {
                    if (b[0] == b[j])
                    {
                        arrTemp.Add(b[j]);
                        b.Remove(j, 1);
                    }
                }
                b = b.Replace($"{b[0]}", "");
                Console.WriteLine($"Ki tu {arrTemp[0]} co {arrTemp.Count} phan tu");
                arrTemp.Clear();
            }
        }
    }
}
