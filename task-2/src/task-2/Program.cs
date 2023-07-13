namespace task_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 5, 3, 2, 4, 5, 6, 2, 1, 4, 6, 6, 6, 7, 1, 3, 4 };

            ArrayAnalyzer.GetUsageOfEachNumber(numbers);
        }
    }
}