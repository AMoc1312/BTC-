using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinhVien
{
    class Sinhvien
    {//        Họ tên, Ngày sinh, Điểm thi môn Lập trình, Cơ sở dữ liệu, Thiết kế web.
        //Xây dựng lớp danh sách gồm N sinh viên
        //Đưa ra số lượng sinh viên được làm khoá luận tốt nghiệp; Số lượng sinh viên làm chuyên đề tốt nghiệp với các điều kiện:

        private string HoTen;
        private DateTime NgaySinh;
        private double DiemThiLT;
        private double DiemCSDL;
        private double DiemTKW;

        public Sinhvien()
        {
            HoTen = "";
            NgaySinh = new DateTime();
            DiemCSDL = DiemThiLT = DiemTKW = 0;
        }

        public Sinhvien (string hoten, DateTime ngaysinh, double diemlt, double diemcsdl, double diemtkw)
        {
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.DiemThiLT = diemlt;
            this.DiemCSDL = diemcsdl;
            this.DiemTKW = diemtkw;
        }
        public int KieuTotNghiep()
        {
        // 1: duoc lam khoa luan; 2 duoc lam chuyen de, 0: truot
            double diemtb = (DiemThiLT + DiemCSDL + DiemTKW) / 3;
            int kieu = 0;
            bool dctotngiep = false;
            if ((DiemThiLT >= 5) & (DiemCSDL >= 5) & (DiemTKW >= 5))
                dctotngiep = true;
            if(dctotngiep ==true) // tuong duong voi dk if(dctotnghiep)
            {
                if (diemtb >= 8)
                    kieu = 1;
                else
                    kieu = 2;
            }
            return kieu;            
        }

        public void nhap()
        {
            Console.WriteLine("Hay nhap vao ten cua sv");
            HoTen = Console.ReadLine();
            Console.WriteLine("hay nhap vao diem LT cua sinh vien:");
            DiemThiLT = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hay nhap vao diem CSDL cua sinh vien:");
            DiemCSDL = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hay nhap vao diem Thiet ke web cua sinh vien:");
            DiemTKW = Convert.ToInt32(Console.ReadLine());

        }

    }
}
