using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace task_1;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class DateManagerBenchmarks
{
    private static readonly DateTime StartDate = new DateTime(2020, 6, 23);
    private static readonly DateTime EndDate = new DateTime(2023, 7, 20);
    private static readonly DayOfWeek SourceDay = DayOfWeek.Saturday;

    [Benchmark]
    public void GetCountOfWeekday_SimpleImplementation()
    {
        DateManager.GetCountOfWeekday(StartDate, EndDate, SourceDay);
    }
    
    [Benchmark]
    public void GetCountOfSaturdays_ComplexImplementation()
    {
        DateManager.GetCountOfSaturdays(StartDate, EndDate);
    }
}