using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nguoi
{
    class Program
    {
        static void Main(string[] args)
        {

            nhanVien[] DanhSach = new nhanVien[10];
            for( int i=0; i<10; i++)
            {
                DanhSach[i] = new nhanVien();
                DanhSach[i].nhap();
            }
            for (int i = 0; i < 10; i++)
            {
                DanhSach[i].xuat();
            }

            Console.Read();

        }
    }
}
