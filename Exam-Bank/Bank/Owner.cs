using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Bank
{
    public class Owner : BankData, IComparable<Owner>
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Owner(int numberOfSpendingAccount, string name, string address) : base(numberOfSpendingAccount)
        {
            this.Name = name;
            this.Address = address;
        }

        public override void Print()
        {
            base.Print();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Owner name: {Name}");
            sb.AppendLine($"Address: {Address}");
            Console.Write(sb.ToString());
        }

        public int CompareTo(Owner other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
