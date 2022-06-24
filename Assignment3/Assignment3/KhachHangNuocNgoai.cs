using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class KhachHangNuocNgoai
    {
        public string id { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public int soluong { get; set; }
        public double giatien { get; set; }
        public string quoctich { get; set; }

        public string[] quoctichtuychon = { "Portugal", "Argentina", "Spain", "England" };
        public int[] dinhmuc = { 50, 100, 200 };

        public double tinhtien()
        {
            if (soluong <= dinhmuc[0])
            {
                giatien = soluong * 2000;
            }
            else if (soluong <= dinhmuc[1])
            {
                giatien = (soluong) * 2000;
            }
            else if (soluong <= dinhmuc[2])
            {
                giatien = (soluong) * 2000;
            }
            else
            {
                giatien = (soluong) * 2000;
            }
            return giatien;
        }
        public void hienthi()
        {
            Console.WriteLine("\n Thong tin hoa don ");
            Console.WriteLine("Ma khach hang: " + id);
            Console.WriteLine("Ho va ten: " + name);
            Console.WriteLine("Ngay thu: " + date);
            Console.WriteLine("So luong tieu thu(KW): " + soluong);
            Console.WriteLine("Quoc tich cua khach: " + quoctich);
            Console.WriteLine("Gia tien can thanh toan: " + giatien);
        }
    }
}
