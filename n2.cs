using System;

class Program2
{
    static void Main()
    {
        int sum = 0;
        int number = 0;

        Console.Write("Вводите числа по одному: ");

        while (true)
        {
            string? input = Console.ReadLine();

            if (input != null && int.TryParse(input, out number))
            {
                if (number == 0)
                {
                    break;
                }
                Console.Write("Текущая сумма: \n");
                Console.Write(sum + number);
                sum += number;
            }
            else
            {
                Console.WriteLine("Неверный формат ввода");
            }
            Console.Write("\n");
        }
    }
}