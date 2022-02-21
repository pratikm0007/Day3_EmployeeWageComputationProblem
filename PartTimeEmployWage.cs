using System;

namespace EmployWageComputationProblem
{
    public class PartTimeEmployWage
    {
        public static void findPartTimeWage()
        {
            int isPartTimeEmployWage;
            int isPartTimeHrs = 8;
            isPartTimeEmployWage = EmployWage.empWagePerHour * isPartTimeHrs;
            Console.WriteLine("Part Time Employ Wage is : {0}",+ isPartTimeEmployWage);
            MonthlyWage.findMonthlyWage();
        }
    }
}
