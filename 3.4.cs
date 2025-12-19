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

        Console.WriteLine($"Дружественные пары в [{a}, {b}]:");

        for (int i = a; i <= b; i++)
        {
            int sumI = SumOfProperDivisors(i);
            if (sumI > i && sumI <= b) // чтобы не повторять пары
            {
                int sumSumI = SumOfProperDivisors(sumI);
                if (sumSumI == i)
                    Console.WriteLine($"{i} и {sumI}");
            }
        }
    }

    static int SumOfProperDivisors(int n)
    {
        int sum = 0;
        for (int i = 1; i < n; i++)
            if (n % i == 0)
                sum += i;
        return sum;
    }
}