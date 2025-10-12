using System;

class Program2
{
    static void Main()
    {
        int sum = 0;
        int number = 0;

        Console.WriteLine("Вводите числа по одному (для завершения введите 0):");

        while (true)
        {
            Console.Write("Введите число: ");
            string? input = Console.ReadLine();

            if (input != null && int.TryParse(input, out number))
            {
                if (number == 0)
                {
                    break;
                }
                
                sum += number;
                Console.WriteLine($"Текущая сумма: {sum}");
            }
            else
            {
                Console.WriteLine("Неверный формат ввода.");
            }
        }
        
        Console.WriteLine($"\nИтоговая сумма: {sum}");
    }
}