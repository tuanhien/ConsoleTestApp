using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApp
{
    public class IfFunction
    {
        public static void Caculator()
        {
            double a, b = 0;
            string operation = null;
            Console.WriteLine("Input first number: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input operation: ");
            operation = Console.ReadLine();
            Console.WriteLine("Input second number: ");
            b = Convert.ToDouble(Console.ReadLine());
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{a} {operation} {b} = {a + b}");
                    break;
                case "-":
                    Console.WriteLine($"{a} {operation} {b} = {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"{a} {operation} {b} = {a * b}");
                    break;
                case "/":
                    Console.WriteLine($"{a} {operation} {b} = {a / b}");
                    break;
                default:
                    Console.WriteLine($"System is not recognize the '{operation}' " +
                                    $"or the '{a}' or the '{b}' is not number, please check again");
                    break;
            }
        }

        public static double LargestNumber(List<double> list)
        {
            double value = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    value = list[i];
                    list[i] = list[i + 1];
                    list[i + 1] = value;
                }
                else if (list[i] < list[i + 1])
                {
                    value = list[i + 1];
                }
                else
                {
                    value = list[i];
                }
            }
            Console.WriteLine(value);
            return value;
        }

        //Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation
        public static void SimpleCaculate()
        {
            string temp;
            float a, b;
            int oper;
            string value1 = "Addition", value2 = "Substraction", value3 = "Multiplication", value4 = "Division", value5 = "Exit";
            try
            {
            //Check input A
            StartA:
                Console.WriteLine("Input number");
                temp = Console.ReadLine();
                if (!float.TryParse(temp, out a))
                {
                    Console.WriteLine("Wrong input, do you want to try again or not? (y/n)");
                    temp = Console.ReadLine();
                AskA:
                    if (temp == "y")
                    {
                        goto StartA;
                    }
                    else if (temp == "n")
                    {
                        goto End;
                    }
                    else
                    {
                        Console.WriteLine("Wrong, please check again (y/n)");
                        temp = Console.ReadLine();
                        goto AskA;
                    }
                }
                a = float.Parse(temp);

            //Check input B
            StartB:
                Console.WriteLine("Input number 2:");
                temp = Console.ReadLine();
                if (!float.TryParse(temp, out b))
                {
                    Console.WriteLine("Wrong input, do you want to try again or not? (y/n)");
                    temp = Console.ReadLine();
                AskB:
                    if (temp == "y")
                    {
                        goto StartB;
                    }
                    else if (temp == "n")
                    {
                        goto End;
                    }
                    else
                    {
                        Console.WriteLine("Wrong, please check again (y/n)");
                        temp = Console.ReadLine();
                        goto AskB;
                    }
                }

                //Check input C
                Console.WriteLine("Here are the options:");
                List<string> arrListMenu = new List<string>() { $"1-{value1}.", $"2-{value2}.", $"3-{value3}.", $"4-{value4}.", $"5-{value5}." };
                foreach (var r in arrListMenu)
                {
                    Console.WriteLine(r);
                }

            StartC:
                Console.WriteLine("Input your choice: ");
                temp = Console.ReadLine();
                //Check input in range (1:5)
                if (!int.TryParse(temp, out oper))
                {
                    if (Convert.ToInt32(Console.ReadLine()) < 1 && Convert.ToInt32(Console.ReadLine()) > 5) { }
                    else
                    {
                        Console.WriteLine("Wrong input, do you want to try again or not? (y/n)");
                        temp = Console.ReadLine();
                    AskC:
                        if (temp == "y")
                        {
                            goto StartC;
                        }
                        else if (temp == "n")
                        {
                            goto End;
                        }
                        else
                        {
                            Console.WriteLine("Wrong, please check again (y/n)");
                            temp = Console.ReadLine();
                            goto AskC;
                        }
                    }
                }

                switch (oper)
                {
                    case 1:
                        Console.WriteLine($"The {value1} of {a} and {b} is: {a + b}");
                        break;
                    case 2:
                        Console.WriteLine($"The {value2} of {a} and {b} is: {a - b}");
                        break;
                    case 3:
                        Console.WriteLine($"The {value3} of {a} and {b} is: {a * b}");
                        break;
                    case 4:
                        Console.WriteLine($"The {value4} of {a} and {b} is: {a / b}");
                        break;
                    default:
                        goto End;
                }

                Console.WriteLine("Do you have any math for me? (y/n)");
                temp = Console.ReadLine();
            Temp:
                if (temp == "y")
                {
                    goto StartA;
                }
                else if (temp == "n")
                {
                    goto End;
                }
                else
                {
                    Console.WriteLine("Wrong input, please check again");
                    temp = Console.ReadLine();
                    goto Temp;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something's wrong. Please check the message:");
                Console.WriteLine(e.Message);
            }
        End:;
        }
    }
}
