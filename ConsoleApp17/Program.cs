
using System;

class Program
{
    static decimal PlatinumToUSD(decimal ounces)
    {
        return ounces * 1634.00m;
    }

    static void Main()
    {
        Console.Write("Enter the number of ounces of platinum: ");
        decimal ounces = decimal.Parse(Console.ReadLine());

        decimal amount = PlatinumToUSD(ounces);

        Console.WriteLine($"USD amount: {amount:C2}");
    }
}