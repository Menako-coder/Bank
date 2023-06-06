using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class BankData : IPrint
    {
        private string accountNumber;
        private decimal moneyAvailable;
        private string lastProcessingDate;

        public BankData(string accountNumber, decimal moneyAvailable, string lastProcessingDate)
        {
            this.accountNumber = accountNumber;
            this.moneyAvailable = moneyAvailable;
            this.lastProcessingDate = lastProcessingDate;
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public decimal MoneyAvailable
        {
            get { return moneyAvailable; }
            set { moneyAvailable = value; }
        }

        public string LastProcessingDate
        {
            get { return lastProcessingDate; }
            set {  lastProcessingDate = value; }
        }

        public virtual void Print() { }


       
    }
}
