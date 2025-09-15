using System;

namespace LoanInterestMoney
{
    class Program
    {
        public static string in_put()
        {
            bool success = false;
            string x = "";
            while (!success)
            {
                x = Console.ReadLine();
                if (double.TryParse(x, out double result))
                {
                    Console.WriteLine("Input is valid.");
                    success = true;
                }
                else
                {
                    Console.WriteLine("Input is invalid. Please enter a valid number:");
                }
            }
            return x;
        }
        static void Main(string[] args)
        {
            double LoanMoney, InterestRate, Month;
            Console.WriteLine("Program: Loan interest calculate application");
            Console.Write("Enter Loan Money: ");
            LoanMoney = Double.Parse( in_put());
            Console.Write("Enter Interest Rate per year: ");
            InterestRate = Double.Parse(in_put());
            Console.Write("Enter Month: ");
            Month = Double.Parse(in_put());
            // Calculate interest
            double InterestMoney = LoanMoney * InterestRate / 100 / 12 * Month;
            // Calculate total money
            double TotalMoney = LoanMoney + InterestMoney;
            //
            Console.WriteLine("Total Money" + TotalMoney);
        }
    }
}