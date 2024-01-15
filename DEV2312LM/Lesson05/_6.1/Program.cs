using System.Reflection.Metadata.Ecma335;

namespace _6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List Generic");
            List<Book> books = new List<Book>() { 
            new Book(1,"title1","Nhi Dong","publisher1",2013,1),
            new Book(2,"title2","author2","publisher2",2014,2),
            new Book(3,"title3","Nhi Dong","publisher3",2011,3),
            new Book(4,"title4","author4","publisher4",2014,4),
            new Book(5,"title5","Nhi Dong","publisher5",2015,5),
            new Book(6,"title6","author6","publisher6",2014,6),
            new Book(7,"title7","Nhi Dong","publisher7",2017,7),
            new Book(8,"title8","author8","publisher8",2014,8),
            new Book(9,"title9","author9","publisher9",2019,9),
            new Book(10,"title10","author10","publisher10",2010,10),
            };
            Console.Write("Nhập giá trị: ");
            string input = Console.ReadLine();
            List<Book> booksYear2014 = new List<Book>();
            foreach (var item in books) {
                if(item.Year == int.Parse(input))
                {
                    booksYear2014.Add(item);
                }
            }
            Console.WriteLine("2014");
            foreach (var item in booksYear2014)
            {
                printInfo(item);
            }
            //books.Sort((x, y) => { return (int)(x.Price - y.Price);});
            books.Sort((x, y) => { 
                if(x.Price >y.Price)
                    return 1;
                else if(x.Price <y.Price)
                    return -1;
                return 0;
            });
            Console.WriteLine("in ra all");
            books.RemoveAll(b => b.Author.Contains("Nhi Dong"));
            foreach (var item in books)
            {
                printInfo(item);
            }
        }
        static void printInfo(Book book) {
            Console.WriteLine("id:{0} |" +
                " name:{1} | author:{2} |" +
                " price:{3} | năm:{4}"
                ,book.Id,book.Title,book.Author,book.Price,book.Year);
        }

    }
}