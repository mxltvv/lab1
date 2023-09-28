using System;

class Program
{
    static void Main()
    {
        
        Console.Write("введіть перше число: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("введіть друге число: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("введіть третє число: ");
        double number3 = Convert.ToDouble(Console.ReadLine());

      
        double largestNumber = Math.Max(number1, Math.Max(number2, number3));

       
        Console.WriteLine("найбільше число: " + largestNumber);
    }
}
