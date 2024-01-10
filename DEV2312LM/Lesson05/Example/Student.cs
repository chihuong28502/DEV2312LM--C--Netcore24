using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        // constructor
        public Student() { }
        public Student(int Id, string Name,int Age) {
            id = Id;
            name = Name;
            age = Age;
        }
        public void Display()
        {
            Console.WriteLine("id:{0} | name: {1} | age: {2}",id,name,age);
        }
        public override string ToString()
        {
            return string.Format("{0,5} {1,15} {2,10}",id, name,age);
        }
    }
}
