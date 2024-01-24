using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIUDCV
{
    class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public int price { get; set; }
        public int year { get; set;}
        public int Year { get; internal set; }

        public Book() { }
        public Book(int id,string name ,string author , int price , int year) {
             this.id =id;
            this.name =name;
            this.author =author;
            this.price =price;
            this.year =year;
        }
        public override string ToString()
        {
            // Định dạng cách hiển thị mỗi cuốn sách
            return $"ID: {id}, Tên sách: {name}, Tác giả: {author}, giá sách: {price}, Năm xuất bản: {year}";
        }
    }
}

