using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baitapdcgiao
{
    class danhSachSinhVien
    {
        private int sosv;
        private nhaptt[] DanhSach = new nhaptt[50];

        public void nhap()
        {
            Console.Write(" hay nhap vao danh sch sv: ");
            sosv = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sosv; i++)
            {
                DanhSach[i] = new nhaptt();
                DanhSach[i].nhap();
            }
        }
        public void hienthi()
        {
            for (int i = 0; i < sosv; i++)
            {
                DanhSach[i].xuat();
            }
        }


    }
}
