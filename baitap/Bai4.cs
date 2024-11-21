class Bai4
{
    public static List<int> countOccurences(List<int> IstNumbers, int k)
    {
        Dictionary<int, int> countNumber = new Dictionary<int, int>();
        foreach (int number in IstNumbers)
        {
            if (countNumber.ContainsKey(number))
            {
                countNumber[number]++;
            }
            else
            {
                countNumber[number] = 1;
            }
        }

        List<int> result = new List<int>();
        foreach (var entry in countNumber)
        {
            if (entry.Value >= k)
            {
                result.Add(entry.Key);
            }
        }
        Console.WriteLine($"các số có lần lặp >= {k}: [{string.Join(", ", result)}]");

        return result;
    }
}