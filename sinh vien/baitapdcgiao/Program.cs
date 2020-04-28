using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baitapdcgiao
{
    class Program
    {
        static void Main(string[] args)
        {
            nhaptt sv1 = new nhaptt();
            sv1.nhap();
            sv1.nhapdiem();
            sv1.xuat();
            sv1.tongdiem();
            Console.ReadLine();

        }
    }
}
