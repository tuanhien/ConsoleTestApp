using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApp
{
    public class LoginFunction
    {
        //Write a C# Sharp program that takes userid and password as input (type string).
        //After 3 wrong attempts, user will be rejected
        public static void LoginUser()
        {
            string check = null;
            int count = 0;
        Start:
            Console.WriteLine("Input account: ");
            var a = Console.ReadLine().Trim();
            Console.WriteLine("Input password: ");
            var b = Console.ReadLine().Trim();

            if (a == "admin" && b == "password")
            {
                Console.WriteLine("Success");
            }
            else
            {
                count++;
                if (count >= 3)
                {
                    Console.WriteLine($"Your fault count: {count}");
                    Console.WriteLine("You were blocked");
                }
                else
                {
                    Console.WriteLine($"Your fault count: {count}");
                    Console.WriteLine("You input wrong account or password\nDo you want to try again? (y/n)");
                inputYN:
                    check = Console.ReadLine();
                    if (check == "y")
                    {
                        goto Start;
                    }
                    else if (check == "n")
                    {
                        Console.WriteLine("System is willing out");
                    }
                    else
                    {
                        Console.WriteLine("Wrong input, please check carefully (y/n)");
                        goto inputYN;
                    }
                }
            }
        }
    }
}
