using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dddd
{
    class Program
    {
        static void Main(string[] args)
        {
            songuyen m = new songuyen();
            m.nhap();
            m.xapxep();
            m.xuat();
            Console.ReadLine();
            phanso g = new phanso();
            phanso h = new phanso();
            g.nhap();
            g.xuat();
            g.ttong();
            Console.ReadLine();
        }
    }
}
