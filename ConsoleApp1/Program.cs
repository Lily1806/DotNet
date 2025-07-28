using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static List<Student> students = new List<Student>();

        static void addStudent()
        {
            Console.Write("Nhập id sinh viên bạn muốn thêm: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Id không hợp lệ!");
                return;
            }

            if (students.Any(o => o.id == id))
            {
                Console.WriteLine("Id đã tồn tại!");
                return;
            }

            Student st = new Student();
            st.id = id;
            st.Input();
            students.Add(st);
            Console.WriteLine("Đã thêm sinh viên thành công!");
        }

        static void HienThi()
        {
            Console.WriteLine("\n---------------------DANH SÁCH SINH VIÊN--------------------------");
            Console.WriteLine("{0,-10}{1,-15}{2,-20}{3,-10}{4,-10}", "Id", "Name", "Address", "Math", "Physic");
        }

        static void showStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng!");
                return;
            }

            foreach (var student in students)
            {
                student.Output();
            }
        }

        static void sortStudent_id()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng!");
                return;
            }

            students.Sort((x, y) => x.id.CompareTo(y.id));
            Console.WriteLine("\n==================== DANH SÁCH SẮP XẾP THEO ID ============================");
            showStudents();
        }

        static void sortStudent_address()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng!");
                return;
            }

            students.Sort((x, y) => x.address.CompareTo(y.address));
            Console.WriteLine("\n==================== DANH SÁCH SẮP XẾP THEO ADDRESS ============================");
            showStudents();
        }

        static void removeStudent()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng!");
                return;
            }

            Console.Write("Nhập id sinh viên bạn muốn xóa: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Id không hợp lệ!");
                return;
            }

            var studentToRemove = students.Find(s => s.id == id);

            if (studentToRemove == null)
            {
                Console.WriteLine("Id không tồn tại.");
                return;
            }

            students.Remove(studentToRemove);
            Console.WriteLine("Đã xóa sinh viên thành công!");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string Chon;

            do
            {
                Console.WriteLine("\n===================== MENU ================================");
                Console.WriteLine("1. Thêm một sinh viên");
                Console.WriteLine("2. Hiển thị danh sách sinh viên");
                Console.WriteLine("3. Sắp xếp theo id");
                Console.WriteLine("4. Sắp xếp theo address");
                Console.WriteLine("5. Xóa sinh viên theo id");
                Console.WriteLine("6. Kết thúc chương trình");
                Console.Write("Bạn chọn: ");
                Chon = Console.ReadLine();

                switch (Chon)
                {
                    case "1":
                        addStudent();
                        break;
                    case "2":
                        HienThi();
                        showStudents();
                        break;
                    case "3":
                        sortStudent_id();
                        break;
                    case "4":
                        sortStudent_address();
                        break;
                    case "5":
                        removeStudent();
                        break;
                    case "6":
                        Console.WriteLine("Chương trình kết thúc!");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ! Hãy chọn lại!");
                        break;
                }
            } while (Chon != "6");
        }
    }
}
