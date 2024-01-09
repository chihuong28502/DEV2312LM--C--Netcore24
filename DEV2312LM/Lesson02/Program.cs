namespace Lesson02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DEMO!");
            // khởi tạo đối tượng
            //Category cat = new Category();
            // truy cập => Thuộc tính
            //cat.Id = 1;
            //cat.Name = "Test";
            //cat.Display();

            Employees emp = new Employees();
            emp.Id = 2;
            emp.FullName = "ok employee";
            emp.Salary = 30000;
            emp.PrintInfo();

            // dùng
            emp = new Employees(222, "22222", 23232);
            emp.PrintInfo();
            // test Cal
            // dùng method static
            int kq = Calculator.Add(10,20);
            Console.WriteLine(kq);
            kq = Calculator.Sub(10,20);
            Console.WriteLine(kq);
             Calculator cl = new Calculator();
            kq = cl.Mul(10,20);
            Console.WriteLine(kq);
            // ref out 
            int cong, tru;
            cl.Cal(10, 20, out cong,out tru);
            Console.WriteLine("Cong:{0}\n tru:{1}", cong, tru);
            // ref
            int num1 = 100, num2 = 200;
            Console.WriteLine("num1:{0} || num2:{1}", num1, num2);
            cl.Swap(num1, num2);
            Console.WriteLine("num1:{0} || num2:{1}", num1, num2);
            cl.Swap(ref num1, ref num2);
            Console.WriteLine("num1:{0} || num2:{1}", num1, num2);

        }
    }
}