// 
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int secret = random.Next(1, 101);

        int attempts = 0;
        bool guessed = false;

        Console.WriteLine("Угадай число (1-100)");
        Console.WriteLine("Я загадал число. Попробуй угадать!");

        while (!guessed)
        {
            Console.Write("\nВведите число: ");
            string input = Console.ReadLine();

            // int.TryParse — безопасное преобразование
            if (!int.TryParse(input, out int guess))
            {
                Console.WriteLine("!!! Введите корректное число!");
                continue;
            }

            // Проверка диапазона
            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("!!! Число должно быть от 1 до 100!");
                continue;
            }

            attempts++;

            if (guess < secret)
            {
                int diff = secret - guess;
                string hint = GetHint(diff);
                Console.WriteLine($"↑ Больше! {hint}");
            }
            else if (guess > secret)
            {
                int diff = guess - secret;
                string hint = GetHint(diff);
                Console.WriteLine($"↓ Меньше! {hint}");
            }
            else
            {
                guessed = true;
            }
        }

        // Тернарный оператор для итогового сообщения
        string result = attempts <= 7
            ? $"Отличный результат! Всего {attempts} попыток."
            : $"Число найдено за {attempts} попыток. Можно лучше!";

        Console.WriteLine($"\nПравильно! Загаданное число: {secret}");
        Console.WriteLine(result);
    }

    // Подсказка «горячо/тепло/холодно» через switch
    static string GetHint(int diff)
    {
        switch (diff)
        {
            case <= 5:
                return "Горячо!";
            case <= 15:
                return "Тепло!";
            case <= 30:
                return "Прохладно.";
            default:
                return "Холодно!";
        }
    }
}