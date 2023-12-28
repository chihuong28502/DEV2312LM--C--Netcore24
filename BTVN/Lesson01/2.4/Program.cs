namespace _2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.WriteLine("Nhập số có 3 chữ số: ");
             x = int.Parse(Console.ReadLine());
            }
            while (x < 100 || x > 999);
            {
                int digit1 = x / 100;
                int digit2 = (x / 10) % 10;
                int digit3 = x % 10;
                int sum = digit1+ digit2+digit3;
                if(sum %2 == 0)
                {
                    Console.WriteLine("chẵn");
                }
                else
                {
                    Console.WriteLine("lẻ");
                }
            }

        }
    }
}