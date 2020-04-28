using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nguoi
{
    class Nguoii
    {
        protected string hoTen;
        protected DateTime ngaySinh = new DateTime();

        public virtual void nhap()
        {
            Console.WriteLine(" hay nhap vao ho ten : ");
            hoTen = Console.ReadLine();
            Console.WriteLine(" hay nhap vao ngay sinh : ");
            ngaySinh = Convert.ToDateTime(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine(" thong tin nhan vien nhap vao la: " + hoTen + " ngay sinh: " + ngaySinh);
        }
        public Nguoii(string hoTen, DateTime ngaySinh)
        {
            this.ngaySinh = ngaySinh;
            this.hoTen = hoTen;
        }
    }


}
