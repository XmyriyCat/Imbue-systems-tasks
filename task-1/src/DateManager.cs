namespace task_1;

public static class DateManager
{
    // It's too slow but a really simple solution for this task
    public static int GetCountOfWeekday(DateTime startDate, DateTime endDate, DayOfWeek weekDay)
    {
        if (startDate > endDate)
        {
            throw new ArgumentException($"{nameof(startDate)} is greater than {nameof(endDate)}");
        }

        var currentDate = new DateTime(startDate.Ticks);
        var weekDayCount = 0; 
        
        while (currentDate < endDate)
        {
            if (currentDate.DayOfWeek == weekDay)
            {
                weekDayCount++;
            }
            
            currentDate = currentDate.AddDays(1);
        }

        return weekDayCount;
    }

    // It's too fast but a little complicated solution for this task
    public static int GetCountOfSaturdays(DateTime startDate, DateTime endDate)
    {
        if (startDate > endDate)
        {
            throw new ArgumentException($"{nameof(startDate)} is greater than {nameof(endDate)}");
        }
        
        var allRangeDays = Convert.ToInt32((endDate - startDate).TotalDays) + 1;
        var saturdayCounter = (allRangeDays + Convert.ToInt32(startDate.DayOfWeek)) / 7;
        
        return saturdayCounter;
    }
}