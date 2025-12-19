using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число от 1 до 999: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1 || n > 999)
        {
            Console.WriteLine("Число должно быть от 1 до 999.");
            return;
        }

        string ruble = GetRubleCase(n);
        Console.WriteLine($"{n} {ruble}");
    }

    static string GetRubleCase(int n)
    {
        // Последняя цифра
        int lastDigit = n % 10;
        // Предпоследняя цифра
        int secondLastDigit = (n / 10) % 10;

        // Исключение: если десятки = 1 (11-19), то всегда "рублей"
        if (secondLastDigit == 1)
            return "рублей";

        switch (lastDigit)
        {
            case 1:
                return "рубль";
            case 2:
            case 3:
            case 4:
                return "рубля";
            default:
                return "рублей";
        }
    }
}