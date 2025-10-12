using System;
using System.Linq;

class Program4
{
    static void Main()
    {
        Console.Write("Введите пароль: ");

        while (true)
        {
            string? password = Console.ReadLine();

            if (string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Пароль не может быть пустым");
                continue;
            }

            string specialChars = "!@#$%^&*";

            bool hasUpperCase = password.Any(char.IsUpper);
            bool hasDigits = password.Any(char.IsDigit);
            bool hasSpecialChar = password.Any(symbol => specialChars.Contains(symbol));
            int length = password.Length;

            if (!hasUpperCase)
            {
                Console.WriteLine("Пароль должен содержать хотя бы одну заглавную букву");
            }

            if (!hasDigits)
            {
                Console.WriteLine("Пароль должен содержать хотя бы одну цифру");
            }

            if (!hasSpecialChar)
            {
                Console.WriteLine("Пароль должен содержать хотя бы один специальный символ из !@#$%^&*");
            }

            if (length < 8)
            {
                Console.WriteLine("Пароль должен состоять из не менее 8 символов");
            }

            if (hasUpperCase && hasDigits && hasSpecialChar && length >= 8)
            {
                Console.WriteLine("Пароль принят");
                break;
            }
        }
    }
}