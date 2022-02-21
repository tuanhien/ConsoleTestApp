using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApp.ConstructCode
{
    //Write a program in C# Sharp to demonstrates structure
    //initialization using both default and parameterized constructors
    class Exercise7
    {
        private int i;
        private string a;
        
        public Exercise7()
        {
            i = 0;
            a = "unknown";
        }

        public Exercise7(int i, string a)
        {
            this.i = i;
            this.a = a;
        }
    }
}
