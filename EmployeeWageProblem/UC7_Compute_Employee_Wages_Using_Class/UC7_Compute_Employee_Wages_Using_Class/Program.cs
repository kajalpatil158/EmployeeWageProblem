using System;

namespace UC7_Compute_Employee_Wages_Using_Class
{
    class Program
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        public const int Max_Working_Days = 20;
        public const int Working_Hr = 100;
        public static void Compute_Emp_Wages_Using_Class()
        {
            int Emp_Hr = 0;
            int TotalWorkingHr = 0;
            int TotalWorkingDays = 0;
            while (TotalWorkingHr <= Working_Hr && TotalWorkingDays <= Max_Working_Days)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int EmpCheck = random.Next(0, 3);
                switch (EmpCheck)
                {
                    case Is_Part_Time:
                        Emp_Hr = 4;
                        break;
                    case Is_Full_Time:
                        Emp_Hr = 8;
                        break;
                    default:
                        Emp_Hr = 0;
                        break;
                }

                int Total_Emp_Hr = Emp_Hr;
                Console.WriteLine("Total Employee Wage For Employee Is: " + Total_Emp_Hr);
            }
            int Total_Wage = Emp_Hr * Working_Hr;
            Console.WriteLine("Total Employee Wage For Employee Is: " + Total_Wage);

        }


        static void Main(string[] args)
        {
            Compute_Emp_Wages_Using_Class();
        }
    }
}
