static void Main()
{
    int[] a = ReadArray();
    int[] b = ReadArray();

    var setA = new HashSet<int>(a);
    var setB = new HashSet<int>(b);

    bool equal = setA.SetEquals(setB);
    Console.WriteLine(equal ? "Множества равны." : "Множества не равны.");
}