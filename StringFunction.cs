using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ConsoleTestApp
{
    public class StringFunction
    {
        //Write a program in C# Sharp to print individual characters of the string in reverse order
        public static void Exercise4()
        {
            string inputString;
            Console.Write("Input string: ");
            inputString = Console.ReadLine();

            for(int i = inputString.Length - 1; i >= 0; i--)
            {
                Console.Write(inputString[i] + " ");
            }
        }

        //Write a program in C# Sharp to count the total number of words in a string.
        public static void Exercise5()
        {
            string inputString, temp;
            Console.Write("Input String: ");
            inputString = Console.ReadLine();
            string[] arrInput = inputString.Trim().Split(' ');
            Console.WriteLine("The number of words in string is: " + arrInput.Length);
        }
    }
}
