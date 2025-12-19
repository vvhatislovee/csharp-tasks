static void Main()
{
    int[] arr = ReadArray();
    if (arr.Length == 0) return;

    var groups = arr.GroupBy(x => x)
                    .OrderByDescending(g => g.Count())
                    .ThenBy(g => g.Key) // при равенстве — взять первый по значению
                    .First();

    Console.WriteLine($"Элемент с максимальной частотой: {groups.Key} (встречается {groups.Count()} раз)");
}