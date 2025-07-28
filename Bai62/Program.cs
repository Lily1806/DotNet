using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bai62
{
    internal class Program
    {
        static List<Car> cars = new List<Car>();
        static List<Truck> trucks = new List<Truck>(); 
        static void NhapDL()
        {
            int i = 0;
            while(i<3)
            { 
                Console.Write("Nhập id car bạn muốn thêm");
                string id = Console.ReadLine();
                if (cars.Any(x => (x.id == id)))
                {
                    Console.WriteLine("id đã tồn tại!");
                    return;
                }
                Car ca = new Car();
                ca.id = id;
                ca.Input();
                cars.Add(ca);
                Console.WriteLine("Đã thêm thành công!"); i++;
            }
            int j = 0;  
            while (j < 3)
            {
                Console.Write("Nhập id truck bạn muốn thêm");
                string id = Console.ReadLine();
                if (cars.Any(x => (x.id == id)))
                {
                    Console.WriteLine("id đã tồn tại!");
                    return;
                }
                Truck tu = new Truck();
                tu.id = id;
                tu.Input();
                trucks.Add(tu);
                Console.WriteLine("Đã thêm thành công!"); j++;
            }

        }

        static void HienThiDL_car()
        {
            if(cars.Count == 0)
            {
                Console.WriteLine("Danh sách car rỗng!");
                return;
            }
            Console.WriteLine("{0, -10}{1, -20}{2, -20}{3, -20}{4, -15}{5, -10}", "ID","Marker" , "Model" ,"Year" , "Price", "Color");
            foreach(var car in cars)
            {
                car.Output();
            }

        }
        static void HienThiDL_stuck()
        {
            if (trucks.Count == 0)
            {
                Console.WriteLine("Danh sách stuck rỗng!");
                return;
            }

            Console.WriteLine("{0, -10}{1, -20}{2, -20}{3, -20}{4, -15}{5, -10}", "ID", "Marker", "Model", "Year", "Price", "Truckload");
            foreach (var truck in trucks)
            {
                truck.Output();
            }
        }
        static void TK_ID()
        {
            Console.Write("Nhập id bạn muốn tìm: ");
            string id = Console.ReadLine();
            bool check=false;
            foreach(var car in cars)
            {
                if(car.id == id)
                {
                    Console.WriteLine("Đã tìm thấy thông tin cars có id: " + id);
                    check = true;
                    Console.WriteLine("=======================THÔNG TIN SẢN PHẨM CẦN TÌM========================");
                    car.Output();
                } 
                
            }

            foreach (var truck in trucks)
            {
                if (truck.id == id)
                {
                    Console.WriteLine("Đã tìm thấy thông tin truck có id: " + id);
                    check = true;
                    Console.WriteLine("=======================THÔNG TIN SẢN PHẨM CẦN TÌM========================");
                   truck.Output();
                }

            }

            if(!check) Console.WriteLine("Không tìm thấy sản phẩm nào");
        }
        static void TK_Market()
        {
            Console.Write("Nhập market bạn muốn tìm: ");
            string marker = Console.ReadLine();
            bool check = false;
            Console.WriteLine("=======================THÔNG TIN SẢN PHẨM CẦN TÌM========================");
            Console.WriteLine("{0, -10}{1, -20}{2, -20}{3, -20}{4, -15}{5, -10}", "ID", "Marker", "Model", "Year", "Price", "color");

            foreach (var car in cars)
            {
                while (car.marker == marker)
                {
                    check = true;
                    car.Output();
                }

            }


            Console.WriteLine("{0, -10}{1, -20}{2, -20}{3, -20}{4, -15}{5, -10}", "ID", "Marker", "Model", "Year", "Price", "Truckload");

            foreach (var truck in trucks)
            {
                while (truck.marker == marker)
                {
                    check = true;
                    truck.Output();
                }

            }

            if (!check) Console.WriteLine("Không tìm thấy sản phẩm nào");
        }

        static void SX_Price()
        {
            Console.WriteLine("==============DANH SÁCH CÁC XE TRƯỚC KHI SẢN XUẤT THEO GIÁ==========================");
            HienThiDL_car();
            HienThiDL_stuck();
            cars.Sort((a, b) => a.price.CompareTo(b.price));
            trucks.Sort((a, b) => a.price.CompareTo(b.price));
            Console.WriteLine("==============DANH SÁCH CÁC XE SAU KHI SẢN XUẤT THEO GIÁ==========================");
            HienThiDL_car();
            HienThiDL_stuck();

        }
        static void SX_Year()
        {
            Console.WriteLine("==============DANH SÁCH CÁC XE TRƯỚC KHI SẢN XUẤT THEO NĂM==========================");
            HienThiDL_car();
            HienThiDL_stuck();
            cars.Sort((a, b) => a.year.CompareTo(b.year));
            trucks.Sort((a, b) => a.year.CompareTo(b.year));
            Console.WriteLine("==============DANH SÁCH CÁC XE SAU KHI SẢN XUẤT THEO NĂM==========================");
            HienThiDL_car();
            HienThiDL_stuck();
        }
        static void Main(string[] args)
        {

            string chon;
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                Console.WriteLine("------------------------------MENU----------------------------");
                Console.WriteLine("1. Nhập dữ liệu");
                Console.WriteLine("2. Hiển thị dữ liệu");
                Console.WriteLine("3. Tìm kiếm theo id");
                Console.WriteLine("4. Tìm kiếm theo marker");
                Console.WriteLine("5. Sắp xếp theo price");
                Console.WriteLine("6. Sắp xếp theo year");
                Console.WriteLine("7. Kết thúc");
                Console.WriteLine("Bạn chọn: ");
                chon = Console.ReadLine();
                switch(chon)
                {
                    case "1":
                        NhapDL();
                        break;
                    case "2":
                        Console.WriteLine("=========================DANH SACH CAC XE===========================");
                        HienThiDL_car();
                        HienThiDL_stuck();
                        break;
                    case "3":
                        TK_ID();
                        break;
                    case "4":
                        TK_Market();
                        break;
                    case "5":
                        SX_Price();
                        break;
                    case "6":
                        SX_Year();
                        break;
                    case "7":
                        Console.WriteLine("Chương trình kết thúc!");
                        break;
                    default:
                        Console.WriteLine("Lệnh nhập không hợp lệ!");
                        break ;
                }    
            } while (chon != "7");
        }
    }
}
