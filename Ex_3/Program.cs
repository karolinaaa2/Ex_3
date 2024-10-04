using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть річний дохід: ");
        double income = double.Parse(Console.ReadLine());
        double tax = 0;

        if (income <= 10000)
        {
            tax = income * 0.1; // 10% податку
        }
        else if (income <= 50000)
        {
            tax = income * 0.2; // 20% податку
        }
        else
        {
            tax = income * 0.3; // 30% податку
        }

        Console.WriteLine($"Податок на дохід: {tax}");
    }
}
