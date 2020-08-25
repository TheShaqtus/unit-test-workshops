using System;

namespace Accounts
{
    public class CheckingAccount
    {
        public string AccountHolder { get; private set; }
        public double Balance { get; private set; }

        public CheckingAccount(string accountHolder, double currentBalance)
        {
            AccountHolder = accountHolder;
            Balance = currentBalance;
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                throw new ArgumentException(nameof(amount), "Withdrawal exceeds balance!");
            }
        }
    }
}
