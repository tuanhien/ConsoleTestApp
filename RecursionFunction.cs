using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApp
{
    public class RecursionFunction
    {
        //Write a program in C# Sharp to print the first n natural number using recursion
        public static int Exercise1(int n, int count)
        {
            if(n <= 0)
            {
                return count;
            }
            n--;
            Console.Write(count + " ");
            count++;
            Exercise1(n, count);
            return n;
        }

        //Write a program in C# Sharp to print numbers from n to 1 using recursion
        public static int Exercise2(int n)
        {
            if(n <= 1)
            {
                Console.Write(n);
                return n;
            }
            Console.Write(n + " ");
            n--;
            Exercise2(n);
            return n;
        }

        //Write a program in C# Sharp to find the sum of first n natural numbers using recursion
        public static int Exercise3(int n, int temp)
        {
            if(n <= 1)
            {
                Console.Write($"Sum from one to n is: " + temp);
                return n;
            }

            temp = temp + n;
            n--;
            Exercise3(n, temp);
            return n;
        }

        //Write a program in C# Sharp to display the individual digits of a given number using recursion.
        public static int Exercise4(int input)
        {
            if(input < 10)
            {
                Console.Write(input + " ");
                return input;
            }
            Exercise4(input / 10);
            Console.Write(input % 10 + " ");
            return input;
        }

        //Write a program in C# Sharp to count the number of digits in a number using recursion
        public static int Exercise5(int a, int count)
        {
            if(a < 10)
            {
                count++;
                Console.Write("The number of digit is: ");
                Console.Write(count);
                return a;
            }
            count++;
            a = a / 10;
            Exercise5(a, count);
            return a;
        }

        //Write a program in C to print even or odd numbers in a given range using recursion
        public static int Exercise6(int a) 
        {
            if(a <= 1)
            {
                Console.Write(a);
            }


        }
    }
}
