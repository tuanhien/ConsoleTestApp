using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleTestApp
{
    public class LinQFunction
    {
        //Write a program in C# Sharp to show how the three parts of a query operation execute.
        public static void Exercise1()
        {
            int[] arrInput = new int[] {0,1,2,3,4,5,6,7,8,9};

            var arrTemp = from temp in arrInput
                            where temp % 2 == 0
                            select temp;

            foreach (var r in arrTemp)
            {
                Console.Write(r + " ");
            }
        }

        //Write a program in C# Sharp to find the positive numbers from a list of numbers using two where conditions in LINQ Query.
        public static void Exercise2()
        {
            int[] arrInput = new int[] {-1,-3,-5,1,2,4,5,10};
            Console.Write("The numbers within the range from 1 to 11 are: \n");
            var arrTemp = from r in arrInput
                          where r > 0 && r < 11
                          select r;
            foreach (var r in arrTemp)
            {
                Console.Write(r + " ");
            }
        }

        //Write a program in C# Sharp to find the number of an array and the square of each number
        public static void Exercise3()
        {
            int[] arrInput = new int[] { 5, 6, 7, 8 };
            var arrTemp = from int r in arrInput
                          let a = r * r
                          where a > 20
                          select new { r, a };
            foreach (var r in arrTemp)
            {
                Console.WriteLine(r);
            }
        }
    }
}