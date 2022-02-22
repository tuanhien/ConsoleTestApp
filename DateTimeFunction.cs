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

        //Write a program in C# Sharp to find the last day of a month against a given date
        public static void Exercise55()
        {
            int dd, mm, yy;
            Console.Write("Input day:\n");
            dd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input month:\n");
            mm = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input year:\n");
            yy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The format date is: {dd}/{mm}/{yy}");
            DateTime dt = new DateTime(yy, mm, dd);
            dt = dt.AddMonths(1).AddDays(-dd);
            Console.Write(dt.ToString("yyyy/MM/dd"));
        }

        //Write a program in C# Sharp to find the first day of a week against a given date
        public static void Exercise54()
        {
            int dd = 20;
            int mm = 02;
            int yy = 2022;
            //int dd, mm, yy;
            //Console.Write("Input day:\n");
            //dd = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input month:\n");
            //mm = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input year:\n");
            //yy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The format date is: {dd}/{mm}/{yy}");
            DayOfWeek day = new DateTime(yy, mm, dd).DayOfWeek;
            DateTime datetime = new DateTime(yy, mm, dd);
            while (day.ToString() != "Monday")
            {
                datetime = datetime.AddDays(-1);
                day = datetime.DayOfWeek;
            }
            Console.Write(datetime.ToString("yyyy/MM/dd"));
        }
    }
}
