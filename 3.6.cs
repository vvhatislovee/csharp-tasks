using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Счастливые билеты (6 цифр):");

        int count = 0;
        for (int i = 0; i < 1000000; i++) // от 000000 до 999999
        {
            string ticket = i.ToString("D6"); // форматируем как 6 цифр

            int sumFirst = ticket[0] - '0' + ticket[1] - '0' + ticket[2] - '0';
            int sumLast = ticket[3] - '0' + ticket[4] - '0' + ticket[5] - '0';

            if (sumFirst == sumLast)
            {
                Console.Write(ticket + " ");
                count++;
            }
        }

        Console.WriteLine($"\nВсего счастливых билетов: {count}");
    }
}