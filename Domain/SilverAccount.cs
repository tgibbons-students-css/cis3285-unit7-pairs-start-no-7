using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    // changed AccountBase to IAccount interface
    internal class SilverAccount : IAccount
    {
        /// <summary>
        /// removed override in declaration
        /// 1 point for each $10 deposited
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int CalculateRewardPoints(decimal amount)
        {
            return (int)decimal.Floor(amount / SilverTransactionCostPerPoint);
        }

        /// <summary>
        /// Pulled from AccountBase
        /// Used to add a deposit or subtract a withdrawal from
        /// the account. Withdrawals will have negative amount
        /// </summary>
        /// <param name="amount"></param>
        public void AddTransaction(decimal amount)
        {
            // only award reward points on deposit
            if (amount > 0) RewardPoints += CalculateRewardPoints(amount);
            // always update balance
            Balance += amount;
        }

        private const int SilverTransactionCostPerPoint = 10;

        /// <summary>
        /// replace the balance method found in AccountBase
        /// </summary>
        public decimal Balance
        {
            get;
            set;
        }

        /// <summary>
        /// replaces the rewardPoints method found in AccountBase
        /// </summary>
        public int RewardPoints
        {
            get;
            set;
        }
    }
}
