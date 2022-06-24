using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Mainn
    {
        public static void Main(string[] args)
        {
            KhachHangVietNam vn = new KhachHangVietNam();
            vn.id = "T2108M";
            vn.name = "Cuong dep trai";
            vn.date = "Thang 1 nam 2019";
            vn.doituong = vn.danhsachdoituong[2];
            vn.soluong = 38;
            vn.tinhtien();
            vn.hienthi();

            KhachHangVietNam vn1 = new KhachHangVietNam();
            vn1.id = "T1903M";
            vn1.name = "Duy dep trai";
            vn1.date = "Thang 1 nam 2019";
            vn1.doituong = vn.danhsachdoituong[1];
            vn1.soluong = 438;
            vn1.tinhtien();
            vn1.hienthi();


            KhachHangNuocNgoai nn = new KhachHangNuocNgoai();
            nn.id = "T2109A";
            nn.name = "Mit to Quang Hoa";
            nn.date = "Thang 1 nam 2019";
            nn.quoctich = nn.quoctichtuychon[2];
            nn.soluong = 38;
            nn.tinhtien();
            nn.hienthi();

            KhachHangNuocNgoai nn1 = new KhachHangNuocNgoai();
            nn1.id = "T1809A";
            nn1.name = "Mit to Manh Truong";
            nn1.date = "Thang 1 nam 2019";
            nn1.quoctich = nn.quoctichtuychon[3];
            nn1.soluong = 54;
            nn1.tinhtien();
            nn1.hienthi();
        }
    }
}
