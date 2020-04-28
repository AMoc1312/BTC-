using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tamgiac
{
    class tamgiac
    {
        protected int a;
        protected int b;
        protected int c;
        // khoi tao 3 tham so
        public tamgiac(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        //khoi tao khong tham so
        public tamgiac()
        {
            a = b = c = 0;
        }
        public void hien()
        {
            Console.WriteLine(" ba canh cua tam giac la {0}, {1}, {2}", a, b, c);

        }
        public double dientich()
        {
            double  dt;
            int p = (a + b + c) / 2;
            dt = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            return dt;
        }

    }
}
