using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEquatable_Implementation
{
    class Employee : IEquatable<Employee>
    { 
        public int eno { get; set; }
        public string ename { get; set; }
        public double age { get; set; }
        public bool Equals(Employee other)
        {
            return this.ename.Equals(other.ename) && this.eno.Equals(other.eno) && this.age.Equals(other.age);
        }


    }
   
   
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee { eno = 5, ename = "Arun", age=23 };
            Employee e2 = new Employee { eno = 10, ename = "Pranay",age=25  };
            Employee e3 = new Employee { eno = 1, ename = "Zuubair", age=22 };
            List<Employee> el1 = new List<Employee> { e1, e2, e3 };
            Employee e4 = new Employee { eno = 5, ename = "Arun", age = 23 };
            Employee e5 = new Employee { eno = 10, ename = "Pranay", age = 25 };
            Employee e6 = new Employee { eno = 1, ename = "Zubair", age = 22 };
            List<Employee> el2 = new List<Employee> { e3, e4, e5 };
            if (el1.Contains(e2))
                Console.WriteLine("Record exists");
            else
                Console.WriteLine("No such record ");
            if (el2.SequenceEqual(el1))
                Console.WriteLine("Both lists are same");
            else
                Console.WriteLine("Both are different lists");
            Console.ReadKey();
        }
    }
       
}
