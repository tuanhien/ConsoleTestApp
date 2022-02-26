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
            //Console.Write(RecursionFunction.GiaiThua(5));
            //RecursionFunction.Exercise14("w3resource");
            //LinQFunction.Exercise3();
            //DateTimeFunction.Exercise8();

            //Console.Write("Nhap vao n so Fibo: \n");
            //int n = Convert.ToInt32(Console.ReadLine());
            //if (n < 3)
            //{
            //    Console.Write("0 1");
            //}else
            //{
            //    for(int i = 0; i < n; i++)
            //    {
            //        Console.Write(RecursionFunction.InFibonacci(i) + " ");
            //    }
            //}

            Console.Write("Nhap vao n so Fibo: \n");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                Console.Write("0");
            } 
            else if(n == 2)
            {
                Console.Write("1");
            }
            else
            {
                Console.Write(RecursionFunction.FiboN(n));
            }
        }
    }
}
