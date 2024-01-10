using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    internal class Student
    {
        //properties
        public int ID { get; set; }
        public string Name{ get; set; }
        public Student() { 
        ID = 0;
            Name = "";
        }
        public Student(int iD,string name) {
            ID = iD;
            Name = name;
        }
        public void Display()
        {
            Console.WriteLine("ID: {0} | Name : {1}",ID,Name);
        }
    }
}
