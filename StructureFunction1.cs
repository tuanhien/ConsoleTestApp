using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApp
{
    class StructureFunction1
    {
        //Write a program in C# Sharp to create a nested
        //structure to store two data for an employee in an array
        private string name = "Unknown Name";
        private int day, month, year;

        public string MyName 
        { 
            get { return name; } 
            set { if (!string.IsNullOrEmpty(value)) { name = value; } } 
        }
        public string toString()
        {
            return "Name: " + name + "\nDay: " + day + "\nMonth: " + month + "\nYear: " + year;
        }
    }
}

