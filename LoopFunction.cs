using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApp
{
    public class LoopFunction
    {
        //Write a program in C# Sharp to display the first 10 natural numbers
        //Expected Output :
        //1 2 3 4 5 6 7 8 9 10
        public static void Display10FirstNumber()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
        }

        //Write a C# Sharp program to find the sum of first 10 natural numbers.
        public static void SumOf10FirstNumber()
        {
            int i,tong;
            tong = 0;
            Console.Write("The first 10 natural number is :\n");
            for (i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
                tong += i;
            }
            Console.WriteLine();
            Console.Write("The Sum is: {0}",tong);
        }

        //Write a program in C# Sharp to display n terms of natural number and their sum
        public static void SumOfNNumber()
        {
            int a, tong = 0;
            string temp;
            Start:
            Console.WriteLine("Input n:");
            temp = Console.ReadLine();
            if(!int.TryParse(temp, out a))
            {
                Console.WriteLine("Wrong input, please try again");
                goto Start;
            }
            a = Convert.ToInt32(temp);
            Console.WriteLine($"The first {a} natural number is :");
            for (int i = 1; i <= a; i++)
            {
                tong += i;
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"The Sum of Natural Number upto {a} terms: {tong}");
        }

        //Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk
        public static void DisplayAsterisk()
        {
            int x, y, j;
            int temp = 0;
            Console.WriteLine("Input horizontal row number: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input vertical column number: ");
            x = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < y; i++)
            {
                for (j = temp; j < x; j++)
                {
                    Console.Write("*");
                }
                temp++;
                Console.WriteLine();
            }
        }
    }
}
