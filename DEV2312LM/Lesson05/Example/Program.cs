namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Student student = new Student();
            //Console.WriteLine(student.ToString());
            //Student student1 = new Student(1,"chi huong",45);
            //student1.Display();
            // Console.WriteLine(student1.ToString());
            int[] a;
            int[] b = new int[10];
            float[] c = new float[] { 1.2f, 1.3f, 1.5f, 1.8f };
            string[] names = { "hung", "dung", "sang", "trong" };
            b[0] = 1000;
            b[5] = 200;
            b[9] = 199;
            Console.WriteLine(b[5]);
            //duyệt
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i]);
            }
            foreach (var item in b)
            {
                Console.Write(item);

            }
            foreach (var item in names)
            {
                Console.Write(item);

            }

            // khởi tạo
            Student[] students =
            {
                new Student(1, "2", 1),
                new Student(1, "2", 3),
                new Student(1, "2", 7),
                new Student(1, "2", 8),
                new Student(1, "2", 10),
                new Student(1, "2", 12)
            };

            foreach(var item in students)
            {
                Console.WriteLine(item);
            }
            for(int i =0;i< students.Length; i++)
            {
                for(int j= i+1;i< students.Length;j++) {
                    if (students[i].age < students[j].age) {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j]= temp;
                    }
                }
            }
            Console.WriteLine(students);
        }
    }
}