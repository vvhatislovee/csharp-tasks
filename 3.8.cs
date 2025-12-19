using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());

        double result = HornerScheme(x);
        Console.WriteLine($"Результат по схеме Горнера: {result}");
    }

    static double HornerScheme(double x)
    {
        // Коэффициенты: 1, 2, 3, ..., 10, 11
        // Схема Горнера: y = (...((1*x + 2)*x + 3)*x + ... + 11)

        double result = 1; // коэффициент при x^10
        for (int i = 2; i <= 11; i++)
            result = result * x + i;

        return result;
    }
}