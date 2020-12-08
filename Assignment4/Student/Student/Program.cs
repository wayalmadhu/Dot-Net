using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student

{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter how many Student you want to add");
            int size = Convert.ToInt32(Console.ReadLine());
            Student[] A = new Student[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter Student Roll_Number");
                int RollNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name");
                String Name = (Console.ReadLine());
                Console.WriteLine("Enter Student Marks");
                decimal Marks = Convert.ToDecimal(Console.ReadLine());


                Student E = new Student(RollNo, Name, Marks);
                A[i] = E;

            }
            Console.WriteLine("Details of Student***************");
            for (int i = 0; i < A.Length; i++)
            {
                A[i].show();
            }

            Console.ReadLine();
        }


    }
    struct Student
    {
        public int rollNo;
        public string name;
        public decimal marks;

        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value < 150 && value > 0)
                {
                    rollNo = value;
                }
                else
                {
                    Console.WriteLine("Invalid roll no");
                }

            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Invalid Name");
                }
                else
                {
                    name = value;
                }
            }

        }
        public decimal Marks
        {
            get { return marks; }
            set
            {
                if (value <= 100 && value >= 0)
                {
                    marks = value;
                }
                else
                {
                    Console.WriteLine("Enter correct data");
                }

            }

        }

        public Student(int RollNo, string Name, decimal Marks) : this()
        {
            this.RollNo = RollNo;
            this.Name = Name;
            this.Marks = Marks;
        }

        public void show()
        {
            // Console.WriteLine( "Show method");
            Console.WriteLine("Student No:" + RollNo);
            Console.WriteLine("Student Name:" + Name);
            Console.WriteLine("Student Marks:" + Marks);

            Console.WriteLine("*********************************************************");
        }


    }

}
