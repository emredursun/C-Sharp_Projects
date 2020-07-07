using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectATM
{
    class Transaction
    {
        #region Properties
        public int ID { get; }
        public decimal Amount { get; }
        public DateTime TransactionDate { get; }
        public string TransactionDetails { get; }
        private static int count = 1;
        #endregion

        #region Constructors
        public Transaction(decimal amount, DateTime transactionDate, string transactionDetails)
        {
            Amount = amount;
            TransactionDate = transactionDate;
            TransactionDetails = transactionDetails;
            ID = count;
            count++;
        }

        public Transaction()
        {
        }
        #endregion
    }
}
