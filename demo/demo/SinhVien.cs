using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    class SinhVien : Nguoi
    {
        private string hoTen;
        private string MaSV;
        private int Tuoi;

        public void nhap()
        {
            Console.WriteLine("hay nhap thong tin cua sinh vien");
            Console.WriteLine("hay nhap ma sinh vien: ");
            MaSV = Console.ReadLine();
            Console.WriteLine("hay nhap ho ten sinh vien: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("hay nhap tuoi sinh vien: ");
            tuoi = Convert.ToInt32(Console.ReadLine());
        }

        public void hienThi()
        {
            Console.WriteLine("Thong tin cua sinh vien laf : " + hoTen + "  ma: " + MaSV + "  tuoi " + tuoi);
        }

        public int tuoi
        {
            get
            {
                return this.Tuoi;
            }
            set
            {
                this.Tuoi = value;
            }
        }

    }
}
