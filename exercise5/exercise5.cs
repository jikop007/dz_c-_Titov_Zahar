using System;
using System.Collections.Generic;
using System.Linq;

class Program
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

        List<string> words = SplitIntoWords(inputText);
        
        int wordCount = words.Count;
        int sentenceCount = CountSentences(inputText);
        var frequentWords = GetMostFrequentWords(words);
        double averageWordLength = CalculateAverageWordLength(words);

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

    static List<string> SplitIntoWords(string text)
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

        return words;
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

    static List<string> GetMostFrequentWords(List<string> words)
    {
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

        int maxFrequency = wordFrequency.Values.Max();
        
        return wordFrequency
            .Where(pair => pair.Value == maxFrequency)
            .Select(pair => $"{pair.Key} ({pair.Value})")
            .ToList();
    }

    static double CalculateAverageWordLength(List<string> words)
    {
        if (words.Count == 0)
        {
            return 0;
        }

        return words.Average(word => word.Length);
    }
}