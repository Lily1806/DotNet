using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bai61
{
    internal class Program
    {
        static List<student> students = new List<student>();

        static void addStudent()
        {
            Console.Write("Nhập id sinh viên bạn muốn thêm: ");
            if (!int.TryParse(Console.ReadLine(), out int Id))
            {
                Console.WriteLine("id không hợp lệ!");
                return;
            }
            if(students.Any(x => x.id  == Id))
            {
                Console.WriteLine("id đã tồn tại!");
                return;
            }

            student sv = new student();
            sv.id = Id;
            sv.Input();
            students.Add(sv);
            Console.WriteLine("Đã thêm sinh viên thành công");
        }

       
        static void showStudents()
        {
            Console.WriteLine("{0, -10}{1, -20}{2, -25}{3, -10}{4, -10}", "id", "name", "address", "math", "physic");
            foreach (var student in students)
            {
                student.Output();
            }
        }

        static void findStudent_id()
        {
            if(students.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng!");
                return;
            }    
            Console.Write("Nhập id sinh viên bạn muốn tìm: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("id không hợp lệ!");
                return;
            }
            foreach (var student in students)
            {
                if (student.id == id)
                {
                    Console.WriteLine("Đã tìm thấy sinh viên với mã id: " + id);
                    Console.WriteLine("==============THÔNG TIN SINH VIÊN BẠN MUỐN TÌM======================");
                    Console.WriteLine("{0, -10}{1, -20}{2, -25}{0, -10}{1, -10}", "id", "name", "address", "math", "physic");
                    student.Output();
                    
                }    
            } 
                
        }

        static void findStudent_address()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Danh sách rỗng!");
                return;
            }
            Console.Write("Nhập địa chỉ bạn muốn tìm: ");
            string address = Console.ReadLine();

            Console.WriteLine("==============THÔNG TIN SINH VIÊN BẠN MUỐN TÌM======================");
            Console.WriteLine("{0, -10}{1, -20}{2, -25}{0, -10}{1, -10}", "id", "name", "address", "math", "physic");
            foreach (var student in students)
            {
                if (student.address == address)
                {
                    student.Output();
                }
            }
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
                Console.WriteLine("id không hợp lệ!");
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
            string chon;
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                Console.WriteLine("=====================================MENU===================================");
                Console.WriteLine("1. Thêm một sinh viên");
                Console.WriteLine("2. Hiển thị danh sách sinh viên");
                Console.WriteLine("3. Tìm kiếm sinh viên theo id");
                Console.WriteLine("4. Tìm kiếm sinh viên theo address");
                Console.WriteLine("5. Xóa một sinh viên theo id");
                Console.WriteLine("6. Kết thúc chương trình");
                Console.Write("Bạn chọn: ");
                chon = Console.ReadLine();
                switch (chon)
                {
                    case "1":
                        addStudent();
                        break;
                    case "2":
                        Console.WriteLine("=========================DANH SÁCH SINH VIÊN==================================");
                        showStudents();
                        break;
                    case "3":
                        findStudent_id();
                        break;
                    case "4":
                        findStudent_address();
                        break;
                    case "5":
                        removeStudent();
                        break;
                    case "6":
                        Console.WriteLine("Chương trình kết thúc!");
                            break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

            } while (chon != "6");   
        }
    }
}
