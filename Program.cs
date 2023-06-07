using BankExam;
using System.Linq;
using System.Threading.Channels;

try
{
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

    IComparerMoneyAvailable comparer = new();
    ownerData.Sort(comparer);
    ownerData.ForEach(owner => owner.Print());

    Console.Write("Enter name: ");

    string name = Console.ReadLine();

    if (ownerData.Select(owner => owner.Name).Contains(name))
    {
        Console.WriteLine("Yes, the person exist!");
    }
    else
    {
        Console.WriteLine("This person does not exist!");
    } 

    var ownerWithHaghestMoneyAvailable = ownerData.Select(owner => owner.MoneyAvailable).Max();
    Console.WriteLine();
    Console.WriteLine($"Owner with the biggest amount available: {ownerWithHaghestMoneyAvailable}");
}
catch (Exception e)
{
    Console.WriteLine(" ", e.Message);
    return;
}





