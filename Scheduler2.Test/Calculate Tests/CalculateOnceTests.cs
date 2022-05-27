using Xunit;
using FluentAssertions;
using SchedulerV2;

namespace Scheduler2.Test.Calculate_Tests
{
    public class CalculateOnceTests
    {
        [Fact]
        public void Validate_calculated_date_type_once()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 8, 10, 0),
                type = 0,
                onceTimeAt = new System.DateTime(2022, 05, 30, 14, 0, 0)
            };
            var expectedDate = new System.DateTime(2022, 05, 30, 14, 0, 0);
            //Act
            CalculateOnce.CalculateNextExecutionTime(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString());
        }
    }
}
