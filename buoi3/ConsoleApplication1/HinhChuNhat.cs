using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class HinhChuNhat
    {
        float chieuDai;
        float chieuRong;

        public void nhap()
        {
            Console.Write(" hay nhap chieu dai cua hinh chu nhat : ");
            //chieuDai = Convert.ToDouble(Console.ReadLine());
            chieuDai = float.Parse(Console.ReadLine());
            Console.Write(" hay nhap chieu rong cua hinh chu nhat : ");
            chieuRong = float.Parse(Console.ReadLine());
        }
         public float dientich()
        { 
            float dt = 0;
            dt = chieuRong * chieuDai;
            return dt;
        }
    } 
}
