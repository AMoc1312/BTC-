using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nguoi
{
    class nhanVien: Nguoii
    {
        private  string Manv;
        private  string ChucVu;
        private  string PhongBan;
        private  double HeSoLuong;

        public override void nhap()
        {
            base.nhap();
            Console.WriteLine(" nhap vao ma nhan vien : ");
            Manv = Console.ReadLine();
            Console.WriteLine(" nhap vao chuc vu : ");
            ChucVu = Console.ReadLine();
            Console.WriteLine(" nhap vao phong ban : ");
            PhongBan = Console.ReadLine();
            Console.WriteLine(" nhap vao he so luong  : ");
            HeSoLuong = Convert.ToDouble(Console.ReadLine());
        }
        public double ThuNhap()
        {
            double thuNhap = 0;
            thuNhap = HeSoLuong * 1080000;
            return thuNhap;
        }
        public override void xuat()
        {
            Console.WriteLine(" thong tin nhan vien: ho ten: " + hoTen + " ngay sinh: " + ngaySinh + " manv: " + Manv + " chua vu" + ChucVu +
                "phong ban: " + PhongBan + " he so luong" + HeSoLuong + " thu nhap" + ThuNhap());

        }
       

    }
}
