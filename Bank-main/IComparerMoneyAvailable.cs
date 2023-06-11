using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExam
{
    internal class IComparerMoneyAvailable : IComparer<Owner>
    {
        public int Compare(Owner x, Owner y)
        {
            if (x.AccountNumber.CompareTo(y.AccountNumber) != 0)
            {
                return x.AccountNumber.CompareTo(y.AccountNumber);
            }

            return 0;
        }
    }
}
