using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment3
{
    public class CountKH
    {
        ArrayList slknn = new ArrayList();
        ArrayList slkvn = new ArrayList();


        public int slkhachvn { get; set; }
        public int slkhachnn { get; set; }

        public void demkvn(int soluong)
        {
            slkvn.Add(soluong);
        }
        public void demknn(int soluong)
        {
            slknn.Add(soluong);
        }

        public int demkhachvn()
        {
            int dem = 0;
            if (slkvn.Capacity == 0)
            {
                dem = 0;
            }
            else
            {
               foreach(int check in slkvn)
                {
                    dem += 1;
                }
            }
            return slkhachvn = dem;
        }

        public int demkhachnn()
        {
            int dem = 0;
            if (slknn.Capacity == 0)
            {
                dem = 0;
            }
            else
            {
                foreach (int check in slknn)
                {
                    dem += 1;
                }
            }
            return slkhachnn = dem;
        }
    }
}
