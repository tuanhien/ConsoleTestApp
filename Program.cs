using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace ConsoleTestApp
{
    public class Program
    {
        //a program that show how many times a char appear.
        public static void CountCharInput(string a) 
        {
            ArrayList arrTemp = new ArrayList();

            Console.WriteLine($"Chuoi truoc khi dem co {a.Length} ki tu");
            var b = a.Replace(" ", "");
            while(b.Length > 0)
            {
                arrTemp.Add(b[0]);
                for (int j = 1; j < b.Length; j++)
                {
                    if (b[0] == b[j])
                    {
                        arrTemp.Add(b[j]);
                        b.Remove(j,1);
                    }
                }
                b = b.Replace($"{b[0]}", "");
                Console.WriteLine($"Ki tu {arrTemp[0]} co {arrTemp.Count} phan tu");
                arrTemp.Clear();
            }
        }

        //A program that add "if" in the first string if it's not contains if in first element.
        public static void CheckFirstChar(string a)
        {
            string b = null;
            if (a.StartsWith("if"))
            {
                b = a;
            }
            else
            {
                b = "if " + a;
            }
            Console.WriteLine(b);
        }

        //a program that clear value if given list of int end with 7
        public static void RemoveValueEndWithSeven(List<int> vs)
        {
            ArrayList temp = new ArrayList();
            foreach (int a in vs)
            {
                if (Convert.ToString(a).EndsWith("7")) { }
                else
                {
                    temp.Add(a);
                }
            }
            foreach (int r in temp)
            {
                Console.WriteLine(r);
            }
        }

        //Write a C Sharp program to remove all "a" in each string in given list of strings and return the new string
        public static void RemoveACharacter(List<string> vs)
        {
            ArrayList temp = new ArrayList();
            foreach (string r in vs)
            {
                for(int i = 0; i < r.Length; i++)
                {
                    if(Convert.ToString(r[i]) == "a") { }
                    else
                    {
                        temp.Add(r[i]);
                    }
                }
            }
            if (temp == null)
            {
                Console.WriteLine("Nothing were remain");
            }
            else
            {
                Console.Write("New string: ");
                foreach (var t in temp)
                {
                    Console.Write(t);
                }
            }
        }

        //Write a C# Sharp program to create a new list from a given list of integers
        //where each integer multiplied by itself three times
        public static void MultipleThreeTimes(List<int> listInput)
        {
            ArrayList arrNew = new ArrayList();
            foreach(var r in listInput)
            {
                Convert.ToInt32(r);
                arrNew.Add(r * r * r);
            }
            Console.Write("New list is: ");
            foreach (var a in arrNew)
            {
                Console.Write(a + " ");
            }
        }

        //Write a C# Sharp program to check a given array (length will be at least 2) of integers
        //and return true if there are two values 15, 15 next to each other
        public static bool Check15(List<int> vs)
        {
            bool result;
            ArrayList t = new ArrayList();
            for (int i = 0; i < vs.Count - 1; i++)
            {
                if(vs[i] == vs[i+1] && vs[i] == 15)
                {
                    result = true;
                    Console.Write(result);
                    return result;
                }
            }
            result = false;
            Console.Write(result);
            return result;
        }

        //Write a C# Sharp program that takes a number and a width also a number,
        //as input and then displays a triangle of that width, using that number.
        public static void HinhTamGiac(int a)
        {
            for (int i = 0; i <= a; i++)
            {
                for(int j = i + 1; j <= a; j++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
            }
        }

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
                } else if(list[i] < list[i + 1])
                {
                    value = list[i+ 1];
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
                    if(Convert.ToInt32(Console.ReadLine()) < 1 && Convert.ToInt32(Console.ReadLine()) > 5){}
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
                if(temp == "y")
                {
                    goto StartA;
                } else if(temp == "n")
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
            catch(Exception e)
            {
                Console.WriteLine("Something's wrong. Please check the message:");
                Console.WriteLine(e.Message);
            }
        End:;
        }

        public static void Test()
        {
            //double[] a = new double() { null, 121212.2, 23232, 232354 };
        }

        static void Main(string[] args)
        {
            SimpleCaculate();
            //var a = 16;
            //a = Sqr(a);
        }

    }
}
