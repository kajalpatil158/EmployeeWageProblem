using System;

namespace Employee_Wage_Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is_Full_Time = 1;
            int Is_Part_Time = 2;
            int Is_Absent = 0;
            int Emp_Rate_Per_hr = 20;
            int EmpHr = 8;
            int salary;
            Random random = new Random();
            int EmpCheck = random.Next(0, 3);
            switch (EmpCheck)
            {
                case 1:
                    EmpHr = 8;
                    Console.WriteLine("Employee is Full Time Present:");
                    salary = EmpHr * Emp_Rate_Per_hr;
                    Console.WriteLine("Salary of employee is: {0}", salary);
                    break;
                case 2:
                    EmpHr = 4;
                    Console.WriteLine("Employee is Part Time Present:");
                    salary = EmpHr * Emp_Rate_Per_hr;
                    Console.WriteLine("Salary of employee is: {0}", salary);
                    break;
                case 3:
                    Console.WriteLine("Employee is Absent:");
                    salary = 0;
                    Console.WriteLine("Salary of employee is: {0}", salary);
                    break;
            }
        }
    }
}
