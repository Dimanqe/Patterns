using Patterns.Accounts;

namespace Patterns.InterestCalculators
{
    public class SalaryInterestCalculator : IInterestCalculator
    {
        public double CalculateInterest(Account account)
        {
            return account.Balance * 0.5;
        }
    }
}
