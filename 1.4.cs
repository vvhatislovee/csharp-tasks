using System;

class Program
{
    static void Main()
    {
        Console.Write("Координаты коня (x1 y1): ");
        string[] coords1 = Console.ReadLine().Split();
        int x1 = int.Parse(coords1[0]);
        int y1 = int.Parse(coords1[1]);

        Console.Write("Координаты фигуры (x2 y2): ");
        string[] coords2 = Console.ReadLine().Split();
        int x2 = int.Parse(coords2[0]);
        int y2 = int.Parse(coords2[1]);

        // Конь ходит буквой "Г": ±1 по одному направлению и ±2 по другому
        int dx = Math.Abs(x1 - x2);
        int dy = Math.Abs(y1 - y2);

        if ((dx == 1 && dy == 2) || (dx == 2 && dy == 1))
            Console.WriteLine("Да, конь бьёт фигуру.");
        else
            Console.WriteLine("Нет, конь не бьёт фигуру.");
    }
}