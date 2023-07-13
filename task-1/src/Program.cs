using BenchmarkDotNet.Running;

namespace task_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<DateManagerBenchmarks>();
        }
    }
}