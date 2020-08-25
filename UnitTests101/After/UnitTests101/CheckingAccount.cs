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
            if (amount <= 0)
            {
                throw new ArgumentException(nameof(amount), "Withdrawal amount must be positive!");
            }
            
            if (Balance < amount)
            {
                throw new ArgumentException(nameof(amount), "Withdrawal exceeds balance!");
            }

            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException(nameof(amount), "Deposity amount must be positive!");
            }

            Balance += amount;
        }
    }
}
