namespace _2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Id:");
            int Id = int.Parse(Console.ReadLine());
            string Name;
            Console.WriteLine("Name:");
            Name = Console.ReadLine();
            string Address;
            Console.WriteLine("Address:");
            Address = Console.ReadLine();
            string Birthday;
            Console.WriteLine("Birthday:");
            Birthday = Console.ReadLine();
            Console.WriteLine("Salary:");
            int Salary= int.Parse(Console.ReadLine());

            Console.WriteLine("Bonus:");
            int Bonus=  int.Parse(Console.ReadLine());
            Console.WriteLine("id:{0} " +
                "\nTen:{1}" +
                "\nBirthday:{2}" +
                "\nAddress:{3}" +
                "\nSalary:{4}" +
                "\nBonus:{5}" +
                "\nTotalSalary:{6} "
                ,Id,Name,Birthday,Address,Salary,Bonus,(Salary+Bonus));
            
        }
    }
}