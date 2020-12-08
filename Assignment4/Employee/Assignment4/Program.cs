using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many employee you want : ");
            int size = Convert.ToInt32(Console.ReadLine());
            Employee[] E = new Employee[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter empId = ");
                int EmpId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter emp Name = ");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter emp salary = ");
                decimal Salary = Convert.ToDecimal(Console.ReadLine());


                Employee emp = new Employee(EmpId, Name, Salary);
                E[i] = emp;
            }
            Console.WriteLine("**********************Display of Employee***************************");
            for(int i= 0; i<E.Length; i++ )
            {
                E[i].show();
            }
            Console.WriteLine("***********************Maximum Salary*********************************");
            decimal high = E[0].Salary;

            for (int i = 0; i < E.Length; i++)
            {
                if (E[i].Salary > high)
                {
                    high = E[i].Salary;
                }
            }

            Console.WriteLine("Maximum Salary =" + high);
            for (int i = 0; i < E.Length; i++)
            {
                if (E[i].Salary == high)
                {
                    E[i].show();

                }
            }
            Console.Write("Enter employee number to search info of Employee:");
            int Find = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < E.Length; i++)
            {
                if (E[i].EmpId == Find)
                {
                    E[i].show();
                }
                else
                {
                    Console.WriteLine("Invalid Employee number.");
                }
            }

            Console.ReadLine();
        }


    }

    class Employee
    {
        public int EmpId;
        public string Name;
        public decimal Salary;

        public Employee(int EmpId, string Name, decimal Salary)
        {
            this.EmpId = EmpId;
            this.Name = Name;
            this.Salary = Salary;
        }
        public void show()
        {
            Console.WriteLine("EmpId = " + EmpId);
            Console.WriteLine("Emp Name = " + Name);
            Console.WriteLine("Employee Salary = " + Salary);
            Console.WriteLine("***************************************************************");
        }
    }
}
