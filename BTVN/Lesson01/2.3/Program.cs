namespace _2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhập số bất kì");
            int num = int.Parse(Console.ReadLine());
            int minute;
            int hour;
            minute = num / 60;
            hour = minute / 60;
            Console.WriteLine("giờ:{0}\nPhút:{1}\nGiây:{2}",hour, minute % 60,num % 60);
        }
    }
}