using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Sinhvien
    {
        string msv;
        string tensv;
        DateTime ngaysinh;

         public void nhap()
        {
            Console.Write("hay nhap ten sinh vien: ");
            tensv = Console.ReadLine();
            Console.Write("hay nhap ma sv: ");
            msv = Console.ReadLine();
            Console.Write("hay nhap ngay sinh: ");
            ngaysinh = Convert.ToDateTime(Console.ReadLine());
        }
       public void xuat()
        {
            Console.WriteLine("Thong tin sinh vien la: " + msv + " , " + tensv + " ngay sinh: " + ngaysinh);
        }
    } 
}
