﻿using System;
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

        public Owner(string accountNumber, string name, string address, decimal moneyAvailable, string lastProcessingDate) : base(accountNumber, moneyAvailable, lastProcessingDate)
        {
            this.Name = name;
            this.Address = address;
        }

        public override void Print()
        {
            base.Print();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Account number: {AccountNumber}");
            sb.AppendLine($"Owner name: {Name}");
            sb.AppendLine($"Address: {Address}");
            sb.AppendLine($"Money available: {MoneyAvailable}");
            sb.AppendLine($"Date of the last process: {LastProcessingDate}");
            Console.WriteLine(sb.ToString());
        }

        public int CompareTo(Owner other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}