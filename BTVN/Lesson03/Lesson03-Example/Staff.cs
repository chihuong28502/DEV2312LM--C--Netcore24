using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03_Example
{
    internal class Staff:Person
    {
        public float Salary { get; set; }
        public Staff() { }
        public Staff(int id, string name, string address, string phone,float salary,float baseSalary)
            : base(id, name, address, phone, baseSalary)
        {
            Salary = salary;
        }
        public void prinInfo()
        {
            base.prinInfo();
            Console.WriteLine(
                "Salary: {0}",Salary
                );
        }
        // ghi đè method overriding (polymorphism)
        public override float GetBaseSalary()
        {
            return base.GetBaseSalary() + Salary;    
        }
        public override string ToString()
        {
            return string.Format("{0} | {1} | {2} | {3} | {4} "
               , Id, Name, Address, Phone, BaseSalary);
        }
    }
}
