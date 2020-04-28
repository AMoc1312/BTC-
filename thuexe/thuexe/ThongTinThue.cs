using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace thuexe
{
    class ThongTinThue
    {
        private string HoTenThue;
        private int sogiothue;
        private xxe kieuxe;

        public void nhap()
        {
            try
            {
                Console.WriteLine("hay nhap ho ten nguoi thue");
                HoTenThue = Console.ReadLine();
                Console.WriteLine("hay nhap so gio thue");
                sogiothue = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("hay chon loai xe can thue: Chon 1 neu la xe tai, chon 2 neu la xe du lich: \n 1/2?");

                int loaixe = Convert.ToInt32(Console.ReadLine());

                if (loaixe == 1)
                    kieuxe = new Xetai();
                else kieuxe = new XeDuLich();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        public void xuat()
        {
            Console.WriteLine("thong tin nguoi thue: " + HoTenThue + " so gio thue: " +
                sogiothue + "sotien thue " + kieuxe.tinhtien(sogiothue));
        }


    }
}
