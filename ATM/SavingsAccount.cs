using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectATM
{
    class SavingsAccount
    {
        #region Properties
        public decimal SavingBalance
        {
            get
            {
                decimal savingBalance = 0;
                foreach (var transaction in allTransactions)
                {
                    savingBalance += transaction.Amount;
                }
                return savingBalance;
            }
        }

        public double IntrestRate { get; }

        private List<Transaction> allTransactions = new List<Transaction>();
        #endregion

        #region Constructors
        public SavingsAccount(decimal initialSavingBalance)
        {
            MakeDeposit(initialSavingBalance, DateTime.Now, "First deposit!");
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
            if ((SavingBalance - amount) < 0)
            {
                throw new ArgumentException(
                    "\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" +
                    "\nNot sufficient funds for this withdrawal" +
                    "\nThe current balance on your saving account is " + SavingBalance +
                    "\nPlease try to withdraw an amount that is equal to or less than your balance!" +
                    "\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            var withdrawel = new Transaction(-amount, transactionDate, transactionDetails);
            allTransactions.Add(withdrawel);
        }


        public string GetTransactions()
        {
            var transactionsReport = new StringBuilder();
            transactionsReport.AppendLine("Savings Account Transactions:\nID\t\tDate\t\t\tAmount\t\tTransaction Details");
            foreach (var transaction in allTransactions)
            {
                transactionsReport.AppendLine($"{transaction.ID}\t\t{transaction.TransactionDate.ToShortDateString()}\t\t{ transaction.Amount}\t\t{transaction.TransactionDetails}");

            }
            return transactionsReport.ToString();
        }

        public void CalculateIntrest()
        {
            var numOfTransaction = new Transaction();
            
            while (numOfTransaction.ID % 5 == 0)
            {
                Console.WriteLine("Interest calculated!");
                    var intrestDeposit = new Transaction(SavingBalance * Convert.ToDecimal(IntrestRate), DateTime.Now, "After five transactions the intrest for your SavingsAccount");
                    allTransactions.Add(intrestDeposit);
                Console.WriteLine($"After five transactions, the new balance for your SavingsAccount is {SavingBalance * Convert.ToDecimal(IntrestRate)}");
                Thread.Sleep(5000);
                //Console.WriteLine(
                //    $"\nYour Checking Account has {customer1Checking.CheckingBalance} Euro." +
                //    $"\nYour savings account has {customer1Saving.SavingBalance} Euro.");

            }
        }
        #endregion
    }
}
