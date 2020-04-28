using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chương1
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien hoaianh = new SinhVien();
            hoaianh.nhap();
            hoaianh.xuat();
            Console.ReadLine();
        }
    }
}
