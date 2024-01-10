namespace Lesson03_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // overloading
            OverloadingDemo over = new OverloadingDemo();
            int res = over.Sum(10);
           //Console.WriteLine("sum tổng từ 0 đến n: "+ res);
            res = over.Sum(1,10);
            //Console.WriteLine("sum tổng từ 1 -> 10 :"+res);
            double kq = over .Sum(1.1f,10.9f);
            //Console.WriteLine("double tổng từ 1 -> 10:" + kq);


            /// kế thừa
            Animal anm = new Animal();
            anm.DoSomeThing();
            anm.Eat();
            Cat c = new Cat();
            c.DoSomeThing();
            c.Eat();

            /// kế thừa
            Staff staff = new Staff();
            staff.prinInfo();
            staff = new Staff(123,"chi huong","lien hiep","0979756291",123123123,1000);
            staff.prinInfo();
            Console.WriteLine(staff.ToString());
        }
    }
}