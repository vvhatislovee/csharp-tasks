using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Введите цифру (0-9): ");
        int digit = int.Parse(Console.ReadLine());

        if (digit < 0 || digit > 9)
        {
            Console.WriteLine("Цифра должна быть от 0 до 9.");
            return;
        }

        bool contains = ContainsDigit(number, digit);
        Console.WriteLine(contains ? "Цифра входит в число." : "Цифра не входит в число.");
    }

    static bool ContainsDigit(int number, int digit)
    {
        // Обработка отрицательных чисел
        number = Math.Abs(number);

        if (number == 0 && digit == 0) return true;

        while (number > 0)
        {
            if (number % 10 == digit)
                return true;
            number /= 10;
        }
        return false;
    }
}