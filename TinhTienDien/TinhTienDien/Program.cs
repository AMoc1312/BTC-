using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinhTienDien
{
    class Program
    {
        static void Main(string[] args)
        { TienDien TienDien1 = new TienDien( "Hoang anh", "Hà Noiji", 100, 700);
          TienDienMoi TienDien2 = new TienDienMoi("Hoang anh", "Hà Noiji", 100, 700);
          TienDienMoi Tiendien3 = new TienDienMoi("MinhAnh", "Hai Duong", 20, 30);

          TienDien2.nhap();
          Console.WriteLine("So tien cua đối tượng tiền điện 1 là: " + TienDien1.tinhTienDien());
          Console.WriteLine("Số tiền của đối tượng tiền điện 2 là: " + TienDien2.tinhTienDien());



            // Day la the hien cua tinh da hinh, doi tuong co kieu la lop cha, nhung the hien thuc su la lop con
            TienDien TienDien4 = new TienDienMoi("MinhAnh", "Hai Duong", 20, 30);
            TienDien4.hienThi();


             //Day la vi du cua lop abstract
             //Mot doi tuong co the nhin ben ngoai nhu doi tuong cha,
            //nhung thuc su no dc the hien ben trong la lop con

        }
    }
}
