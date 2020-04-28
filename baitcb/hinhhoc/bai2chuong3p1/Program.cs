using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai2chuong3p1
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hc1 = new HinhChuNhat();
            hc1.nhap();

            Console.Write(" Chu vi cua hcn la : " + hc1.chuVi());
            Console.Write(" Dien tich cua hcn la :" + hc1.dienTich());
   
            Console.ReadLine();

        }
    }
}
