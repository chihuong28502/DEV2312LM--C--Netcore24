using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Example
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public float BaseSalary { get; set; }
        public Person() { }
        public Person(int id ,string name,string address,string phone,float baseSalary)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            BaseSalary = baseSalary;
        }
        public void prinInfo()
        {
            Console.WriteLine(
                "Id: {0} | name: {1} | Address: {2} | Phone: {3} ", Id, Name, Address, Phone
                );
        }
        public virtual float GetBaseSalary()
        {
            return BaseSalary;
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("{0} ", GetBaseSalary());
        }
    }
   
}
