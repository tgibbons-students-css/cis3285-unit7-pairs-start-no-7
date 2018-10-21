 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Services
{
    public class AccountService : IAccountServices
    {
        // store the accounts in a dictionary indexed by the account name
        private Dictionary<string, IAccount> accountsDictionary;

        /// <summary>
        /// instantiate the dictionary for accounts
        /// </summary>
        public AccountService()
        {
            accountsDictionary = new Dictionary<string, IAccount>();
        }
        /// <summary>
        /// create a new account
        /// </summary>
        /// <param name="accountName"></param>
        /// <param name="accountType"></param>
        public void CreateAccount(string accountName, AccountType accountType)
        {
            IAccount newAccount = AccountFactory.CreateAccount(accountType);
            accountsDictionary.Add(accountName, newAccount);
        }
        /// <summary>
        /// find the balance of the given account
        /// </summary>
        /// <param name="accountName"></param>
        /// <returns></returns>
        public decimal GetAccountBalance(string accountName)
        {
            IAccount acc = FindAccount(accountName);
            return acc.Balance;
        }
        /// <summary>
        /// find the reward points of the given account
        /// </summary>
        /// <param name="accountName"></param>
        /// <returns></returns>
        public int GetRewardPoints(string accountName)
        {
            IAccount acc = FindAccount(accountName);
            return acc.RewardPoints;
        }
        /// <summary>
        /// deposit the given account into the account named
        /// </summary>
        /// <param name="accountName"></param>
        /// <param name="amount"></param>
        public void Deposit(string accountName, decimal amount)
        {
            /*
            if(amount > 0)
            {
                IAccount acc = FindAccount(accountName);
                acc.AddTransaction(amount);
            }
            */
            IAccount acc = FindAccount(accountName);
            acc.AddTransaction(amount, "deposit");

        }
        /// <summary>
        /// withdrawal the given account into the account named
        /// 
        /// Need to check for incoming negative amount, because it will be treated as 
        /// as withdrawal and this should not be allowed, the user should use the deposit button
        /// 
        /// </summary>
        /// <param name="accountName"></param>
        /// <param name="amount"></param>
        public void Withdrawal(string accountName, decimal amount)
        {
            IAccount acc = FindAccount(accountName);
            // check to make sure that the final amount isn't going to be a positive amount, because
            // it will signfy a deposit instead of a withdrawal
            if(amount > 0)
            {
                // for withdrawal, subtract amount
                acc.AddTransaction(-1*amount, "withdrawal");
            }
            
        }
        /// <summary>
        /// Look up the account by name in the dictionar
        /// </summary>
        /// <param name="accountName"></param>
        /// <returns>returns null if name not found</returns>
        /// 
        /// Refactor the code to implement the null object pattern 
        /// with accounts so that AccountServices:FindAccount() returns 
        /// a null account if one is not found. You will have to define 
        /// a new NullAccount class that implements the IAccount interface.
        private IAccount FindAccount(string accountName)
        {
            if (accountsDictionary.ContainsKey(accountName))
            {
                return accountsDictionary[accountName];
            }
            else
            {
                return new NullAccount();
            }
            
        }

    }
}
