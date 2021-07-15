using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApp
{
    public class ArrayFunction
    {
        //Write a program in C# Sharp to store elements in an array and print it.
        public static void Exercise1()
        {
            Console.WriteLine("Input 10 elements in the array:");
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Element - {i}: ");
                string a = Console.ReadLine();
                arrayList.Add(a);
            }
            Console.Write("Elements in array are: ");
            foreach (var r in arrayList)
            {
                Console.Write(r + " ");
            }
        }

        //Write a program in C# Sharp to print all unique elements in an array
        public static void Exercise6()
        {
            int temp;
            Console.Write("Input the number of elements to be stored in the array: ");
            temp = Convert.ToInt32(Console.ReadLine());
            List<int> arrInput = new List<int>();
            Console.WriteLine($"Input {temp} elements in the array: ");
            for (int i = 0; i < temp; i++)
            {
                Console.Write("element - {0}: ", i);
                arrInput.Add(Convert.ToInt32(Console.ReadLine()));
            }

            while(arrInput.Count > 2)
            {
                for( int i = 0; i < arrInput.Count - 1; i++)
                {
                    for(int j = i+1; j < arrInput.Count; j++)
                    {
                        if(arrInput[i] == arrInput[j])
                        {
                            arrInput.RemoveAt(i);
                            arrInput.RemoveAt(j-1);
                        }
                    }
                }
            }
            Console.WriteLine("The unique elements found in the array are: ");
            foreach(var r in arrInput)
            {
                Console.Write(r + " ");
            }
        }

        //Write a program in C# Sharp to count the frequency of each element of an array
        public static void Exercise8()
        {
            int temp;
            Console.Write("Input the number of elements to be stored in the array: ");
            temp = Convert.ToInt32(Console.ReadLine());
            List<int> arrInput = new List<int>();
            Console.WriteLine($"Input {temp} elements in the array: ");
            for (int i = 0; i < temp; i++)
            {
                Console.Write("element - {0}: ", i);
                arrInput.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Hashtable htTemp = new Hashtable();

            for (int i = 0; i < arrInput.Count; i++)  
            {
                int t = 1;
                if (htTemp.Count > 0 && htTemp.ContainsKey(arrInput[i]))
                {
                    t = Convert.ToInt32(htTemp[arrInput[i]]);
                    t++;
                    htTemp[arrInput[i]] = t;
                }
                else
                {
                    htTemp.Add(arrInput[i], t);
                }
            }

            Console.Write("Frequency of all elements of array: \n");
            foreach(DictionaryEntry r in htTemp)
            {
                Console.Write($"{r.Key} occurs {r.Value} times\n");
            }
        }

        //Write a program in C# Sharp to find maximum and minimum element in an array
        public static void Exercise9()
        {
            int temp, maxValue, minValue;
            Console.Write("Input the number of elements to be stored in the array: ");
            temp = Convert.ToInt32(Console.ReadLine());
            List<int> arrInput = new List<int>();
            Console.WriteLine($"Input {temp} elements in the array: ");
            for (int i = 0; i < temp; i++)
            {
                Console.Write("element - {0}: ", i);
                arrInput.Add(Convert.ToInt32(Console.ReadLine()));
            }

            maxValue = arrInput[0];
            minValue = arrInput[0];
            for(int i = 0; i < arrInput.Count; i++)
            {
                if(maxValue < arrInput[i])
                {
                    maxValue = arrInput[i];
                }
                if(minValue > arrInput[i])
                {
                    minValue = arrInput[i];
                }
            }

            Console.Write("Maximum element is: {0}\n", maxValue);
            Console.Write("Minimum element is: {0}\n\n", minValue);
        }

        //Write a program in C# Sharp to insert New value in the array (sorted list )
        public static void Exercise13()
        {
            int temp;
            Console.Write("Input the number of elements to be stored in the array: ");
            temp = Convert.ToInt32(Console.ReadLine());
            List<int> arrInput = new List<int>();
            Console.WriteLine($"Input {temp} elements in the array: ");
            for (int i = 0; i < temp; i++)
            {
                Console.Write("element - {0}: ", i);
                arrInput.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("The exist array list is: ");
            foreach(var r in arrInput)
            {
                Console.Write(r + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Input the value to be inserted: ");
            temp = Convert.ToInt32(Console.ReadLine());
            arrInput.Add(temp);

            for(int i = 0; i < arrInput.Count - 1; i++)
            {
                for(int j = i + 1; j < arrInput.Count; j++)
                {
                    if (arrInput[i] > arrInput[j])
                    {
                        int t = arrInput[i];
                        arrInput[i] = arrInput[j];
                        arrInput[j] = t;
                    }
                }
            }

            Console.WriteLine("After Insert the list is : ");
            foreach (var r in arrInput)
            {
                Console.Write(r + " ");
            }
        }

        //Write a program in C# Sharp to insert New value in the array (unsorted list )
        public static void Exercise14()
        {
            int temp, temp2;
            Console.Write("Input the number of elements to be stored in the array: ");
            temp = Convert.ToInt32(Console.ReadLine());
            List<int> arrInput = new List<int>();
            Console.WriteLine($"Input {temp} elements in the array: ");
            for (int i = 0; i < temp; i++)
            {
                Console.Write("element - {0}: ", i);
                arrInput.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Input the value to be inserted: ");
            temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Position, where the value to be inserted: ");
            temp2 = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 0; i < arrInput.Count; i++)
            {
                if(temp2 == i)
                {
                    arrInput.Insert(temp2, temp);
                }
            }
            Console.WriteLine("After Insert the element the new list is: ");
            foreach (var r in arrInput)
            {
                Console.Write(r + " ");
            }
        }

        //Write a program in C# Sharp to find the second largest element in an array
        public static void Exercise16()
        {
            int temp;
            Console.Write("Input the number of elements to be stored in the array: ");
            temp = Convert.ToInt32(Console.ReadLine());
            List<int> arrInput = new List<int>();
            Console.WriteLine($"Input {temp} elements in the array: ");
            for (int i = 0; i < temp; i++)
            {
                Console.Write("element - {0}: ", i);
                arrInput.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for(int i = 0; i < arrInput.Count-1; i++)
            {
                for(int j = i + 1; j < arrInput.Count; j++)
                {
                    if (arrInput[i] > arrInput[j])
                    {
                        int t = arrInput[i];
                        arrInput[i] = arrInput[j];
                        arrInput[j] = t;
                    }
                }
            }

            Console.Write("The Second largest element in the array is: {0}", arrInput[arrInput.Count - 2]);
        }

        //Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix
        public static void Exercise18()
        {
            int x, y;
            Console.Write("Input number of rows: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number of columns: ");
            y = Convert.ToInt32(Console.ReadLine());
            int[,] arrInput = new int[x,y];
            Console.WriteLine("Input elements in the matrix: ");

            for(int i = 0; i < x; i++)
                for(int j = 0; j < y; j++)
                {
                    Console.Write($"element - [{i},{j}]: ");
                    arrInput[i, j] = int.Parse(Console.ReadLine());
                }
            Console.WriteLine("The matrix is: ");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(arrInput.GetValue(i, j));
                }
                Console.WriteLine();
            }   
        }

        //Write a program in C# Sharp for addition of two Matrices of same size
        public static void Exercise19()
        {
            int x, y;
            Console.Write("Input number of rows: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number of columns: ");
            y = Convert.ToInt32(Console.ReadLine());
            int[,] arrInput1 = new int[x, y];
            int[,] arrInput2 = new int[x, y];
            int[,] arrResult = new int[x, y];
            Console.WriteLine("Input elements in the first matrix: ");

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"element - [{i},{j}]: ");
                    arrInput1[i, j] = int.Parse(Console.ReadLine());
                }

            Console.WriteLine("Input elements in the second matrix: ");

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"element - [{i},{j}]: ");
                    arrInput2[i, j] = int.Parse(Console.ReadLine());
                }

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                {
                    arrResult[i, j] = arrInput1[i, j] + arrInput2[i, j];
                }

            Console.WriteLine("The Addition of two matrix is: ");
            for (int i = 0; i < x; i++) 
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(arrResult[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //Write a program in C# Sharp to find sum of right diagonals of a matrix
        public static void Exercise23()
        {
            int x, y;
            Console.Write("Input the size of the square matrix: ");
            x = Convert.ToInt32(Console.ReadLine());
            int[,] arrInput = new int[x, x];

            for (int i = 0; i < x; i++)
                for (int j = 0; j < x; j++)
                {
                    Console.Write($"element - [{i},{j}]: ");
                    arrInput[i, j] = int.Parse(Console.ReadLine());
                }

            int SumOfarrInput = 0;
            int temp = x - 1;
            for (int i = 0; i < x; i++)
            {
                for(int j = temp; j > -1; j--)
                {
                    SumOfarrInput += arrInput[i, temp];
                    temp--;
                    break;
                }
            }

            Console.Write("Addition of the right Diagonal elements is: {0}", SumOfarrInput);
        }

            //Write a C# Sharp program to re-arrange the elements in a given array of numbers
            //and check the numbers are consecutive or not
            public static void Exercise36(ArrayList arrInput)
        {
            foreach(var r in arrInput)
            {
                //if (!int.TryParse(r, out int result))
                //{

                //}
            }
        }
    }
}
