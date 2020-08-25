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
                throw new ArgumentException(nameof(amount), "Deposit amount must be positive!");
            }

            var newBalance = Balance + amount;

            if (newBalance > 1000)
            {
                throw new ArgumentException(nameof(amount), "Account cannot have a balance more than $1,000!");
            }

            Balance = newBalance;
        }
    }
}
