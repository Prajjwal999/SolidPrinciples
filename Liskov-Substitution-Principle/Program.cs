using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    public class Employee
    {
        public virtual int calculateSalary()
        {
            return 10000;
        }
        public virtual int calculateBonus()
        {
            return 5000;
        }
    }
    public class permanentEmployee: Employee
    {
        public virtual int calculateSalary()
        {
            return 20000;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            permanentEmployee pEmployee= new permanentEmployee();
            Console.WriteLine(employee.calculateSalary());
            Console.WriteLine(employee.calculateBonus());
            Console.WriteLine(pEmployee.calculateSalary());
            Console.WriteLine(pEmployee.calculateBonus());
        }
    }
}
