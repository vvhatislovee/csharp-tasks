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

        // Увеличиваем день
        day++;

        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

        if (month == 2 && isLeap)
        {
            if (day > 29)
            {
                day = 1;
                month++;
            }
        }
        else if (day > daysInMonth[month - 1])
        {
            day = 1;
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
        }

        Console.WriteLine($"Следующий день: {day}.{month}.{year}");
    }
}