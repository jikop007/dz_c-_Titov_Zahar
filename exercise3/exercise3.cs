using System;

class Program3
{
    static void Main()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 11);
        Console.WriteLine("Попробуй угадать число от 1 до 10:");

        while (true)
        {
            string? input = Console.ReadLine();
            if (input != null && int.TryParse(input, out int number))
            {
                if (number == randomNumber)
                {
                    Console.WriteLine("Ты угадал");
                    break;
                }
                if (number > randomNumber)
                {
                    Console.WriteLine("Меньше");
                }
                else
                {
                    Console.WriteLine("Больше");
                }
            }
        }
    }
}