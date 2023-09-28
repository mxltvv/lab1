using System;

class Program
{
    static void Main()
    {
        Console.Write("введіть кількість років: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 12 && age <= 18)
        {
            Console.WriteLine("данна кількість років є підлітковою");
        }
        else
        {
            Console.WriteLine("данна кількість років не є підлітковою");
        }
    }
}
