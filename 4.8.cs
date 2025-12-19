using System;
using System.Linq;

static void Main()
{
    double[] times = ReadDoubleArray(); // предположим, времена — double
    if (times.Length < 4)
    {
        Console.WriteLine("Недостаточно спортсменов.");
        return;
    }

    var best4 = times.OrderBy(t => t).Take(4).ToArray();
    Console.Write("4 лучших времени: ");
    foreach (var t in best4) Console.Write($"{t:F2} ");
    Console.WriteLine();
}

static double[] ReadDoubleArray()
{
    Console.Write("Введите времена через пробел: ");
    return Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(double.Parse)
        .ToArray();
}