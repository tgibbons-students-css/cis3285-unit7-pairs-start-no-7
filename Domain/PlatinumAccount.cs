using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    // changed AccountBase to IAccount interface
    internal class PlatinumAccount : IAccount
    {
        /// <summary>
        /// removed override from declaration
        /// 1 point for each $2 deposited
        /// 1 point for each $1,000 in account balance
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int CalculateRewardPoints(decimal amount)
        {
            return Math.Max((int)decimal.Ceiling((Balance / PlatinumBalanceCostPerPoint) + (amount / PlatinumTransactionCostPerPoint)), 0);
        }

        /// <summary>
        /// Pulled from AccountBase
        /// Used to add a deposit or subtract a withdrawal from
        /// the account. Withdrawals will have negative amount
        /// </summary>
        /// <param name="amount"></param>
        public void AddTransaction(decimal amount, String typeOfTransaction)
        {
            /*
            // only award reward points on deposit
            if (amount > 0) RewardPoints += CalculateRewardPoints(amount);
            // always update balance
            Balance += amount;
            */
            if (Equals(typeOfTransaction, "deposit"))
            {
                if (amount > 0)
                {
                    RewardPoints += CalculateRewardPoints(amount);
                    // always update balance
                    Balance += amount;
                }
            }
            else if (Equals(typeOfTransaction, "withdrawal"))
            {

                Balance += amount;
            }
        }

        private const int PlatinumTransactionCostPerPoint = 2;
        private const int PlatinumBalanceCostPerPoint = 1000;

        /// <summary>
        /// replace the balance method found in AccountBase
        /// </summary>
        public decimal Balance {
            get;
            set;
        }

        /// <summary>
        /// replaces the rewardPoints method found in AccountBase
        /// </summary>
        public int RewardPoints {
            get;
            set;
        }
    }
}
