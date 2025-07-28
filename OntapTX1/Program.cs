using System.Text;

namespace OntapTX1
{

    internal class Program
    {

        static List<KhachHang> danhSachKhachHang = new List<KhachHang>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int luaChon;
            do
            {
                luaChon = HienThiMenu();
                Console.Clear();

                switch (luaChon)
                {
                    case 1:
                        NhapThongTinKhachHang();
                        break;
                    case 2:
                        HienThiDanhSachKhachHang();
                        break;
                    case 3:
                        TimKhachHangMuaNhieuHangNhat();
                        break;
                    case 4:
                        Console.WriteLine("Tạm biệt!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }

                Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                Console.ReadKey();
            } while (luaChon != 4);
        }
        
        private static int HienThiMenu()
        {
            Console.WriteLine("----- CHƯƠNG TRÌNH QUẢN LÝ KHÁCH HÀNG -----");
            Console.WriteLine("1. Nhập thông tin");
            Console.WriteLine("2. Hiển thị danh sách");
            Console.WriteLine("3. Tìm khách hàng mua nhiều hàng nhất");
            Console.WriteLine("4. Thoát");
            Console.Write("Nhập số tương ứng với chức năng muốn sử dụng: ");

            int luaChon = int.Parse(Console.ReadLine());
            return luaChon;
        }

        private static void NhapThongTinKhachHang()
        {
            Console.WriteLine("----- NHẬP THÔNG TIN KHÁCH HÀNG -----");
            Console.WriteLine("1. Khách hàng thường");
            Console.WriteLine("2. Khách hàng VIP");
            Console.Write("Chọn loại khách hàng: ");

            int loaiKhachHang = int.Parse(Console.ReadLine());

            switch (loaiKhachHang)
            {
                case 1:
                    NhapThongTinKhachHangThuong();
                    break;
                case 2:
                    NhapThongTinKhachHangVIP();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Quay lại menu.");
                    break;
            }
        }

        private static void NhapThongTinKhachHangVIP()
        {
            Console.Write("Nhập mã khách hàng: ");
            string maKhachHang = Console.ReadLine();

            if (KiemTraTonTaiKhachHang(maKhachHang))
            {
                Console.WriteLine("Khách hàng đã tồn tại. Quay lại menu.");
                return;
            }

            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine();

            Console.Write("Nhập số lượng mua: ");
            int soLuongMua = int.Parse(Console.ReadLine());

            Console.Write("Nhập đơn giá: ");
            double donGia = double.Parse(Console.ReadLine());

            KhachHangVIP khachHangVIP = new KhachHangVIP(maKhachHang, hoTen, soLuongMua, donGia);
            danhSachKhachHang.Add(khachHangVIP);

            Console.WriteLine("Nhập thông tin khách hàng VIP thành công.");
        }

        private static void NhapThongTinKhachHangThuong()
        {
            Console.Write("Nhập mã khách hàng: ");
            string maKhachHang = Console.ReadLine();

            if (KiemTraTonTaiKhachHang(maKhachHang))
            {
                Console.WriteLine("Khách hàng đã tồn tại. Quay lại menu.");
                return;
            }

            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine();

            Console.Write("Nhập số lượng mua: ");
            int soLuongMua = int.Parse(Console.ReadLine());

            Console.Write("Nhập đơn giá: ");
            double donGia = double.Parse(Console.ReadLine());

            KhachHang khachHangThuong = new KhachHang(maKhachHang, hoTen, soLuongMua, donGia);
            danhSachKhachHang.Add(khachHangThuong);

            Console.WriteLine("Nhập thông tin khách hàng thành công.");
        }

        private static bool KiemTraTonTaiKhachHang(string maKhachHang)
        {
            foreach (KhachHang khachHang in danhSachKhachHang)
            {
                if (khachHang.MaKhachHang == maKhachHang)
                    return true;
            }
            return false;
        }

        private static void HienThiDanhSachKhachHang()
        {
            Console.WriteLine("----- DANH SÁCH KHÁCH HÀNG -----");

            if (danhSachKhachHang.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng.");
                return;
            }

            foreach (KhachHang khachHang in danhSachKhachHang)
            {
                Console.WriteLine(khachHang.ToString());
                Console.WriteLine();
            }
        }

        private static void TimKhachHangMuaNhieuHangNhat()
        {
            Console.WriteLine("----- TÌM KHÁCH HÀNG MUA NHIỀU HÀNG NHẤT -----");

            if (danhSachKhachHang.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng.");
                return;
            }

            int maxSoLuongMua = 0;
            List<KhachHang> khachHangMuaNhieuNhat = new List<KhachHang>();

            foreach (KhachHang khachHang in danhSachKhachHang)
            {
                if (khachHang.SoLuongMua > maxSoLuongMua)
                {
                    maxSoLuongMua = khachHang.SoLuongMua;
                    khachHangMuaNhieuNhat.Clear();
                    khachHangMuaNhieuNhat.Add(khachHang);
                }
                else if (khachHang.SoLuongMua == maxSoLuongMua)
                {
                    khachHangMuaNhieuNhat.Add(khachHang);
                }
            }

            Console.WriteLine($"Có {khachHangMuaNhieuNhat.Count} khách hàng mua nhiều hàng nhất:");

            foreach (KhachHang khachHang in khachHangMuaNhieuNhat)
            {
                Console.WriteLine(khachHang.ToString());
                Console.WriteLine();
            }
        }

        private static void SapXepKhachHangTheoTen()
        {
            Console.WriteLine("----- SẮP XẾP KHÁCH HÀNG THEO TÊN -----");

            if (danhSachKhachHang.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng.");
                return;
            }

            danhSachKhachHang.Sort((x, y) => string.Compare(x.HoTen, y.HoTen));

            Console.WriteLine("Danh sách khách hàng sau khi sắp xếp theo tên:");
            HienThiDanhSachKhachHang();
        }

        private static void SapXepKhachHangTheoTongTien()
        {
            Console.WriteLine("----- SẮP XẾP KHÁCH HÀNG THEO TỔNG TIỀN -----");

            if (danhSachKhachHang.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng.");
                return;
            }

            danhSachKhachHang.Sort((x, y) => x.TinhTongTien().CompareTo(y.TinhTongTien()));

            Console.WriteLine("Danh sách khách hàng sau khi sắp xếp theo tổng tiền:");
            HienThiDanhSachKhachHang();
        }

        private static void SapXepKhachHangTheoSoLuongMua()
        {
            Console.WriteLine("----- SẮP XẾP KHÁCH HÀNG THEO SỐ LƯỢNG MUA -----");

            if (danhSachKhachHang.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng.");
                return;
            }

            danhSachKhachHang.Sort((x, y) => x.SoLuongMua.CompareTo(y.SoLuongMua));

            Console.WriteLine("Danh sách khách hàng sau khi sắp xếp theo số lượng mua:");
            HienThiDanhSachKhachHang();
        }

        //private static int HienThiMenu()
        //{
        //    Console.WriteLine("----- CHƯƠNG TRÌNH QUẢN LÝ KHÁCH HÀNG -----");
        //    Console.WriteLine("1. Nhập thông tin");
        //    Console.WriteLine("2. Hiển thị danh sách");
        //    Console.WriteLine("3. Tìm khách hàng mua nhiều hàng nhất");
        //    Console.WriteLine("4. Sắp xếp khách hàng theo tên");
        //    Console.WriteLine("5. Sắp xếp khách hàng theo tổng tiền");
        //    Console.WriteLine("6. Sắp xếp khách hàng theo số lượng mua");
        //    Console.WriteLine("7. Thoát");
        //    Console.Write("Nhập số tương ứng với chức năng muCảm ơn.


    }

   

        
    }
