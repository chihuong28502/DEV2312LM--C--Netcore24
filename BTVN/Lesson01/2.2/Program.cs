namespace _2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập năm: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập tháng: ");
            int month = int.Parse(Console.ReadLine());
            if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0) && month == 2)   {
                Console.WriteLine("tháng 2 nhuận có 29 ngày");
            }
            else
            {
                switch (month)
                {
                    case 1: Console.WriteLine("tháng 1 có 31");break;
                    case 2: Console.WriteLine("tháng 2 ko nhuận có 28");break;
                    case 3: Console.WriteLine("tháng 3 có 31");break;
                    case 4: Console.WriteLine("tháng 4 có 30");break;
                    case 5: Console.WriteLine("tháng 5 có 31");break;
                    case 6: Console.WriteLine("tháng 6 có 30");break;
                    case 7: Console.WriteLine("tháng 7 có 31");break;
                    case 8: Console.WriteLine("tháng 8 có 31");break;
                    case 9: Console.WriteLine("tháng 9 có 30");break;
                    case 10: Console.WriteLine("tháng 10 có 31");break;
                    case 11: Console.WriteLine("tháng 11 có 30");break;
                    case 12: Console.WriteLine("tháng 12 có 31");break;
                    default: Console.WriteLine("ko tồn tại");break;
                }
            }
        }
    }
}