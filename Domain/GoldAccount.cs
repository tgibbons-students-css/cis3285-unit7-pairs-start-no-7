using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    // Changed AccountBase to IAccount
    internal class GoldAccount : IAccount
    {
        /// <summary>
        /// 1 point for each $5 deposited
        /// 1 point for each $2,000 in account balance
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int CalculateRewardPoints(decimal amount)
        {
            return (int)decimal.Floor((Balance / GoldBalanceCostPerPoint) + (amount / GoldTransactionCostPerPoint));
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

        private const int GoldTransactionCostPerPoint = 5;
        private const int GoldBalanceCostPerPoint = 2000;

        /// <summary>
        /// replaces the balance found in AccountBase
        /// </summary>
        public decimal Balance
        {
            get;

            set;
        }

        /// <summary>
        /// replaces the reward points found in AccountBase
        /// </summary>
        public int RewardPoints
        {
            get;
            set;
        }
    }
}
