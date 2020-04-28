using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tamgiac
{
    class Tu_dien : tamgiac
    {
        private int chieucao;
        public void nhap()
        {
            Console.Write(" Hay  nhap vao canh 1 cua tu dien");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Hay  nhap vao canh 2 cua tu dien");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Hay  nhap vao canh 3 cua tu dien");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Hay  nhap vao chieu cao cua tu dien");
            chieucao = Convert.ToInt32(Console.ReadLine());
        }
        public double thetich()
        {
            return (chieucao * dientich()) / 3;
        }

    }
}
