using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Nguoi sv1 = new SinhVien();

            // Khai bao doi tuong thong qua interface thi phai chi ro lop thuc thi la lop nao
            // INguoi sv2 = new INguoi();
            sv1.nhap();
            sv1.hienThi();
        }
            

        
    }
}
