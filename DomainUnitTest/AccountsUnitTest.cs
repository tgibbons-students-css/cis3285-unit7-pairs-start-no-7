using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain;

namespace DomainUnitTest
{
    [TestClass]
    public class AccountsUnitTest
    {
        /// <summary>
        /// AccountFactory use to be AccountBase
        /// testAccount is now an IAccount
        /// </summary>
        [TestMethod]
        public void CreateSilverAccountSetsBalanceToZero()
        {
            // Arrange    
            IAccount testAccount = AccountFactory.CreateAccount(AccountType.Silver);
            // Act
            decimal balance = testAccount.Balance;
            // Assert
            Assert.AreEqual(balance, 0.00M);
        }
        [TestMethod]
        public void DepositToSilverAccountBalance()
        {
            // Arrange    
            IAccount testAccount = AccountFactory.CreateAccount(AccountType.Silver);
            // Act
            testAccount.AddTransaction(+123.45M, "deposit");
            decimal balance = testAccount.Balance;
            // Assert
            Assert.AreEqual(balance, +123.45M);
        }
        /// <summary>
        /// Created to test Gold Account creation, did not fail when I first created
        /// </summary>
        [TestMethod]
        public void CreateGoldAccountSetsBalanceToZero()
        {
            // Arrange    
            IAccount testAccount = AccountFactory.CreateAccount(AccountType.Gold);
            // Act
            decimal balance = testAccount.Balance;
            // Assert
            Assert.AreEqual(balance, 0.00M);
        }
        /// <summary>
        /// Created to test deposit into Gold account, did not fail when I first created it. 
        /// </summary>
        [TestMethod]
        public void DepositToGoldAccountBalance()
        {
            // Arrange    
            IAccount testAccount = AccountFactory.CreateAccount(AccountType.Gold);
            // Act
            testAccount.AddTransaction(+123.45M, "deposit");
            decimal balance = testAccount.Balance;
            // Assert
            Assert.AreEqual(balance, +123.45M);
        }
        /// <summary>
        /// Created to test Platinum account, did not fail when I first created it
        /// </summary>
        [TestMethod]
        public void CreatePlatinumAccountSetsBalanceToZero()
        {
            // Arrange    
            IAccount testAccount = AccountFactory.CreateAccount(AccountType.Platinum);
            // Act
            decimal balance = testAccount.Balance;
            // Assert
            Assert.AreEqual(balance, 0.00M);
        }
        /// <summary>
        /// Created to test Platinum account, did not fail when I first created it.
        /// </summary>
        [TestMethod]
        public void DepositToPlatinumAccountBalance()
        {
            // Arrange    
            IAccount testAccount = AccountFactory.CreateAccount(AccountType.Platinum);
            // Act
            testAccount.AddTransaction(+123.45M, "deposit");
            decimal balance = testAccount.Balance;
            // Assert
            Assert.AreEqual(balance, +123.45M);
        }
        // testing for negative deposit
        /// <summary>
        /// made changes to the AddTransaction method, it now takes in a second parameter
        /// the type of transaction (withdrawal/deposit) and will check this in the account class
        /// </summary>
        [TestMethod]
        public void NegativeDepositToAccountBalance()
        {
            // Arrange    
            IAccount testAccount = AccountFactory.CreateAccount(AccountType.Silver);
            // Act
            testAccount.AddTransaction(-123.45M, "deposit");
            decimal balance = testAccount.Balance;
            // Assert
            Assert.AreEqual(balance, 0);
        }
        [TestMethod]
        public void WithdrawalToAccountBalance()
        {
            // Arrange    
            IAccount testAccount = AccountFactory.CreateAccount(AccountType.Silver);
            // Act
            testAccount.AddTransaction(+200M, "deposit");
            testAccount.AddTransaction(-100M, "withdrawal");
            decimal balance = testAccount.Balance;
            // Assert
            Assert.AreEqual(balance, +100M);
        }



        [TestMethod]
        public void NegativeBalanceAllowed()
        {
            // Arrange    
            IAccount testAccount = AccountFactory.CreateAccount(AccountType.Silver);
            // Act
            testAccount.AddTransaction(+200M, "deposit");
            testAccount.AddTransaction(-500M, "withdrawal");
            decimal balance = testAccount.Balance;
            // Assert
            Assert.AreEqual(balance, -300M);
        }

        ///
        ///   =================== Reward Points
        ///
        [TestMethod]
        public void RewardPoints_Silver_Deposit()
        {
            // Arrange    
            IAccount testAccount = AccountFactory.CreateAccount(AccountType.Silver);
            // Act
            testAccount.AddTransaction(1000M, "deposit");
            testAccount.AddTransaction(1000M, "deposit");
            int points = testAccount.RewardPoints;
            // Assert
            Assert.AreEqual(points, 200);
        }
        [TestMethod]
        public void RewardPoints_Silver_Withdrawal()
        {
            // Arrange    
            IAccount testAccount = AccountFactory.CreateAccount(AccountType.Silver);
            // Act
            testAccount.AddTransaction(1000M, "deposit");
            testAccount.AddTransaction(1000M, "deposit");
            testAccount.AddTransaction(-1000M, "withdrawal");
            int points = testAccount.RewardPoints;
            // Assert
            Assert.AreEqual(points, 200);
        }
        [TestMethod]
        public void RewardPoint_Gold_Deposit()
        {
            // Arrange    
            IAccount testAccount = AccountFactory.CreateAccount(AccountType.Gold);
            // Act
            testAccount.AddTransaction(4000M, "deposit");
            testAccount.AddTransaction(4000M, "deposit");
            int points = testAccount.RewardPoints;
            // Assert
            Assert.AreEqual(points, 800 + 2 + 800);
        }
        [TestMethod]
        public void RewardPoints_Gold_Withdrawal()
        {
            // Arrange    
            IAccount testAccount = AccountFactory.CreateAccount(AccountType.Gold);
            // Act
            testAccount.AddTransaction(4000M, "deposit");
            testAccount.AddTransaction(4000M, "deposit");
            testAccount.AddTransaction(-1000M, "withdrawal");
            int points = testAccount.RewardPoints;
            // Assert
            Assert.AreEqual(points, 800 + 2 + 800);
        }
        [TestMethod]
        public void RewardPoints_Platinum_Deposit()
        {
            // Arrange    
            IAccount testAccount = AccountFactory.CreateAccount(AccountType.Platinum);
            // Act
            testAccount.AddTransaction(4000M, "deposit");
            testAccount.AddTransaction(4000M, "deposit");
            int points = testAccount.RewardPoints;
            // Assert
            Assert.AreEqual(points, 2000 + 4 + 2000);
        }
        [TestMethod]
        public void RewardPoints_Platinum_Withdrawal()
        {
            // Arrange    
            IAccount testAccount = AccountFactory.CreateAccount(AccountType.Platinum);
            // Act
            testAccount.AddTransaction(4000M, "deposit");
            testAccount.AddTransaction(4000M, "deposit");
            testAccount.AddTransaction(-1000M, "withdrawal");
            int points = testAccount.RewardPoints;
            // Assert
            Assert.AreEqual(points, 2000 + 4 + 2000);
        }
    }
}
