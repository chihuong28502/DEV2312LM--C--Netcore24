using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson06
{
    internal class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpPhone{ get; set; }
        public double EmpSalary { get; set; }

        public Employee() { }

        public Employee(int empID,string empName,string empPhone,double empSalary) {
            EmpID = empID;
            EmpName = empName;
            EmpPhone = empPhone;
            EmpSalary = empSalary;
        }
        public override string ToString()
        {
            return string.Format("{0,-5} {1,-15} {2,-15} {3:#,##0.#0}",EmpID,EmpName,EmpPhone,EmpSalary);
        }

    }
}
