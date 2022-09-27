using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace string_overiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Employee emp = new Employee() { EmpId = 1, EmpName = "Diptesh", DeptName = "Moback" };
                Console.WriteLine(emp.ToString());
                Console.ReadLine();

            }
        }

        public class Employee
        {
            public int EmpId { get; set; }
            public string EmpName { get; set; } //The get method returns the value of the variable name.

           //he set method assigns a value to the name variable.The value keyword represents the value we assign to the property.
            public string DeptName { get; set; }

            public override string ToString()
            {
                return this.EmpId + " " + this.EmpName + " " + this.DeptName;
            }
        }
    }
}
