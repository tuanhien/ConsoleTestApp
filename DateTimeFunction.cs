using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApp
{
    class DateTimeFunction
    {
        //Write a program in C# Sharp to find the day for a particular date.
        public static void Exercise57()
        {
            string dd, mm, yy;
            Console.Write("Input day:\n");
            dd = Console.ReadLine();
            Console.Write("Input month:\n");
            mm = Console.ReadLine();
            Console.Write("Input year:\n");
            yy = Console.ReadLine();

            Console.WriteLine($"The format date is: {dd}/{mm}/{yy}");
            DayOfWeek dTemp = new DateTime(Convert.ToInt32(yy), Convert.ToInt32(mm), Convert.ToInt32(dd)).DayOfWeek;
            Console.Write(dTemp);
        }
    }
}
