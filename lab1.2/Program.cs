using System;

class Program
{
    static void Main()
    {
        Console.Write("введіть рік: ");
        int year = Convert.ToInt32(Console.ReadLine());

        bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;

        if (isLeapYear)
        {
            Console.WriteLine($"{year} - це високосний рік");
        }
        else
        {
            Console.WriteLine($"{year} - це не високосний рік");
        }
    }
}
