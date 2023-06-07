using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExam
{
    public abstract class BankData : IPrint
    {
        private int accountNumber;
        private decimal moneyAvailable;
        private string lastProcessingDate;

        public BankData(int accountNumber, decimal moneyAvailable, string lastProcessingDate)
        {
            this.accountNumber = accountNumber;
            this.moneyAvailable = moneyAvailable;
            this.lastProcessingDate = lastProcessingDate;
        }

        public BankData()
        {
        }

        public int AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Your account number should contains 4 symbols");
                }
                accountNumber = value;
            }
        }

        public decimal MoneyAvailable
        {
            get { return moneyAvailable; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("You can not have 0 or less money in your account");
                }
                moneyAvailable = value;
            }
        }

        public string LastProcessingDate
        {
            get { return lastProcessingDate; }
            set { lastProcessingDate = value; }
        }

        public virtual void Print() { }

        public abstract void CalculateAverageSum(List<BankData> averageSum);
    }
}
