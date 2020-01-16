using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class MonthlyPayment
    {
        public static void MonthlyPaymentInput()
        {
            try
            {
                Console.WriteLine("Enter The principal Loan amount:");
                int loan = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the yers to pay of loan");
                int years = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the rate percent interest");
                Double rate = Convert.ToDouble(Console.ReadLine());
                double monthlypayment = Utility.MonthlyPaymentCalculator(loan, years, rate);
                Console.WriteLine("Monthly payment:" + monthlypayment);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
