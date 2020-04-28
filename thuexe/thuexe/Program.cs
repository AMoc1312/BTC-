using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace thuexe
{
    class Program
    {
        static void Main(string[] args)
        {
            ThongTinThue A = new ThongTinThue();
            A.nhap();
            A.xuat();



            ThongTinThue[] danhsach = new ThongTinThue[3];

            for (int i = 0; i < 3; i++)
            {
                danhsach[i] = new ThongTinThue();
                danhsach[i].nhap();
            }
            for (int i = 0; i < 3; i++)
            {
                danhsach[i].xuat();
            }

            Console.Read();

        }
    }
}
