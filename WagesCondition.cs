using System;

namespace EmployWageComputationProblem
{
    public class WagesCondition
    {
        public static void calWageTillCondition()
        {
            int hrs = 101;
            int dayHrs = 20 * 8;
            int calculateWages1;
            int calculateWages2;
            for (int count = 1; count < hrs; count++)
            {
                
                calculateWages1 = count * EmployWage.empWagePerHour;
                Console.WriteLine("Total Working Hour wage for a Month is : {0}", +calculateWages1);
                if (count < dayHrs)
                {
                    calculateWages2 = count * EmployWage.empWagePerHour;
                    Console.WriteLine("Total Working Day wage for a Month is : {0}", +calculateWages2);
                    
                }
                
            }
        }
    }
}
