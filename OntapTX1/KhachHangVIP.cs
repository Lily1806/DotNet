using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OntapTX1
{
    internal class KhachHangVIP : KhachHang
    {

        public KhachHangVIP(string maKhachHang, string hoTen, int soLuongMua, double donGia) : base(maKhachHang, hoTen, soLuongMua, donGia)
        {
        }

        public string XacDinhQuaTang()
        {
            double tongTien = TinhTongTien();
          
            if (tongTien < 1000)
                return "Coupon 100";
            else if (tongTien >= 1000 && tongTien <= 5000)
                return "Coupon 150";
            else if (tongTien > 5000)
                return "Coupon 200";

            return "";
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nQuà tặng: {XacDinhQuaTang()}";
            
        }
    }
}
