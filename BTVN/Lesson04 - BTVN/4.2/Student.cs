using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    abstract class Student
    {
        protected string Name { get; set; }
        protected int Year { get; set; }
        public Student(string name , int year) {
            Name = name;
            Year = year;
        }
        public void Display()
        {
            Console.WriteLine("tên: {0} | năm sinh: {1}", Name,Year);
        }
        public abstract double Average();
    }
}
