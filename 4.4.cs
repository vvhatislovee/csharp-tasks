using System;
using System.Collections.Generic;

static void Main()
{
    int[] arr = ReadArray();
    var lis = LongestIncreasingSubsequence(arr);
    
    Console.Write("Максимальная возрастающая подпоследовательность (не подряд): ");
    foreach (int x in lis) Console.Write(x + " ");
    Console.WriteLine();
}

static List<int> LongestIncreasingSubsequence(int[] arr)
{
    if (arr.Length == 0) return new List<int>();

    int n = arr.Length;
    int[] dp = new int[n]; // dp[i] = длина LIS, заканчивающейся в i
    int[] parent = new int[n]; // для восстановления

    for (int i = 0; i < n; i++)
    {
        dp[i] = 1;
        parent[i] = -1;
        for (int j = 0; j < i; j++)
        {
            if (arr[j] < arr[i] && dp[j] + 1 > dp[i])
            {
                dp[i] = dp[j] + 1;
                parent[i] = j;
            }
        }
    }

    // Находим индекс с макс длиной
    int maxLength = dp[0], bestEnd = 0;
    for (int i = 1; i < n; i++)
        if (dp[i] > maxLength)
        {
            maxLength = dp[i];
            bestEnd = i;
        }

    // Восстанавливаем путь
    List<int> result = new List<int>();
    for (int i = bestEnd; i != -1; i = parent[i])
        result.Add(arr[i]);

    result.Reverse();
    return result;
}