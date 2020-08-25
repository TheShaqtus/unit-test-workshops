using System;
using Accounts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AccountsTests
{
    [TestClass]
    public class CheckingAccountTests
    {
        [TestMethod]
        public void Withdraw__Given_AccountBalanceIs90__When_10DollarsAreWithdrawn__Then_AccountBalanceShouldBe80()
        {
            // Arrange
            const string testAccountHolder = "Joe Test";
            const double startingBalance = 90.0;
            const double withdrawal = 10.0;
            const double expectedBalance = 80.0;
            var account = new CheckingAccount(testAccountHolder, startingBalance);

            // Act
            account.Withdraw(withdrawal);

            // Assert
            Assert.AreEqual(expectedBalance, account.Balance);
        }

        [TestMethod]
        public void Withdraw__Given_AccountBalanceIs10__When_11DollarsAreWithdrawn__Then_PreventsWithdrawalFromCompleting()
        {
            // Arrange
            const string testAccountHolder = "Joe Test";
            const double startingBalance = 10.0;
            const double withdrawal = 11.0;
            var account = new CheckingAccount(testAccountHolder, startingBalance);

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => account.Withdraw(withdrawal));
            Assert.AreEqual(startingBalance, account.Balance);
        }

        [TestMethod]
        public void Withdraw__Given_AccountBalanceIs90__When_Negative80DollarsAreWithdrawn__Then_PreventsWithdrawalFromCompleting()
        {
            // Arrange
            const string testAccountHolder = "Joe Test";
            const double startingBalance = 90.0;
            const double withdrawal = -80.0;
            var account = new CheckingAccount(testAccountHolder, startingBalance);

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => account.Withdraw(withdrawal));
            Assert.AreEqual(startingBalance, account.Balance);
        }

        [TestMethod]
        public void Deposit__Given_AccountBalanceIs0__When_10DollarsAreDeposited__Then_AccountBalanceShouldBe10()
        {
            // Arrange
            const string testAccountHolder = "Joe Test";
            const double startingBalance = 0.0;
            const double deposit = 10.0;
            const double expectedBalance = 10.0;
            var account = new CheckingAccount(testAccountHolder, startingBalance);

            // Act
            account.Deposit(deposit);

            // Arrange
            Assert.AreEqual(expectedBalance, account.Balance);
        }

        [TestMethod]
        public void Deposit__Given_AccountBalanceIs10__When_Negative10DollarsAreDeposited__Then_PreventsDepositFromCompleting()
        {
            // Arrange
            const string testAccountHolder = "Joe Test";
            const double startingBalance = 10.0;
            const double deposit = -10.0;
            var account = new CheckingAccount(testAccountHolder, startingBalance);

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => account.Deposit(deposit));
            Assert.AreEqual(startingBalance, account.Balance);
        }

        [TestMethod]
        public void Deposit__Given_AccountBalanceIs990__When_11DollarsAreDeposited__Then_PreventsDepositFromCompleting()
        {
            // Arrange
            const string testAccountHolder = "Joe Test";
            const double startingBalance = 990;
            const double deposit = 11;
            var account = new CheckingAccount(testAccountHolder, startingBalance);

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => account.Deposit(deposit));
            Assert.AreEqual(startingBalance, account.Balance);
        }
    }
}
