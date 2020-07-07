using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectATM
{
    class CheckingAccount
    {
        #region Properties
        public string Number { get; }
        public string Owner { get; set; }
        public decimal CheckingBalance
        {
            get
            {
                decimal checkingBalance = 0;
                foreach (var transaction in allTransactions)
                {
                    checkingBalance += transaction.Amount;
                }
                return checkingBalance;
            }
        }

        private static int accountNumberSeed = 12345678;

        private List<Transaction> allTransactions = new List<Transaction>();
        #endregion

        #region Constructors
        public CheckingAccount() { } 
        public CheckingAccount(string name, decimal initialBalance)
        {
            Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "First deposit!");
            Number = ("NL11 INGB " + accountNumberSeed.ToString());
            accountNumberSeed++;
        }
        #endregion

        #region Methods
        public void MakeDeposit(decimal amount, DateTime transactionDate, string transactionDetails)
        {
            if (amount <= 0)
            {
                throw new ArgumentException(
                    "\n+++++++++++++++++++++++++++++++++++" +
                    "\nAmount of deposit must be positive." +
                    "\n+++++++++++++++++++++++++++++++++++");
            }
            var deposit = new Transaction(amount, transactionDate, transactionDetails);
            allTransactions.Add(deposit);
        }

        public void MakeWithdraw(decimal amount, DateTime transactionDate, string transactionDetails)
        {
            if (amount <= 0)
            {
                throw new ArgumentException(
                    "\n++++++++++++++++++++++++++++++++++++++" +
                    "\nAmount of withdrawal must be positive." +
                    "\n++++++++++++++++++++++++++++++++++++++");
            }
            if ((CheckingBalance - amount) < 0)
            {
                throw new ArgumentException(
                    "\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                    "\nNot sufficient funds for this withdrawal" +
                    "\nThe current balance on your account is " + CheckingBalance +
                    "\nPlease try to withdraw an amount that is equal to or less than your balance!" +
                    "\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            var withdrawel = new Transaction(-amount, transactionDate, transactionDetails);
            allTransactions.Add(withdrawel);
        }


        public string GetTransactions()
        {
            var transactionsReport = new StringBuilder();
            transactionsReport.AppendLine("Checking Account Transactions:\nID\t\tDate\t\t\tAmount\t\tTransaction Details");
            foreach (var transaction in allTransactions)
            {
                transactionsReport.AppendLine($"{transaction.ID}\t\t{transaction.TransactionDate.ToShortDateString()}\t\t{ transaction.Amount}\t\t{transaction.TransactionDetails}");

            }
            return transactionsReport.ToString();
        }
        #endregion
    }
}
