using Patterns.Accounts;

namespace Patterns
{
    public interface IInterestCalculator
    {
        double CalculateInterest(Account account);
    }
}
