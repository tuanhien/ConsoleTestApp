using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ConsoleTestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int temp, result;
            //Console.Write("Input a number: ");
            //temp = Convert.ToInt32(Console.ReadLine());
            //RecursionFunction.Exercise1(temp,1);
            //RecursionFunction.Exercise15(5,3);
            //Console.Write(RecursionFunction.GiaiThua(5));
            //RecursionFunction.Exercise14("w3resource");
            //LinQFunction.Exercise3();

            //int total = 2;
            //Test[] _test = new Test[total];
            //for (int i = 0; i < total; i++)
            //{
            //    Console.Write("Input Name: \n");
            //    string m_value = Console.ReadLine();
            //    _test[i].MyName = m_value;
            //    Console.Write("Input Day: \n");
            //    _test[i].MyDay = Convert.ToInt32(Console.ReadLine());
            //}

            int total = 2;
            ArrayList arrInput = new ArrayList(total);
            int m = arrInput.Count;
            for (int i = 0; i < total; i++)
            {
                NhanVien tempNhanVien = new NhanVien();
                tempNhanVien.MyName = "nv" + i;
                tempNhanVien.MyBDay = DateTime.Now;
                arrInput[i] = tempNhanVien;
            }

            foreach(NhanVien r in arrInput)
            {
                r.thongTinNhanVien();
            }

            //Console.Write(t.thongTinNhanVien()+ "\n");
            //t.MyName = "test Name";
            //t.MyBDay = DateTime.Today;
            //Console.Write(t.thongTinNhanVien());

            //foreach (var r in _test)
            //{
            //    Console.Write(r.toString());
            //}
        }
    }
}
