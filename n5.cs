using System;
using System.Collections.Generic;
using System.Linq;

class Program5
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string? inputText = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(inputText))
        {
            Console.WriteLine("Текст не может быть пустым");
            return;
        }

        int wordCount = CountWords(inputText);
        int sentenceCount = CountSentences(inputText);
        var frequentWords = GetMostFrequentWords(inputText);
        double averageWordLength = CalculateAverageWordLength(inputText);

        Console.WriteLine($"Количество слов: {wordCount}");
        Console.WriteLine($"Количество предложений: {sentenceCount}");
        Console.WriteLine($"Средняя длина слова: {averageWordLength:F2}");

        if (frequentWords.Any())
        {
            Console.WriteLine("Самые часто встречающиеся слова:");
            foreach (var word in frequentWords)
            {
                Console.WriteLine($"- {word}");
            }
        }
    }

    static int CountWords(string text)
    {
        int count = 0;
        bool inWord = false;

        foreach (char c in text)
        {
            if (char.IsLetterOrDigit(c))
            {
                if (!inWord)
                {
                    count++;
                    inWord = true;
                }
            }
            else
            {
                inWord = false;
            }
        }

        return count;
    }

    static int CountSentences(string text)
    {
        int count = 0;
        bool inSentence = false;

        foreach (char c in text)
        {
            if (char.IsLetterOrDigit(c))
            {
                inSentence = true;
            }
            else if (c == '.' || c == '!' || c == '?')
            {
                if (inSentence)
                {
                    count++;
                    inSentence = false;
                }
            }
        }

        if (inSentence)
        {
            count++;
        }

        return count;
    }

    static List<string> GetMostFrequentWords(string text)
    {
        var words = new List<string>();
        string currentWord = "";

        foreach (char c in text)
        {
            if (char.IsLetterOrDigit(c))
            {
                currentWord += c;
            }
            else
            {
                if (!string.IsNullOrEmpty(currentWord))
                {
                    words.Add(currentWord.ToLower());
                    currentWord = "";
                }
            }
        }

        if (!string.IsNullOrEmpty(currentWord))
        {
            words.Add(currentWord.ToLower());
        }

        var wordFrequency = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordFrequency.ContainsKey(word))
            {
                wordFrequency[word]++;
            }
            else
            {
                wordFrequency[word] = 1;
            }
        }

        if (!wordFrequency.Any())
        {
            return new List<string>();
        }

        int maxFrequency = 0;
        foreach (int frequency in wordFrequency.Values)
        {
            if (frequency > maxFrequency)
            {
                maxFrequency = frequency;
            }
        }

        var mostFrequent = new List<string>();
        foreach (var pair in wordFrequency)
        {
            if (pair.Value == maxFrequency)
            {
                mostFrequent.Add($"{pair.Key} ({pair.Value})");
            }
        }

        return mostFrequent;
    }

    static double CalculateAverageWordLength(string text)
    {
        int totalLength = 0;
        int wordCount = 0;
        string currentWord = "";

        foreach (char c in text)
        {
            if (char.IsLetterOrDigit(c))
            {
                currentWord += c;
            }
            else
            {
                if (!string.IsNullOrEmpty(currentWord))
                {
                    totalLength += currentWord.Length;
                    wordCount++;
                    currentWord = "";
                }
            }
        }

        if (!string.IsNullOrEmpty(currentWord))
        {
            totalLength += currentWord.Length;
            wordCount++;
        }

        if (wordCount == 0)
        {
            return 0;
        }

        return (double)totalLength / wordCount;
    }
}