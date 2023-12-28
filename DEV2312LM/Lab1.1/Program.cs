namespace Lab1._1
{
    /// <summary>
    /// Chương trình c# đầu tiên in ra thông tin giới thiệu bản thân
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lệnh nhập xuất cơ bản
            // Console.WriteLine("Họ và Tên: Chí Hưởng");
            // Console.WriteLine("Ngày sinh: 28/05/2002");
            // Console.WriteLine("Địa chỉ : Liên Hiệp");

            //Khai báo biến
            int id = 1;
            string name = "Chi Huong";
            byte age = 18;
            char gender = 'M';
            const float percent = 75;
            // hiển thị giá trị của biến & hằng số
            Console.WriteLine("Student ID:{0}", id);
            Console.WriteLine("Student Name:{0}", name);
            Console.WriteLine("Age:{0}", age);
            Console.WriteLine("Gender:{0}", gender);
            Console.WriteLine("Percent:{0}", percent);
            //
            Console.WriteLine("lab1.1");
            Console.WriteLine("   ***    ****   ");
            Console.WriteLine("  *   *   *       ");
            Console.WriteLine(" *        *       ");
            Console.WriteLine(" *        ****    ");
            Console.WriteLine(" *        *       ");
            Console.WriteLine("  *   *   *       ");
            Console.WriteLine("   ***    *****   ");
            //
            Console.WriteLine("lab1.2");
            int maNv = 2;
            string hoTen = "Nguyen Chi Huong";
            string ngaysinh = "28/05/2002";
            string diaChi = "Lien Hiep";
            string sdt = "0979756291";
            string email = "chihuong28502@gmail.com";
            Console.WriteLine("maNv:{0}", maNv);
            Console.WriteLine("hoTen:{0}", hoTen);
            Console.WriteLine("ngaysinh:{0}", ngaysinh);
            Console.WriteLine("diaChi:{0}", diaChi);
            Console.WriteLine("sdt:{0}", sdt);
            Console.WriteLine("email:{0}", email);


            Console.Read();
        }
    }
}