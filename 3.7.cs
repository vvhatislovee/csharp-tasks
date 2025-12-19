using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите n (номер числа Фибоначчи): ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("n должно быть натуральным.");
            return;
        }

        long fib = Fibonacci(n);
        Console.WriteLine($"F({n}) = {fib}");
    }

    static long Fibonacci(int n)
    {
        if (n == 1 || n == 2) return 1;

        long a = 1, b = 1;
        for (int i = 3; i <= n; i++)
        {
            long next = a + b;
            a = b;
            b = next;
        }
        return b;
    }
}