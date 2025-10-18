using System;

class Program1
{
    static void Main()
    {
        double degreesСelsius = 0;
        Console.Write("Введите температуру в градусах Цельсия: ");
        string? input = Console.ReadLine();

        if (input != null && double.TryParse(input, out degreesСelsius))
        {
            Console.Write($"{degreesСelsius}°C = { degreesСelsius * 9 / 5 + 32}°F");
        }
        else
        {
            Console.WriteLine("Неверный формат ввода");
        }
    }
}