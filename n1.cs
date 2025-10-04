using System;

class Program1
{
    static void Main()
    {
        int degreesСelsius = 0;
        Console.Write("Введите температуру в градусах Цельсия: ");
        string? input = Console.ReadLine();

        if (input != null && int.TryParse(input, out degreesСelsius))
        {
            Console.Write("Температура в Форенгейтах: ");
            Console.Write(degreesСelsius * 9 / 5 + 32);
        }
        else
        {
            Console.WriteLine("Неверный формат ввода");
        }
    }
}