using System;

namespace EmployWageComputationProblem
{
    public class EmployWage 
    {
        public static int dailyEmployWage;
        public const int fullDayHours = 8;
        public const int  empWagePerHour = 20;
        public static void CalculateEmpWage()
        {
           
            dailyEmployWage = empWagePerHour * fullDayHours;
            Console.WriteLine("Employ Daily Wage is :{0} ",+ dailyEmployWage);
            PartTimeEmployWage.findPartTimeWage();



        }


    }
}
