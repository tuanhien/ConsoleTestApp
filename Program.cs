using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ConsoleTestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int temp, result;
            //Console.Write("Input a number: ");
            //temp = Convert.ToInt32(Console.ReadLine());
            //RecursionFunction.Exercise1(temp,1);
            
            for (int i = 0; i < 10; i++)
            {
                RecursionFunction.Fibo(i);
            }
            //Console.Write(RecursionFunction.GiaiThua(5));
            //RecursionFunction.Exercise14("w3resource");
            //LinQFunction.Exercise3();
            //DateTimeFunction.Exercise8();
        }
    }
}
