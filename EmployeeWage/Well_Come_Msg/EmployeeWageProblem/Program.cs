using System;

namespace Employee_wage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wel Come To Employee Wages ");
            int Is_Present = 1;
            Random random = new Random();
            int EmpCheck = random.Next(0, 2);
            if (EmpCheck == Is_Present)
            {
                int Wage_Per_Hour = 20;
                int Full_Day = 8;
                //int Calculate_Emp_wage;
                int Salary = Full_Day * Wage_Per_Hour;
                Console.WriteLine("Employee is present:");
                Console.WriteLine("Salary of Employee is {0}: ", Salary);
            }
            else
            {
                int Salary = 0;
                Console.WriteLine("Employee is Absent and salary for that is {0}", Salary);

            }
        }
    }
}
