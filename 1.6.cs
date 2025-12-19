using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите день: ");
        int day = int.Parse(Console.ReadLine());

        Console.Write("Введите месяц: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Введите год: ");
        int year = int.Parse(Console.ReadLine());

        if (IsValidDate(day, month, year))
            Console.WriteLine("Дата корректна.");
        else
            Console.WriteLine("Дата некорректна.");
    }

    static bool IsValidDate(int day, int month, int year)
    {
        if (year < 1 || month < 1 || month > 12 || day < 1)
            return false;

        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // Високосный год
        bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        if (isLeap && month == 2)
            return day <= 29;

        return day <= daysInMonth[month - 1];
    }
}