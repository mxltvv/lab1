using System;

class Program
{
    static void Main()
    {
        Console.Write("введіть число: ");
        double number = Convert.ToDouble(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("додатнє число");
        }
        else if (number < 0)
        {
            Console.WriteLine("від'ємне число");
        }
        else
        {
            Console.WriteLine("число рівне нулю");
        }
    }
}
