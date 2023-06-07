﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExam
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
            set
            {
                if (accountNumber == string.Empty)
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
                if (moneyAvailable < 0)
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

        public abstract decimal CalculateAverageSum(List<BankData> averageSum);
    }
}
