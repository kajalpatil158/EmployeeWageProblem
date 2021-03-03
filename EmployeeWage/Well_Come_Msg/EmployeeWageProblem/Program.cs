using System;

namespace Calculate_Wages_For_Month
{
    class Program
    {
        static void Main(string[] args)
        {
            int salary;
            //int Is_Full_Time = 1;
            //int Is_Part_Time = 2;
            Random random = new Random();
            int EmpCheck = random.Next(0, 3);
            int Working_Day = 20;
            int EmpHr = 8;
            int i;
            //int EmpCheck = random.Next(0, 3);
            //for (i=1;i<=Working_Day;i++)
            if (EmpCheck == 1)
            {

                EmpHr = 8;
                Console.WriteLine("Employee is full time");

            }
            else if (EmpCheck == 2)
            {

                EmpHr = 4;
                Console.WriteLine("Employee is Part time");

            }
            else
            {
                EmpHr = 0;
                Console.WriteLine("Employee is Absent:");
            }
            salary = EmpHr * Working_Day;
            Console.WriteLine("Employee Working salary for month is {0}", salary);
        }
    }
}
