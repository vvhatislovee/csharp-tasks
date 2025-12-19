using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введите n (целое): ");
        int n = int.Parse(Console.ReadLine());

        double result = Power(x, n);
        Console.WriteLine($"{x}^{n} = {result}");
    }

    static double Power(double x, int n)
    {
        if (n == 0) return 1;
        if (n < 0)
        {
            x = 1 / x;
            n = -n;
        }

        double result = 1;
        for (int i = 0; i < n; i++)
            result *= x;

        return result;
    }
}