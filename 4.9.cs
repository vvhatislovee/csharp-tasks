static void Main()
{
    int[] a = ReadArray();
    int[] b = ReadArray();

    var setB = new HashSet<int>(b);
    int count = a.Count(x => setB.Contains(x));
    Console.WriteLine($"Элементов из первого массива, содержащихся во втором: {count}");
}