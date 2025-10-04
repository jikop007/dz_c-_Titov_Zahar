using System;

class Program
{
    static void Main()
    {
        int DegreesСelsius = 0;
        Console.Write("Введите температуру в градусах Цельсия: ");
        string? input = Console.ReadLine();

        if (input != null && int.TryParse(input, out DegreesСelsius))
        {
            Console.Write("Температура в Форенгейтах: ");
            Console.Write(DegreesСelsius * 9 / 5 + 32);
        }
        else
        {
            Console.WriteLine("Неверный формат ввода");
        }
    }
}