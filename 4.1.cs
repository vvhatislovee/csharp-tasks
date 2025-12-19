using System;

class Program
{
    static void Main()
    {
        int[] arr = ReadArray();
        bool isIncreasing = IsStrictlyIncreasing(arr);
        Console.WriteLine(isIncreasing ? "Да" : "Нет");
    }

    static bool IsStrictlyIncreasing(int[] arr)
    {
        if (arr.Length <= 1) return true;
        for (int i = 0; i < arr.Length - 1; i++)
            if (arr[i] >= arr[i + 1])
                return false;
        return true;
    }

    static int[] ReadArray()
    {
        Console.Write("Введите элементы массива через пробел: ");
        string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] arr = new int[tokens.Length];
        for (int i = 0; i < tokens.Length; i++)
            arr[i] = int.Parse(tokens[i]);
        return arr;
    }
}