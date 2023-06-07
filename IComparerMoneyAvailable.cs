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
            if (x.MoneyAvailable.CompareTo(y.MoneyAvailable) != 0)
            {
                return x.MoneyAvailable.CompareTo(y.MoneyAvailable);
            }

            return 0;
        }
    }
}
