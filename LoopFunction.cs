using System;
using System.Collections;
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

        //Write a program in C# Sharp to make such a pattern like right
        //angle triangle with a number which will repeat a number in a row 
        /*
         * 1
         * 22
         * 333
         * 4444
        */
        public static void SimpleLoop1()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        //Write a program in C# Sharp to make such a pattern like right
        //angle triangle with a number which will repeat a number in a row 
        /*
         1
         2 3
         4 5 6
         7 8 9 10 
        */
        public static void SimpleLoop2()
        {
            int a = 1;
            for (int i = 1; i < 5; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(a + " ");
                    a++;
                }
                Console.WriteLine();
            }
        }
        //Loop like this
        /*
           1 
          2 3 
         4 5 6 
        7 8 9 10
         */
        public static void SimpleLoop3()
        {
            int a = 1;
            for(int i = 0; i < 5; i++)
            {
                for (int spc = i; spc < 4; spc++)
                    Console.Write(" ");
                for (int j = i; j > 0; j--)
                {
                    Console.Write(a + " ");
                    a++;
                }
                Console.WriteLine();
            }
        }

        //Write a C# Sharp program to calculate the factorial of a given number
        public static void SimpleFactorial()
        {
            int result = 1;
            Console.WriteLine("Input a number:");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                result = result*i;
            }
            Console.WriteLine(result);
        }

        // Write a program in C# Sharp to display the n terms of even natural number and their sum
        public static void SimpleSumEvenNumber()
        {
            ArrayList arrNumber = new ArrayList();
            Console.WriteLine("Input number of even number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i > 0; i++)
            {
                if (i % 2 == 0)
                {
                    arrNumber.Add(i);
                }
                if(arrNumber.Count == a)
                {
                    break;
                }
            }
            Console.Write("The even numbers are: ");
            int temp = 0;
            foreach (var r in arrNumber)
            {
                Console.Write("{0} ", r);
                temp = temp + Convert.ToInt32(r);
            }
            Console.WriteLine();
            Console.Write("The Sum of even Natural Number upto {0} terms: {1}", a, temp);
        }

        //Write a program in C# Sharp to print a string in reverse order
        //Input a string to reverse : Welcome
        //Expect output: emocleW
        public static void ReverseString()
        {
            ArrayList arrTemp = new ArrayList();
            Console.Write("Input string: ");
            string a = Console.ReadLine();
            for (int i = a.Length; i > 0; i--)
            {
                arrTemp.Add(a[i-1]);
            }
            foreach(var r in arrTemp)
            {
                Console.Write(r);
            }
        }

        //Write a C# Sharp program to display alphabet pattern like 'Z' with an asterisk.
        public static void ZAsterisk()
        {
            int row, column;
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (((row == 0 || row == 6) && column >= 0 && column <= 6) || row + column == 6)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}