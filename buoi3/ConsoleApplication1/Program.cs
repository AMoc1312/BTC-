using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hcn1 = new HinhChuNhat();
            hcn1.nhap();
            hcn1.dientich();
            Console.WriteLine(" dien tich hinh chu nhat la: " + hcn1.dientich());
            Console.ReadLine();
            Console.ReadLine();

            Class1 hcn2 = new Class1(float.Parse("3.5"), 4);
            Console.WriteLine("dien tich hinh chu nhat 2 la: " + hcn2.dientich());
            Console.ReadLine();

        }
    }
}
