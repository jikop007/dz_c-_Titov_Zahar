using System;
using System.Linq.Expressions;

class Program3
{
    static void Main()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 11);
        Console.Write("Попробуй угадать число от 1 до 10: ");

        while (true)
        {
            int number = 0;
            string? input = Console.ReadLine();
            if (input != null && int.TryParse(input, out number))
            {
                if (number == randomNumber)
                {
                    Console.Write("Ты угадал\n");
                    break;
                }
                if (number > randomNumber)
                {
                    Console.Write("Меньше\n");
                }
                else
                {
                    Console.Write("Больше\n");
                }
            }

        }
    }
}