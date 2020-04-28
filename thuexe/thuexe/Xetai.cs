using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace thuexe
{
    class Xetai : xxe
    {
        public double tinhtien(int sogiothue)
        {
            double sotien = 0;
            if (sogiothue <= 1)
                sotien = 220000;
            else
                sotien = 220000 + (sogiothue - 1) * 85000;
            return sotien;
        }

    }
}
