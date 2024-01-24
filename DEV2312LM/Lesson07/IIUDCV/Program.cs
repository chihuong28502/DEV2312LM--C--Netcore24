using System.ComponentModel;

namespace IIUDCV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> lists = new List<Book>()
            {
                new Book(1,"sach1","tac gia 1",100001,2001),
                new Book(2,"sach2","tac gia 2",100002,2002),
                new Book(3,"sach3","tac gia 3",100003,2003),
                new Book(4,"sach4","tac gia 4",100004,2004),
                new Book(5,"sach5","tac gia 5",100005,2005),
                new Book(6,"sach6","tac gia 6",100006,2006),
                new Book(7,"sach7","tac gia 7",100007,2007),
                new Book(8,"sach8","tac gia 8",100008,2008),
                new Book(9,"sach9","tac gia 9",100009,2009),
                new Book(10,"sach10","tac gia 10",1000010,2010)
            };
            //Print(lists);
        var result1 = from m in lists where m.year == 2005 select m;
            Print(result1.ToString());

        }
        static void Print(List<Book> books)
        {
            {
                Console.WriteLine("<==============================>");
                foreach (var item in books)
                {
                    Console.WriteLine(item);
                }

            }
        }
    }
}