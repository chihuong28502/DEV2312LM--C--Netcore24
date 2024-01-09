using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    /// <summary>
    ///  Tạo lớp đối tượng Employee
    ///  tạo các thuộc tính tự động id , full name,salary
    ///  Phương thức printInfo
    /// </summary>
    internal class Employees
    {
        public int Id { get; set; }
        public string FullName { get; set; }    
        public int Salary { get; set; }
        public Employees (int Id,string FullName, int Salary)
        {
            // constructor
            this.Id = Id;
            this.FullName = FullName;
            this.Salary = Salary;
        }
        public Employees()
        {

        }
        public void PrintInfo()
        {
            Console.WriteLine("Id: {0}",Id);
            Console.WriteLine("Name: {0}",FullName);
            Console.WriteLine("Salary: {0}",Salary);
        }
    }
}
