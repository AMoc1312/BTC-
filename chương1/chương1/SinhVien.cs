using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chương1
{
    class SinhVien
    {
        string masv;
        string tensv;
        DateTime ngaysinh;
         public void nhap()
        {
            Console.Write(" hay nhap ten sinh vien ");
            tensv = Console.ReadLine();
            Console.Write(" hay nhap ma sinh vien ");
            masv = Console.ReadLine();
            Console.Write(" hay nhap ngay sinh sinh vien ");
            ngaysinh = Convert.ToDateTime(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("Thong tin sinh vien : " + masv + " ten sinh vien " + tensv + " ngay sinh " + ngaysinh);
        }
    }
}
