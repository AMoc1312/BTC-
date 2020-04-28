using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class1
    {
        float chieuDai;
        float chieuRong;
        
        public Class1(float dai, float rong)
         {
             chieuDai = dai;
             chieuRong = rong;
         }
        public float dientich()
        {
            float dt = 0;
            dt = chieuRong * chieuDai;
            return dt;
        }
    }
}
