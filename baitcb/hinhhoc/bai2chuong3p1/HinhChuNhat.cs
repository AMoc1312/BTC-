using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai2chuong3p1
{
    class HinhChuNhat:Hinh
    {
        private int chieuRong, chieuDai;
        
        public override void nhap()
        {
            Console.WriteLine("hay nhap vao chieu rong hinh chu nhat: ");
            chieuRong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hay nhap vao chieu Dai cua hinh chu nhat: ");
            chieuDai = Convert.ToInt32(Console.ReadLine());
        }
        public override double chuVi()
        {
            return 2 * (chieuRong + chieuDai);
        }
        public override double dienTich()
        {
            return chieuDai * chieuRong;
        }


    }
}
