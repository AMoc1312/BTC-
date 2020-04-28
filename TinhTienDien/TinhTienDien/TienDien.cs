using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinhTienDien
{
    class TienDien
    {
        protected string TenChuHo;
        protected string DiaChi;
        protected int SoCongToThangTruoc;
        protected int SoCongToThangNay;
        protected int SoCongToDaDung;

        public TienDien()
        {
            TenChuHo = "";
            DiaChi = "";
            SoCongToThangNay = SoCongToThangTruoc = 0;
        }

        public TienDien(string TenChuHo, String DiaChi, int SoCongToThangTruoc, int SoCongToThangNay)
        {
            this.TenChuHo = TenChuHo;
            this.DiaChi = DiaChi;
            this.SoCongToThangTruoc = SoCongToThangTruoc;
            this.SoCongToThangNay = SoCongToThangNay;
        }

        public virtual void nhap()
        {
            Console.Write("Hãy nhập vào tên chủ hộ: ");
            TenChuHo = Console.ReadLine();
            Console.Write("Hay nhâp vào địa chỉ của chủ hộ: ");
            DiaChi = Console.ReadLine();
            Console.Write("hay nhap số công tơ tháng trước: ");
            SoCongToThangTruoc = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hau nhập vào số công tơ tháng này: ");
            SoCongToThangNay = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void hienThi()
        {
            Console.WriteLine("Day la phuong thuc hien thi cua lop cha: TienDien");
            Console.WriteLine("Chủ hộ " + TenChuHo + " Địa Chỉ: " + DiaChi + "\n"
                + "Số công tơ tháng trước " + SoCongToThangTruoc
                + " Số công tơ tháng này " + SoCongToThangNay);
        }
        public int tinhTienDien()
        {
            return (SoCongToThangNay - SoCongToThangTruoc) * 500;
        }

    }
}
