using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinhVien
{
    class MangSV
    {
        private int SoLuong;
        private Sinhvien[] Danhsach;

        public void nhap()
        {
            Console.WriteLine("hay nhap so luong sinh vien: ");
            SoLuong = Convert.ToInt32(Console.ReadLine());
            Danhsach = new Sinhvien[SoLuong];

            for (int i = 0; i < SoLuong; i++)
            {
                Danhsach[i] = new Sinhvien();
                Danhsach[i].nhap();
            }
        }

        public int SoluongSinhVienChuyenDe()
        {
            int dem = 0;

            for (int i = 0; i < SoLuong; i++)
            {
                if (Danhsach[i].KieuTotNghiep() == 2)
                    dem = dem + 1;
            }
            return dem;

        }
        public int SoLuongSinhVienKhoaLuan()
        {
            int dem = 0;
            for (int i = 0; i < SoLuong; i++)
            {
                if (Danhsach[i].KieuTotNghiep() == 1)
                    dem = dem + 1;
            }
            return dem;
        }

    }
}
