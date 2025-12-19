using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Число Фибоначчи не может быть отрицательным.");
            return;
        }

        if (IsFibonacci(n))
            Console.WriteLine($"{n} — число Фибоначчи.");
        else
            Console.WriteLine($"{n} — не число Фибоначчи.");
    }

    static bool IsFibonacci(int n)
    {
        if (n == 0 || n == 1) return true;

        int a = 0, b = 1;
        int next;

        while ((next = a + b) <= n)
        {
            if (next == n) return true;
            a = b;
            b = next;
        }

        return false;
    }
}