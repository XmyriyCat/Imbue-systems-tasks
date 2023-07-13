using task_1;
using Xunit;

namespace task_1_tests;

public class DateManagerTests
{
    [Fact]
    public void GetCountOfWeekday_InputDataIsCorrect_ShouldBeFourSaturdays()
    {
        // Arrange
        var startDate = new DateTime(2023, 6, 23);
        var endDate = new DateTime(2023, 7, 20);
        var sourceDay = DayOfWeek.Saturday;
        
        // Act
        var countOfSaturdays = DateManager.GetCountOfWeekday(startDate, endDate, sourceDay);

        // Assert
        Assert.Equal(4, countOfSaturdays);
    }
    
    [Fact]
    public void GetCountOfWeekday_InputDataIsCorrect_ShouldBeTwoSaturdays()
    {
        // Arrange
        var startDate = new DateTime(2023, 7, 6);
        var endDate = new DateTime(2023, 7, 19);
        var sourceDay = DayOfWeek.Saturday;
        
        // Act
        var countOfSaturdays = DateManager.GetCountOfWeekday(startDate, endDate, sourceDay);

        // Assert
        Assert.Equal(2, countOfSaturdays);
    }
    
    [Fact]
    public void GetCountOfWeekday_StartDateGreaterThanEndDate_ShouldThrowArgumentException()
    {
        // Arrange
        var startDate = new DateTime(2025, 1, 1);
        var endDate = new DateTime(2024, 1, 1);
        var sourceDay = DayOfWeek.Saturday;
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => DateManager.GetCountOfWeekday(startDate, endDate, sourceDay));
    }
    
    [Fact]
    public void GetCountOfSaturdays_InputDataIsCorrect_ShouldBeFourSaturdays()
    {
        // Arrange
        var startDate = new DateTime(2023, 6, 23);
        var endDate = new DateTime(2023, 7, 20);

        // Act
        var countOfSaturdays = DateManager.GetCountOfSaturdays(startDate, endDate);

        // Assert
        Assert.Equal(4, countOfSaturdays);
    }
    
    [Fact]
    public void GetCountOfSaturdays_InputDataIsCorrect_ShouldBeTwoSaturdays()
    {
        // Arrange
        var startDate = new DateTime(2023, 7, 6);
        var endDate = new DateTime(2023, 7, 19);

        // Act
        var countOfSaturdays = DateManager.GetCountOfSaturdays(startDate, endDate);

        // Assert
        Assert.Equal(2, countOfSaturdays);
    }
    
    [Fact]
    public void GetCountOfSaturdays_StartDateGreaterThanEndDate_ShouldThrowArgumentException()
    {
        // Arrange
        var startDate = new DateTime(2025, 1, 1);
        var endDate = new DateTime(2024, 1, 1);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => DateManager.GetCountOfSaturdays(startDate, endDate));
    }
}