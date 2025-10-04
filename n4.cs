using System;
using System.Linq.Expressions;

class Program4
{
    static void Main()
    {
        Console.Write("Введите пароль: ");

        while (true)
        {
            string? password = Console.ReadLine();

            string specialChars = "!@#$%^&*";

            bool hasUpperCase = password.Any(char.IsUpper);
            bool hasDigits = password.Any(char.IsDigit);
            bool hasSpecialChar = password.Any(symbol => specialChars.Contains(symbol));
            int length = password.Length;

            if (!hasUpperCase)
            {
                Console.Write("Пароль должен содержать хотя бы одну заглавную букву\n");
            }

            if (!hasDigits)
            {
                Console.Write("Пароль должен содержать хотя бы одну цифру\n");
            }

            if (!hasSpecialChar)
            {
                Console.Write("Пароль должен содержать хотя бы один специальный символ из !@#$%^&*\n");
            }

            if (length != 8)
            {
                Console.Write("Пароль должен состоять из 8 символов\n");
            }

            if (hasUpperCase && hasDigits && hasSpecialChar && length == 8)
            {
                Console.Write("Пароль принят\n");
                break;
            }
        }
    }
}