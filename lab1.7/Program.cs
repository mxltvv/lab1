using System;

class Program
{
    static void Main()
    {
        Console.Write("введіть число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("число парне");
        }
        else
        {
            Console.WriteLine("число непарне"); 
        }

        if (number % 3 == 0)
        {
            Console.WriteLine("число ділиться на 3");
        }
        else
        {
            Console.WriteLine("це число не ділиться на 3");
        }
    }
}
