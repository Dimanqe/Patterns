using Patterns.Accounts;

namespace Patterns.InterestCalculators
{
    public class StandardInterestCalculator : IInterestCalculator
    {
        public double CalculateInterest(Account account)
        {
            double interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                interest -= account.Balance * 0.2;

            if (account.Balance >= 1000)
                account.Interest -= account.Balance * 0.4;

            return interest;
        }
    }
}
