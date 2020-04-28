using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
         MangSV lopHTTA = new MangSV();
            lopHTTA.nhap();
            Console.WriteLine("So luong sinh vien dc lam khoa luan la: " + lopHTTA.SoLuongSinhVienKhoaLuan());
            Console.WriteLine("So luong sinh vien dc lam chuyen de la: " +  lopHTTA.SoluongSinhVienChuyenDe());
            Console.Read();
            Console.Read();

        }
    }
}
