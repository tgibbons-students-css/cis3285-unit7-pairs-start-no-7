using Domain;
using Services;
using System;
using System.Windows.Forms;

namespace AccountsForms
{
    /// <summary>
    /// This is the main GUI form for the accounts
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// accService is the link to the accounts through the 
        /// IAccountServices interface
        /// </summary>
        IAccountServices accService = new AccountService();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Create a new account button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string accountName = txtAccountName.Text;
            string accType = listBox_AcctType.SelectedItem.ToString();
            listBoxAccounts.Items.Add(accountName);

            if (accType == "Platinum"){
                accService.CreateAccount(accountName, AccountType.Platinum);
            }
            else if(accType == "Gold")
            {
                accService.CreateAccount(accountName, AccountType.Gold);
            }
            else
            {
                accService.CreateAccount(accountName, AccountType.Silver);
            }
            
        }
        /// <summary>
        /// Account listbox item selected
        /// Find the account and update the balance displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string accName = listBoxAccounts.SelectedItem.ToString();
            decimal balance = accService.GetAccountBalance(accName);
            decimal rewards = accService.GetRewardPoints(accName);
            txtBalance.Text = balance.ToString();
            txtBox_RewardPts.Text = rewards.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            // this will get the account name found on the form
            String accountName = listBoxAccounts.GetItemText(listBoxAccounts.SelectedItem);

            // getting balance and deposti amount from form and then display the new balance on the form
            Decimal balance = Decimal.Parse(txtBalance.Text);
            Decimal deposit = Decimal.Parse(txtDepositAmount.Text);
            // if the deposit amount is negative, display a alert letting the user know that it is not allowed,
            // the balance and reward should not change 
            if(deposit < 0)
            {
                MessageBox.Show("You cannot make a negative deposit, please use the withdrawl button to do this transcation.");

            }
            else
            {
                txtBalance.Text = (balance + deposit).ToString();

                // this changes the deposit amount in the database, not the form
                accService.Deposit(accountName, deposit);

                // get the reward points from the DB and displays it on the form
                decimal points = accService.GetRewardPoints(accountName);
                txtBox_RewardPts.Text = points.ToString();
            }

        }

        private void btnWithDrawal_Click(object sender, EventArgs e)
        {
            // this will get the account name found on the form
            String accountName = listBoxAccounts.GetItemText(listBoxAccounts.SelectedItem);
            Decimal balance = Decimal.Parse(txtBalance.Text);
            Decimal withdrawal = Decimal.Parse(txtWithdrawalAmount.Text);

            if(withdrawal > 0)
            {
                txtBalance.Text = (balance - withdrawal).ToString();

                // this changes the deposit amount in the database, not the form
                accService.Withdrawal(accountName, withdrawal);

                // get the reward points from the DB and displays it on the form
                decimal points = accService.GetRewardPoints(accountName);
                txtBox_RewardPts.Text = points.ToString();
            }
            else
            {
                MessageBox.Show("You cannot make a negative withdrawal, this is also consider a deposit. " +
                    "If you want to make a deposit please use the deposit button. " +
                    "If you meant to make a withdrawl enter the amount without the negative sign.");
            }

            
        }

        private void txtBox_RewardPts_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
