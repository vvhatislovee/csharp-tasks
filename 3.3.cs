using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("a должно быть меньше или равно b.");
            return;
        }

        Console.WriteLine($"Числа Армстронга в [{a}, {b}]:");

        bool found = false;
        for (int i = a; i <= b; i++)
        {
            if (IsArmstrong(i))
            {
                Console.Write(i + " ");
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("Нет чисел Армстронга в этом диапазоне.");

        Console.WriteLine();
    }

    static bool IsArmstrong(int n)
    {
        string digits = n.ToString();
        int sum = 0;
        foreach (char c in digits)
            sum += (c - '0') * (c - '0') * (c - '0'); // куб цифры

        return sum == n;
    }
}