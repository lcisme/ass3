using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class KhachHangVietNam 
    {
        public string id { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public int soluong { get; set; }
        public double giatien { get; set; }
        public string doituong { get; set; }


        public string[] danhsachdoituong = { "sinh hoat", "kinh doanh", " san xuat" };
        public int[] dinhmuc = { 50, 100, 200 };
        public int[] dinhmucgia = { 1000, 1200, 1500, 2000 };

        public double tinhtien()
        {

            if (soluong < dinhmuc[0])
            {
                giatien = soluong * dinhmucgia[0];
            }
            else if (soluong < dinhmuc[1])
            {
                giatien = (dinhmuc[0] - 1) * dinhmucgia[0] + (soluong - dinhmuc[0]) * dinhmucgia[1];
            }
            else if (soluong < dinhmuc[2])
            {
                giatien = ((dinhmuc[0] - 1) * dinhmucgia[0] + (dinhmuc[1] - dinhmuc[0] - 1) * dinhmucgia[1] + (soluong - dinhmuc[1]) * dinhmucgia[2]);
            }
            else
            {
                giatien = ((dinhmuc[0] - 1) * dinhmucgia[0] + (dinhmuc[1] - dinhmuc[0] - 1) * dinhmucgia[1] + (dinhmuc[2] - dinhmuc[1] - 1) * dinhmucgia[2]) + (soluong - dinhmuc[2]) * dinhmucgia[3];
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
            Console.WriteLine("Doi tuong khach hang: " + doituong);
            Console.WriteLine("Gia tien can thanh toan: " + giatien);
        }
    }
}
