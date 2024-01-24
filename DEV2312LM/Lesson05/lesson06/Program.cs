using System.Text;

namespace lesson06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Employee> employees = new List<Employee>() { 
                new Employee(1,"ten1","092312312",1),
                new Employee(2,"ten2","0923123133",2),
                new Employee(3,"ten3","0923123133",3),
                new Employee(4,"ten4","09231231444",4),
                new Employee(5,"ten5","09231231299",5),
            };
            foreach (var item in employees) {
            Console.WriteLine(item.ToString());
            }
            //sort
            //employees.Sort((x,y)=>
            //{
            //    return (int)(y.EmpSalary - x.EmpSalary);
            //});
            employees.Sort((x, y) =>
            {
                if(y.EmpSalary> x.EmpSalary)
                {
                    return -1;
                }else if(y.EmpSalary < x.EmpSalary)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            });
            foreach (var item in employees)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}