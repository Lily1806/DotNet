using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OntapTX1
{
    internal class KhachHang
    {
        private String MaKH;
        private String TenKH;
        private int SoLuong;
        private double Gia;

        public string MaKhachHang
        {
            get { return MaKH; }
            set { MaKH = value; }
        }

        public string HoTen
        {
            get { return TenKH; }
            set { TenKH = value; }
        }

        public int SoLuongMua
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }

        public double DonGia
        {
            get { return Gia; }
            set { Gia = value; }
        }

        public KhachHang()
        {
        }

        public KhachHang(string maKhachHang, string hoTen, int soLuongMua, double donGia)
        {
            this.MaKH = maKhachHang;
            this.TenKH = hoTen;
            this.SoLuong = soLuongMua;
            this.Gia = donGia;
        }

        public double TinhTongTien()
        {
            return SoLuong * Gia;
        }

        public override string ToString()
        {
            return $"Mã khách hàng: {MaKH}\nHọ tên: {TenKH}\nSố lượng mua: {SoLuong}\nĐơn giá: {Gia}\nTổng tiền: {TinhTongTien()}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            KhachHang other = (KhachHang)obj;
            return MaKH == other.MaKH;
        }
    }
}
