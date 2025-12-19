static void Main()
{
    int[] arr = ReadArray();
    var (start, length) = FindLongestIncreasingSubarray(arr);
    
    if (length == 0) return;
    
    Console.Write("Максимальная возрастающая подпоследовательность (подряд): ");
    for (int i = start; i < start + length; i++)
        Console.Write(arr[i] + " ");
    Console.WriteLine();
}

static (int start, int length) FindLongestIncreasingSubarray(int[] arr)
{
    if (arr.Length == 0) return (0, 0);

    int maxStart = 0, maxLength = 1;
    int currentStart = 0, currentLength = 1;

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > arr[i - 1])
        {
            currentLength++;
        }
        else
        {
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                maxStart = currentStart;
            }
            currentStart = i;
            currentLength = 1;
        }
    }

    if (currentLength > maxLength)
    {
        maxLength = currentLength;
        maxStart = currentStart;
    }

    return (maxStart, maxLength);
}