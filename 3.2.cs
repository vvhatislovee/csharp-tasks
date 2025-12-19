using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число n: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Для отрицательных чисел двойной факториал не определён.");
            return;
        }

        long result = DoubleFactorial(n);
        Console.WriteLine($"{n}!! = {result}");
    }

    static long DoubleFactorial(int n)
    {
        if (n == 0 || n == 1) return 1;

        long result = 1;
        int step = n % 2 == 0 ? 2 : 1; // если чётное — шаг 2, нечётное — шаг 1
        for (int i = n; i >= 1; i -= 2)
            result *= i;

        return result;
    }
}