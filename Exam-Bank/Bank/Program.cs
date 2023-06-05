using Bank;
using System.Threading.Channels;

int input = int.Parse(Console.ReadLine());

var ownerData = new List<Owner>();
var paymentAccountData = new List<PaymentAccount>();
StreamWriter writeBank = new StreamWriter("Bank.txt");

for (int i = 0; i < input; i++)
{
    Console.WriteLine("Owner data for the current number of their spending account: ");

    string[] command = Console.ReadLine().Split(", ");

    Owner owners = new(int.Parse(command[0]), command[1], command[2]);

    ownerData.Add(owners);

    Console.WriteLine("Payment account data for the current number of their spending account: ");

    string[] command2 = Console.ReadLine().Split(", ");

    PaymentAccount paymentAccount = new(int.Parse(command2[0]), decimal.Parse(command2[1]), DateTime.Parse(command2[2]));

    paymentAccountData.Add(paymentAccount);
}

ownerData.Sort();
ownerData.ForEach(owner => owner.Print());
paymentAccountData.ForEach(paymentAccount => paymentAccount.Print());


