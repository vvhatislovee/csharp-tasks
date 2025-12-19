using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число n: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Число должно быть натуральным (n > 0).");
            return;
        }

        long sum = 0;
        for (int i = 1; i <= n; i++)
        {
            long product = 1;
            for (int j = i; j <= 2 * i; j++)
                product *= j;
            sum += product;
        }

        Console.WriteLine($"Результат: {sum}");
    }
}