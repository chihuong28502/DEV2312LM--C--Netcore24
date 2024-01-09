namespace Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student std = new Student();
            std.Display();
            Student student = new Student(111,"devmaster");
            student.Display();
            student.ID = 999;
            student.Name = "123yhjsnd";
            student.Display();
        }
    }
}