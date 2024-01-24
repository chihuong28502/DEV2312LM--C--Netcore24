using System.Collections;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            Hashtable studentHashtable = new Hashtable();
            int choice;
            do {

                Console.WriteLine("***************Menu chính**********");
                Console.WriteLine("*******Please select an option********");
                Console.WriteLine("1.   Một bản ghi sinh viên mới");
                Console.WriteLine("2.   Hiển thị tất cả sinh viên");
                Console.WriteLine("3.   Tính toán điểm trung bình");
                Console.WriteLine("4.   THOAT");
                Console.Write("    NHAP LUA  CHON CUA BAN VAO:");
                choice = int.Parse(Console.ReadLine());
             switch (choice)
            {
                    case 1:
                        Console.WriteLine("NHAP VAO THONG TIN SINH VIEN");
                        Console.Write("NHAP VAO ID: ");
                        int id;
                        while (!int.TryParse(Console.ReadLine(), out id))
                        {
                            
                            Console.WriteLine("Vui lòng nhập một số nguyên cho ID.");
                            Console.Write("NHAP VAO ID: ");
                        }

                        Console.Write("NHAP VAO name: ");
                        string name = Console.ReadLine();

                        Console.Write("NHAP VAO gender: ");
                        string gender = Console.ReadLine();

                        Console.Write("NHAP VAO age: ");
                        int age;
                        while (!int.TryParse(Console.ReadLine(), out age))
                        {
                            Console.WriteLine("Vui lòng nhập một số nguyên cho tuổi.");
                            Console.Write("NHAP VAO age: ");
                        }

                        Console.Write("NHAP VAO class: ");
                        string stdclass = Console.ReadLine();
                        Student std = new Student();

                        std.SetMarkList();
                        float x = std.CalAvg();
                        Student newStudent = new Student(id, name, gender, age, stdclass, x);
                        studentHashtable.Add(id , newStudent);
                        break;
                    case 2:
                        Console.Write("Nhập StudID để hiển thị thông tin sinh viên: ");
                        int idDisplay = Convert.ToInt32(Console.ReadLine());

                        if (studentHashtable.ContainsKey(idDisplay))
                        {
                            Student studentToDisplay = (Student)studentHashtable[idDisplay];
                            Console.WriteLine("Thông tin sinh viên:");
                            studentToDisplay.Print();
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine($"Không tìm thấy sinh viên với id {idDisplay}.");
                        }
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("vui long nhap lai");
                        break;
                }
            } while (choice != 4) ;
            Console.ReadLine();
        }
    }
}
    
