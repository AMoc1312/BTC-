using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinhTienDien
{
    class TienDienMoi : TienDien
    {
        private int DinhMuc;

        public TienDienMoi(string TenChuHo, string DiaChi, int SoDienThangTruoc, int SoDienThangNay)
            : base(TenChuHo, DiaChi, SoDienThangTruoc, SoDienThangNay)
        {

            Console.WriteLine("Hay nhập thêm định mực");
            DinhMuc = Convert.ToInt32(Console.ReadLine());

        }

        public override void nhap()
        {
            base.nhap();
            Console.Write("Hay nhập định mức: ");
            DinhMuc = Convert.ToInt32(Console.ReadLine());
        }

        public override void hienThi()
        {
            Console.WriteLine("Day la phuong thuc hien thi cua lop con:");

            Console.WriteLine("Chủ hộ " + TenChuHo + " Địa Chỉ: " + DiaChi + "\n"
                + "Số công tơ tháng trước " + SoCongToThangTruoc
                + " Số công tơ tháng này " + SoCongToThangNay
                + "Dinh muc là: " + DinhMuc);
        }

        public int tinhTienDien()
        {
            SoCongToDaDung = SoCongToThangNay - SoCongToThangTruoc;
            if (SoCongToDaDung <= DinhMuc)
            {
                return SoCongToDaDung * 500;
            }
            else
            {
                return (DinhMuc * 500 + (SoCongToDaDung - DinhMuc) * 600);
            }
        }


    }
}
