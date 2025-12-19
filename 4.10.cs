static void Main()
{
    int[] arr = ReadArray();
    bool isSet = arr.Length == arr.Distinct().Count();
    Console.WriteLine(isSet ? "Да, это множество." : "Нет, не множество.");
}