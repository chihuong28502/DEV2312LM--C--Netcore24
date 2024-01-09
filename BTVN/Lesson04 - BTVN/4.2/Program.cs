namespace _4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             double diemTB;
            StudentCollege stdC = new StudentCollege("Chi Huong",2002,9,6,4);
            diemTB = stdC.Average();
            stdC.Display();
            Console.WriteLine(diemTB);

            StudentUniversity stdU = new StudentUniversity("Chi Huong", 2002, 9, 6, 4,0);
            stdU.Display();
            diemTB = stdU.Average();

            Console.WriteLine(diemTB);
        }
    }
}