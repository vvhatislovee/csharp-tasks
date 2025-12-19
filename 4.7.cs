static void Main()
{
    int[] arr = ReadArray();
    int distinctCount = arr.Distinct().Count();
    Console.WriteLine($"Количество различных элементов: {distinctCount}");
}