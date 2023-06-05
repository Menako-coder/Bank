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
        protected int numberOfSpendingAccount;

        public BankData(int numberOfSpendingAccount)
        {
            this.numberOfSpendingAccount = numberOfSpendingAccount;
        }

        public virtual void Print()
        {
            StringBuilder sb = new();

            sb.AppendLine($"Number of the spending account: {numberOfSpendingAccount}");

            Console.Write(sb.ToString());
        }
    }
}
