using System;
using System.Linq;

static void Main()
{
    int[] arr = ReadArray();
    var uniqueCount = arr.GroupBy(x => x).Count(g => g.Count() == 1);
    Console.WriteLine($"Элементов, встречающихся ровно 1 раз: {uniqueCount}");
}