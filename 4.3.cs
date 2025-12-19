static void Main()
{
    int[] arr = ReadArray();
    var (start, length) = FindLongestPalindromicSubarray(arr);
    
    if (length == 0) return;
    
    Console.Write("Максимальная симметричная подпоследовательность: ");
    for (int i = start; i < start + length; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}

static (int start, int length) FindLongestPalindromicSubarray(int[] arr)
{
    if (arr.Length == 0) return (0, 0);
    
    int bestStart = 0, bestLen = 1;

    for (int center = 0; center < arr.Length; center++)
    {
        // Нечётная длина
        int l = center, r = center;
        while (l >= 0 && r < arr.Length && arr[l] == arr[r])
        {
            int len = r - l + 1;
            if (len > bestLen)
            {
                bestLen = len;
                bestStart = l;
            }
            l--; r++;
        }

        // Чётная длина
        l = center; r = center + 1;
        while (l >= 0 && r < arr.Length && arr[l] == arr[r])
        {
            int len = r - l + 1;
            if (len > bestLen)
            {
                bestLen = len;
                bestStart = l;
            }
            l--; r++;
        }
    }

    return (bestStart, bestLen);
}