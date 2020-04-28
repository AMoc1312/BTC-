using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dddd
{
    class songuyen
    {
        int sophantu;
        int[] a = new int[100];
        public void nhap()
        {
            Console.WriteLine(" nhap vao so phan tu cua mang : ");
            sophantu = Convert.ToInt32(Console.ReadLine());
            for ( int i=0; i<sophantu; i++)
            {
                Console.WriteLine(" hay nhap vao phan tu thu : " + i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void xapxep()
        {   
            int tg;
            for( int i=1; i<sophantu; i++)
            {
                for( int j=0; j<i; j++)
                { 
                    if(a[j] >a[i])
                    {
                        tg = a[i];
                        a[i] = a[j];
                        a[j] = tg;

                    }
                }
            }
        }

        public void xuat()
        {
            Console.WriteLine(" phan tu cua mang la: ");
            for (int i = 0; i < sophantu; i++)
            {
                Console.WriteLine(a[i] + ";");
            }
        }
    }
}
