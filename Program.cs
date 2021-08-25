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
            int temp, result;
            Console.WriteLine("Input a number: ");
            temp = Convert.ToInt32(Console.ReadLine());
            result = FunctionExercise.Exercise11(temp);
            Console.WriteLine(result);
        }
    }
}
