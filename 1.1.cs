using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Введите третье число: ");
        int c = int.Parse(Console.ReadLine());

        int evenCount = 0;
        if (a % 2 == 0) evenCount++;
        if (b % 2 == 0) evenCount++;
        if (c % 2 == 0) evenCount++;

        if (evenCount == 1)
            Console.WriteLine("истина");
        else
            Console.WriteLine("ложь");
    }
}