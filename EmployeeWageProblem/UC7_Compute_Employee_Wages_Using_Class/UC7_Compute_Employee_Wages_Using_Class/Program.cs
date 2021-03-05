using System;

namespace UC7_Compute_Employee_Wages_Using_Class
{
    public class Compute_Employee_Wages_Using_Class
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        //public const int Max_Working_Days = 20;
        //public const int Working_Hr = 100;
        private string Company;
        private int Emp_Rate_Per_Hr;
        private int Max_Working_Days;
        private int Working_Hr;
        private int Total_Wage;
     public Compute_Employee_Wages_Using_Class(string Company, int Emp_Rate_Per_Hr, int Max_Working_Days, int Working_Hr)
        {
            this.Company = Company;
            this.Emp_Rate_Per_Hr = Emp_Rate_Per_Hr;
            this.Max_Working_Days = Max_Working_Days;
            this.Working_Hr = Working_Hr;
        }
        public void ComputeEmpWage()
        {
            int Emp_Hr = 0;
            int TotalWorkingHr = 0;
            int TotalWorkingDays = 0;
            while (TotalWorkingHr <= this.Working_Hr && TotalWorkingDays <= this.Max_Working_Days)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int EmpCheck = random.Next(0, 3);
                //int Emp_Hr = 0;
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

                int Total_Emp_Hr = +Emp_Hr;
                Console.WriteLine("Total Employee Wage For Employee Is: " + Total_Emp_Hr);

               int Total_Wage = Emp_Hr * this.Emp_Rate_Per_Hr;
               Console.WriteLine("Total Emp Wage For Company " + Company + " Is: " + Total_Wage);
                //return Total_Wage;
               
            }
            
        }
        public string tostring()
        {
            return ("Total Emp Wage For Company" + this.Company + "Is:" + this.Total_Wage);
        }
        static void Main(string[] args)
        {
            Compute_Employee_Wages_Using_Class Dmart = new Compute_Employee_Wages_Using_Class("Dmart", 20, 2, 10);
            Compute_Employee_Wages_Using_Class Reliance = new Compute_Employee_Wages_Using_Class("Reliance", 10, 5, 50);

            //UC7_Compute_Employee_Wages_Using_Class("Dmart", 20, 2, 10);
            //UC7_Compute_Employee_Wages_Using_Class("Reliance", 30, 4, 20);
            Dmart.ComputeEmpWage();
            Console.WriteLine(Dmart.tostring());
            Reliance.ComputeEmpWage();
            Console.WriteLine(Reliance.tostring());

        }

    }
}

  