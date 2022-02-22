using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleTestApp
{
    class NhanVien
    {
        [Key]
        private int id = 1;
        private string name = "unknown";
        private DateTime bDay = DateTime.Today;

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

        public int MyId { get; private set; }
        public DateTime MyBDay { get; set; } = DateTime.Now;

        public string thongTinNhanVien()
        {
            return $"Id: {MyId}, Name: {MyName}, BirthDay: {MyBDay}";
        }
    }
}
