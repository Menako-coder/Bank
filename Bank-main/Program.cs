using BankExam;
using System.Linq;
using System.Threading.Channels;

int input = int.Parse(Console.ReadLine());

var ownerData = new List<Owner>();
StreamWriter writeBank = new("Bank.txt");

using (writeBank)
{
    for (int i = 0; i < input; i++)
    {
        Console.WriteLine("Enter owner data: ");

        string[] command = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

        Owner owners = new(int.Parse(command[0]), command[1], command[2], decimal.Parse(command[3]), command[4]);
        try
        {
            ownerData.Add(owners);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    Console.WriteLine();

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

    var highestMoneyAvailable = ownerData.Select(owner => owner.MoneyAvailable).Max();
    Console.WriteLine();
    Console.WriteLine($"Owner with the biggest amount available: {highestMoneyAvailable}");
    Console.WriteLine($"Average amount available in the bank: {CalculateAverageSum(ownerData):f2}");
}

static decimal CalculateAverageSum(List<Owner> ownerData)
{
    decimal result = ownerData.Average(avs => avs.MoneyAvailable);
    return result;
}




