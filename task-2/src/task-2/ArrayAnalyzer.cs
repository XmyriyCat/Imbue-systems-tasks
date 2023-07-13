namespace task_2;

public class ArrayAnalyzer
{
    public static void GetUsageOfEachNumber(ICollection<int> numbers)
    {
        var numberUsageDictionary = new Dictionary<int, int>(numbers.Count);

        foreach (var value in numbers)
        {
            if (numberUsageDictionary.ContainsKey(value))
            {
                numberUsageDictionary[value]++;
                continue;
            }
            
            numberUsageDictionary.Add(value, 1);
        }

        var usageStat = string.Join("\n", numberUsageDictionary.Select(x => $"the number: {x.Key} -> is used {x.Value} times"));
            
        Console.WriteLine(usageStat);
    }
}