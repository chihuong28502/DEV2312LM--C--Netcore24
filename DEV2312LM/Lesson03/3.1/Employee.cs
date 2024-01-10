using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    internal class Employee
    {
        double full = 0;
        public void GetIncome(double salaryLevel, double basicSalary) {
            full = salaryLevel * basicSalary;
            Console.WriteLine("GetIncome :");
        } 
        public void Display(int id, string name , int yearOfBirth, double salaryLevel, double basicSalary)
        {
            full = salaryLevel * basicSalary;
            Console.WriteLine("id: {0} | name: {1} | year: {2} | level: {3} | salary: {4}", id, name, yearOfBirth, full);

        }
    }
}
