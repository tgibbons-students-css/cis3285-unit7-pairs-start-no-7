﻿namespace AccountsForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.listBoxAccounts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWithDrawal = new System.Windows.Forms.Button();
            this.txtWithdrawalAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_RewardPts = new System.Windows.Forms.TextBox();
            this.lbl_RewardPts = new System.Windows.Forms.Label();
            this.listBox_AcctType = new System.Windows.Forms.ListBox();
            this.lbl_AcctType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(53, 51);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(100, 20);
            this.txtAccountName.TabIndex = 0;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(52, 145);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(100, 23);
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // listBoxAccounts
            // 
            this.listBoxAccounts.FormattingEnabled = true;
            this.listBoxAccounts.Location = new System.Drawing.Point(52, 212);
            this.listBoxAccounts.Name = "listBoxAccounts";
            this.listBoxAccounts.Size = new System.Drawing.Size(137, 147);
            this.listBoxAccounts.TabIndex = 2;
            this.listBoxAccounts.SelectedIndexChanged += new System.EventHandler(this.listBoxAccounts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Account Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current Accounts";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(378, 76);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 5;
            this.txtBalance.TextChanged += new System.EventHandler(this.txtBalance_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Account Balance";
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(344, 184);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(100, 20);
            this.txtDepositAmount.TabIndex = 7;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(255, 182);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 8;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Amount";
            // 
            // btnWithDrawal
            // 
            this.btnWithDrawal.Location = new System.Drawing.Point(255, 212);
            this.btnWithDrawal.Name = "btnWithDrawal";
            this.btnWithDrawal.Size = new System.Drawing.Size(75, 23);
            this.btnWithDrawal.TabIndex = 10;
            this.btnWithDrawal.Text = "Withdrawal";
            this.btnWithDrawal.UseVisualStyleBackColor = true;
            this.btnWithDrawal.Click += new System.EventHandler(this.btnWithDrawal_Click);
            // 
            // txtWithdrawalAmount
            // 
            this.txtWithdrawalAmount.Location = new System.Drawing.Point(344, 214);
            this.txtWithdrawalAmount.Name = "txtWithdrawalAmount";
            this.txtWithdrawalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtWithdrawalAmount.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Wells Fargo Account Creator";
            // 
            // txtBox_RewardPts
            // 
            this.txtBox_RewardPts.Location = new System.Drawing.Point(255, 77);
            this.txtBox_RewardPts.Name = "txtBox_RewardPts";
            this.txtBox_RewardPts.Size = new System.Drawing.Size(100, 20);
            this.txtBox_RewardPts.TabIndex = 13;
            this.txtBox_RewardPts.TextChanged += new System.EventHandler(this.txtBox_RewardPts_TextChanged);
            // 
            // lbl_RewardPts
            // 
            this.lbl_RewardPts.AutoSize = true;
            this.lbl_RewardPts.Location = new System.Drawing.Point(255, 57);
            this.lbl_RewardPts.Name = "lbl_RewardPts";
            this.lbl_RewardPts.Size = new System.Drawing.Size(76, 13);
            this.lbl_RewardPts.TabIndex = 14;
            this.lbl_RewardPts.Text = "Reward Points";
            // 
            // listBox_AcctType
            // 
            this.listBox_AcctType.FormattingEnabled = true;
            this.listBox_AcctType.Items.AddRange(new object[] {
            "Silver",
            "Gold",
            "Platinum"});
            this.listBox_AcctType.Location = new System.Drawing.Point(52, 96);
            this.listBox_AcctType.Name = "listBox_AcctType";
            this.listBox_AcctType.Size = new System.Drawing.Size(120, 43);
            this.listBox_AcctType.TabIndex = 15;
            this.listBox_AcctType.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbl_AcctType
            // 
            this.lbl_AcctType.AutoSize = true;
            this.lbl_AcctType.Location = new System.Drawing.Point(49, 80);
            this.lbl_AcctType.Name = "lbl_AcctType";
            this.lbl_AcctType.Size = new System.Drawing.Size(122, 13);
            this.lbl_AcctType.TabIndex = 16;
            this.lbl_AcctType.Text = "Account Type (Select 1)";
            this.lbl_AcctType.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 385);
            this.Controls.Add(this.lbl_AcctType);
            this.Controls.Add(this.listBox_AcctType);
            this.Controls.Add(this.lbl_RewardPts);
            this.Controls.Add(this.txtBox_RewardPts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWithdrawalAmount);
            this.Controls.Add(this.btnWithDrawal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtDepositAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAccounts);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.txtAccountName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.ListBox listBoxAccounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnWithDrawal;
        private System.Windows.Forms.TextBox txtWithdrawalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_RewardPts;
        private System.Windows.Forms.Label lbl_RewardPts;
        private System.Windows.Forms.ListBox listBox_AcctType;
        private System.Windows.Forms.Label lbl_AcctType;
    }
}

