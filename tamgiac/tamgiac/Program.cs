using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tamgiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Tu_dien td1 = new Tu_dien();
            td1.nhap();
            Console.WriteLine(" dien tich cua tu dien la: " + td1.dientich());
            Console.WriteLine(" the tich cua tu dien la: " + td1.thetich());
            Console.ReadLine();
        }
    }
}
