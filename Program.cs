using System;
using System.Collections;

namespace ConsoleTestApp
{
    class Program
    {
        public static void CountInputChar(string a) 
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

        static void Main(string[] args)
        {
            string a = "Day la chuoi test";
            CountInputChar(a);
        }
    }
}
