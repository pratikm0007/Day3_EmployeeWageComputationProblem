using System;

namespace EmployWageComputationProblem
{
    public class MonthlyWage
    {
        public const int WorkingDayPerMonth = 20;
        public static void findMonthlyWage()
        {
            int WagesOfMonth = WorkingDayPerMonth * EmployWage.dailyEmployWage;
            Console.WriteLine("Wages for a Month is {0}",+ WagesOfMonth);
            WagesCondition.calWageTillCondition();

        }
    }
}
