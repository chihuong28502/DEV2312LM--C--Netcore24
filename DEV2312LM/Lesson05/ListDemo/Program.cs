using ListDemo;

namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List Generic");
            List<int> list = new List<int>();
            list.Add(9);
            list.Add(2);
            list.Add(3);
            
            list.Sort();
            foreach (var item in list)
            {
                Console.Write("{0,5}", item);
            }
            // giảm
            list.Sort((x,y)=> { return y - x; });
            foreach (var item in list)
            {
                Console.Write("{0,5}", item);
            }


            // object
            Console.WriteLine();
            List<Student> student = new List<Student>() {

            new Student(222,"name1",2),
                new Student(22,"name3",9),
                new Student(444,"huong",21),
                new Student(4,"duong",21),
            };
            student.Sort((x,y)=> { return x.Age - y.Age; });
            student.Sort((x,y)=> { return y.Age - x.Age; });
            foreach (var item in student)
            {
                Console.WriteLine( item.ToString());
            }
        }
    }
}