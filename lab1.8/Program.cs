using System;

class Program
{
    static void Main()
    {
        Console.Write("введіть довжину сторони a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("введіть довжину сторони b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("введіть довжину сторони c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine("сторона 'a' є найдовшою  трикутника");
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine("Сторона 'b' є найдовшою  трикутника");
        }
        else
        {
            Console.WriteLine("Сторона 'c' є найдовшою  трикутника");
        }
    }
}
