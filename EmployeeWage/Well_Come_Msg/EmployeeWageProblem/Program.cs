using System;

namespace Employee_Part_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is_Full_Time = 1;
            int Is_Part_Time = 2;
            int Emp_hr = 8;
            int salary;
            Random random = new Random();
            int EmpCheck = random.Next(0, 3);
            if (EmpCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is Full Time:");
                Emp_hr = 8;
            }
            else if (EmpCheck == Is_Part_Time)
            {
                Console.WriteLine("Employee is Part Time:");
                Emp_hr = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent:");
                Emp_hr = 0;
            }
            salary = Emp_hr * 20;
            Console.WriteLine("{0} is salary of employee", salary);
        }
    }
}

