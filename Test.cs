using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApp
{
    class Test
    {
        private string name;
        private int day;

        public Test()
        {
            name = "";
            day = 1;
        }

        public Test(string _name, int _day)
        {
            name = _name;
            day = _day;
        }

        public string toString()
        {
            return $"Name: ";
        }
    }
}
