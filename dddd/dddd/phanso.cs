using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dddd
{
    class phanso
    {
        int a, b, c, d;
        public void nhap()
        {
            Console.WriteLine(" hay nhap vao tu so so 1: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" hay nhap vao mau so so 1: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" hay nhap vao tu so so 2: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" hay nhap vao mau so so 2: ");
            d = Convert.ToInt32(Console.ReadLine());

        }
        public void ttong()
        {
            if (b != 0 && d != 0)
            {
                float pso2 = (float) c / d;
                float pso1 = (float)a / b;
                Console.WriteLine(" tong 2 phan so la: " + (pso1 + pso2));
                Console.WriteLine(" hieu 2 phan so la: "+(pso1 - pso2));
                Console.WriteLine(" tich 2 phan so la:" + (pso1 * pso2));
                Console.WriteLine(" thuong 2 phan so la: " + (pso1 / pso2));
            }
        }
        public void xuat()
        {
            Console.WriteLine(" phan so thuw 1 laf : " + a + "\\" + b);
            Console.WriteLine(" phan so thu 2 la: " + c + "\\" + d);
        }

    }
}
