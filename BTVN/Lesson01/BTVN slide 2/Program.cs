namespace BTVN_slide_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.8
            Console.WriteLine("nhập tiền:");
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine("Lãi xuất theo năm ");
            double rateYear = double.Parse(Console.ReadLine())/100;
            Console.WriteLine("gửi bao nhiêu tháng:");
            int month= int.Parse(Console.ReadLine());
            double totalMoney = money;
            for (int i = 1; i <= month; i++) {
                double interest = totalMoney * rateYear / 12; // Tính lãi hàng tháng
                totalMoney += interest;
                Console.WriteLine(totalMoney);
            }


        }
    }
}