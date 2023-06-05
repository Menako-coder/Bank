using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bank
{
    public class PaymentAccount : BankData
    {
        public decimal MoneyAvailable { get; set; }
        public DateTime dateOfTheLastProcessing { get; set; }

        public PaymentAccount(int numberOfSpendingAccount, decimal moneyAvailable, DateTime dateOfTheLatestProcessing) : base(numberOfSpendingAccount)
        {
            MoneyAvailable = moneyAvailable;
            this.dateOfTheLastProcessing = dateOfTheLatestProcessing;
        }

        public override void Print()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Available money in the bank: {MoneyAvailable}");
            sb.AppendLine($"Date of the last processing: {dateOfTheLastProcessing}");
            Console.Write(sb.ToString());
        }

        public void CalculateAverageSum(List<PaymentAccount> averageMoney)
        {
            decimal a = averageMoney.Average(x => x.MoneyAvailable);
            Console.WriteLine(a);
        }





















    }
}
