using System;

class Program
{
    static void Main()
    {
        Console.Write("Координаты ферзя (x1 y1): ");
        string[] coords1 = Console.ReadLine().Split();
        int x1 = int.Parse(coords1[0]);
        int y1 = int.Parse(coords1[1]);

        Console.Write("Координаты фигуры (x2 y2): ");
        string[] coords2 = Console.ReadLine().Split();
        int x2 = int.Parse(coords2[0]);
        int y2 = int.Parse(coords2[1]);

        // Ферзь бьёт по горизонтали, вертикали или диагонали
        bool sameRow = y1 == y2;
        bool sameCol = x1 == x2;
        bool sameDiag = Math.Abs(x1 - x2) == Math.Abs(y1 - y2);

        if (sameRow || sameCol || sameDiag)
            Console.WriteLine("Да, ферзь бьёт фигуру.");
        else
            Console.WriteLine("Нет, ферзь не бьёт фигуру.");
    }
}