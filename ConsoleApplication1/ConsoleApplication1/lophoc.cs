using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class lophoc
    {
        string malop;
        int kihoc;
        string tenmon;
        string mamon;
        public void nhap()
        {
            Console.Write(" nhap vao ma lop: ");
            malop = Console.ReadLine();
            Console.Write(" hay nhap vao ki hoc: ");
            kihoc = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap vao ten mon: ");
            tenmon = Console.ReadLine();
            Console.Write(" nhap vao ma mon :");
            mamon = Console.ReadLine();
        }



    }
}
