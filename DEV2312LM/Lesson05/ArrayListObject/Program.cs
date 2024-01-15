using System.Collections;

namespace ArrayListObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayList Object!");
            ArrayList arr = new ArrayList();
            arr.Add(new Student(111,"chi",21));
            Student[] st =
            {
                new Student(222,"name1",2),
                new Student(22,"name3",9),
                new Student(444,"huong",21),
                new Student(4,"duong",21),
            };
            arr.AddRange(st);
            printObject(arr);
            arr.Sort(new SortAgeAsc());
            printObject(arr);
            Hashtable ht = new Hashtable();
            Student st1 = new Student(123,"222222ten0",100);
            ht.Add(st1.Id,st1);
            st1 = new Student(1232, "222retneSasd", 100);
            ht.Add(st1.Id, st1);
            Console.WriteLine("list key");
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(ht[item]);
            }
            foreach (var item in ht.Values)
            {
                Console.WriteLine(item.ToString());
            }

        }
        static void printObject(ArrayList arr) {
            Console.WriteLine("=>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>..");

            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
;            }
        }
        class SortAgeAsc : IComparer
        {
            public int Compare(object x, object y)
            {
                Student a = x as Student;
                Student b = y as Student;
                return a.Age - b.Age;
            }

        }
       // class SortNameDsc : IComparer
       // {
         //   public string Compare(object x, object y)
          //  {
          //      Student a = x as Student;
          //      Student b = y as Student;
          //      return b.Name.CompareTo(a.Name);
          //  }

       // }
    }

}