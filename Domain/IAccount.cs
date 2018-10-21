using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IAccount
    {
        // removed public
        decimal Balance { get; set; }

        // removed public
        int RewardPoints { get; set; }

        // removed public
        void AddTransaction(decimal amount, String typeOfTranscation);

        ///remove public abstract from the declaration
        /// <summary>
        /// Implemented in the child classes
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        int CalculateRewardPoints(decimal amount);
    }
}
