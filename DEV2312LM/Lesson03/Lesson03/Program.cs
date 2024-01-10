using System;

namespace Lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo một đối tượng Book bằng constructor mặc định
            Book defaultBook = new Book();
            Console.WriteLine($"Trang hiện tại của sách mặc định: {defaultBook.CurrentPage}"); // Hiển thị trang hiện tại

            // Tạo một đối tượng Book với thông tin cụ thể bằng constructor có tham số
            Book specificBook = new Book("John Doe", 200, "1234567890", "Sample Book", 10);
            Console.WriteLine($"Tác giả của sách cụ thể: {specificBook.Author}"); // Hiển thị tác giả

            // Gọi phương thức để lật trang tiếp theo
            specificBook.flipPageForward();
            Console.WriteLine($"Trang hiện tại sau khi chuyển trang: {specificBook.CurrentPage}"); // Hiển thị trang hiện tại

            // Gọi phương thức để lật trang về trang trước
            specificBook.flipPageBackward();
            Console.WriteLine($"Trang hiện tại sau khi lùi trang: {specificBook.CurrentPage}"); // Hiển thị trang hiện tại
        }
    }
}
