using Domain;

namespace Services
{
    /// This class defines the Null Object pattern
    /// this will be used so we don't have to check for null object
    public class NullAccount : IAccount
    {
        // public decimal Balance { get { return 0; } set { } }
        //  public int RewardPoints { get { return 0; } set { } }

        public decimal Balance { get; set; }
        public int RewardPoints { get; set; }

        public void AddTransaction(decimal amount)
        {
            
        }

        public int CalculateRewardPoints(decimal amount)
        {
            return 0;
        }

    }
}