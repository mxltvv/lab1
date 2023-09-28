using System;

class Program
{
    static void Main()
    {
        Console.Write("введіть літру: ");
        char bykva = Console.ReadLine().ToUpper()[0];

        if (char.IsLetter(bykva))
        {
            if (bykva == 'A' || bykva == 'E' || bykva == 'I' || bykva == 'O' || bykva == 'U')
            {
                Console.WriteLine($"{bykva} -голосна буква");
            }
            else
            {
                Console.WriteLine($"{bykva} -приголосна буква");
            }
        }
        else
        {
            Console.WriteLine($"{bykva} - це не буква");
        }
    }
}
