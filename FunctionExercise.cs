using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApp
{
    public class FunctionExercise
    {
        //Write a program in C# Sharp to create a recursive function to find the factorial of a given number
        public static int Exercise11(int inputNumber)
        {
            if(inputNumber == 0)
            {
                return 1;
            }
            else
            {
                return inputNumber * Exercise11(inputNumber - 1);
            }
        }

    }
}
