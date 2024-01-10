using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    internal class Book
{
        public string Author { get; set; }
        public int Pages { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public int CurrentPage { get; set; }
        public  Pagination()
        {
             CurrentPage = 1;
        }
        public constructorAll(string author,int pages,string isbn,string title, int currentPage)
        {
            Author = author;   
            Pages = pages;
            Isbn = isbn;
            Title = title;
            CurrentPage = currentPage;
        }
        public void flipPageForward()
        {
            CurrentPage++;
            Console.WriteLine("da chuyen");
        }
        public void flipPageBackward()
        {
            CurrentPage--;
            Console.WriteLine("da lui");
        }


    }
}
