using Patterns.Accounts;
using Patterns.InterestCalculators;
using System;

namespace Patterns
{
    class Program
    {

        public static class Calculator
        {
            public static void CalculateInterest(Account account, IInterestCalculator interestCalculator)
            {
                account.Interest = interestCalculator.CalculateInterest(account);
            }
        }
        static void Main()
        {
            Account regularAccount = new StandardAccount(1500);

            Account salaryAccount = new SalaryAccount(800);

            IInterestCalculator regularInterestCalculator = new RegularInterestCalculator();
            IInterestCalculator salaryInterestCalculator = new SalaryInterestCalculator();

            Calculator.CalculateInterest(regularAccount, regularInterestCalculator);
            Console.WriteLine($"Interest for {regularAccount.Type} account: {regularAccount.Interest}%");

            Calculator.CalculateInterest(salaryAccount, salaryInterestCalculator);
            Console.WriteLine($"Interest for {regularAccount.Type} account: {salaryAccount.Interest}%");

            Console.ReadLine();
        }
    }
}
