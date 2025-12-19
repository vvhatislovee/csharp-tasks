using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());

        int reversed = ReverseNumber(number);
        Console.WriteLine($"Число в обратном порядке: {reversed}");
    }

    static int ReverseNumber(int number)
    {
        bool isNegative = number < 0;
        number = Math.Abs(number);

        long reversed = 0; // Используем long, чтобы избежать переполнения при больших числах

        while (number > 0)
        {
            reversed = reversed * 10 + number % 10;
            number /= 10;
        }

        if (isNegative)
            reversed = -reversed;

        // Проверка на переполнение int
        if (reversed < int.MinValue || reversed > int.MaxValue)
            throw new OverflowException("Результат вышел за пределы int.");

        return (int)reversed;
    }
}