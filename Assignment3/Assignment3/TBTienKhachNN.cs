using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment3
{
    public class TBTienKhachNN
    {
            ArrayList dsknn = new ArrayList();
            

            public double tientb { get; set; }
            
            public void slkh(double giatien)
        {
            dsknn.Add(giatien);
        }

        public double giatientb() {
            double tong = 0;
            if(dsknn.Capacity == 0)
            {
                tong = 0;
            }
            else
            {
                foreach (double dem in dsknn)
                {
                    tong = tong + dem;
                }
            }
            return tientb = tong / dsknn.Count;
        }
    }
}
