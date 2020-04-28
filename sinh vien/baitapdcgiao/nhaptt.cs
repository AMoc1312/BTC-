using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baitapdcgiao
{
    class nhaptt
    {
        private string msv;
        private string hoten;
        private double Dcc;
        private double  ktr1;
        private double  ktr2;
        private double  thi;
        static string tentrg;
        public void nhap()
        {
            Console.Write(" nhap vao ma sinh vien: ");
            msv = Console.ReadLine();
            Console.Write(" nhap vao ho ten : ");
            hoten = Console.ReadLine();
        }
       
      
        public void nhapdiem()
        {
            Console.Write(" nhap vao diem cc: ");
            Dcc = Convert.ToDouble(Console.ReadLine());
            Console.Write(" nhap vao diem ktra1: ");
            ktr1 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" nhap vao diem ktra2: ");
            ktr2 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" nhap vao diem thi: ");
            thi = Convert.ToDouble(Console.ReadLine());

        }
        public double tongdiem()
        {
            double td = 0;
            td = Dcc * 0.1 + ktr1 * 0.15 + ktr2 * 0.15 + thi * 0.6;
            if(td >= 4)   
            {
                    Console.WriteLine(" Ban da qua mon ");
            }
            else 
            {
                    Console.WriteLine(" ban phai hoc lai mon nay ");
            }   
            return td;
        }

        public void xuat()
        {
            Console.WriteLine(" thong tin sinh vien là: msv: " + msv + " hoten: " + hoten + " ddiem cc " + Dcc + " diemktra1 " + ktr1 + "diem ktra 2 " + ktr2 + " diem thi" + thi);
            
        }
    }
}
