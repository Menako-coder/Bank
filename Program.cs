using Bank;
using System.Globalization;
using System.Threading.Channels;

int input = int.Parse(Console.ReadLine());

var ownerData = new List<Owner>();
StreamWriter writeBank = new StreamWriter("Bank.txt");

for (int i = 0; i < input; i++)
{
    Console.WriteLine("Enter owner data: ");

    string[] command = Console.ReadLine().Split(", ");

    Owner owners = new(command[0], command[1], command[2], decimal.Parse(command[3]), command[4]);

    ownerData.Add(owners);
}

Console.WriteLine();
ownerData.Sort();
ownerData.ForEach(owner => owner.Print());