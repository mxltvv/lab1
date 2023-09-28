using System;

class Program
{
    static void Main()
    {
        Console.Write("введіть ваш річний дохід: ");
        double income = Convert.ToDouble(Console.ReadLine());

        double tax = 0.0;

        if (income <= 10000)
        {
            tax = income * 0.05;
        }
        else
        {
            tax = 10000 * 0.05;
            income -= 10000;

            if (income <= 20000)
            {
                tax += income * 0.1;
            }
            else
            {
                tax += 20000 * 0.1;
                income -= 20000;
                tax += income * 0.15;
            }
        }

        Console.WriteLine($"податок: {tax}");
    }
}
