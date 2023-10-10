namespace Patterns.Accounts
{
    public class Account
    {
        public string Type { get; set; }
        public double Balance { get; set; }
        public double Interest { get; set; }

        public Account(string type, double balance, double interest)
        {
            Type = type;
            Balance = balance;
            Interest = interest;
        }
    }
}
