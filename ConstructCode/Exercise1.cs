using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleTestApp
{
    class Exercise1
    {
        private static int k_Count = 0;
        private int id;
        private string name;
        private DateTime bDay;

        private int MyId { get { return id; } set { id = value; } }
        //public override int MyId { get { return id; } }
        public string MyName
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }

        public DateTime MyBDay { get { return bDay; } set { bDay = value; } }

        public Exercise1()
        {
            k_Count++;
            MyId = k_Count;
            MyName = "unknown name";
            MyBDay = Convert.ToDateTime("01/01/2000");
        }
        public Exercise1(string name, DateTime bDay)
        {
            k_Count++;
            MyId = k_Count;
            MyName = name;
            MyBDay = bDay;
        }

        public void toString()
        {
            Console.Write($"Id: {MyId}, Name: {MyName}, BirthDay: {MyBDay}\n");
        }
    }
}
