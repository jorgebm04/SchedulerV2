using Xunit;
using FluentAssertions;
using SchedulerV2;

namespace Scheduler2.Test.Check_Tests
{
    public class CheckOnceSettingsTests
    {
        [Fact]
        public void Validate_correct_current_date_checker()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = System.DateTime.Today
            };
            //Act
            bool result = OnceCurrentDateChecker.CheckOnceCurrentDate(settings.currentDate);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_current_date_checker()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2000, 1, 1, 0, 0, 0)
            };
            //Act
            bool result = OnceCurrentDateChecker.CheckOnceCurrentDate(settings.currentDate);
            //Assert
            result.Should().BeFalse();
        }

        [Fact]
        public void Validate_correct_once_time_at_checker()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 20, 15, 0, 0),
                onceTimeAt = new System.DateTime(2022,05,30,15,0,0)
            };
            //Act
            bool result = OnceTimeAtChecker.CheckOnceTimeAt(settings.onceTimeAt,settings.currentDate);
            //Assert
            result.Should().BeTrue();
        }

        [Fact]
        public void Validate_incorrect_once_time_at_checker()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 20, 15, 0, 0),
                onceTimeAt = new System.DateTime(2022, 05, 10, 15, 0, 0)
            };
            //Act
            bool result = OnceTimeAtChecker.CheckOnceTimeAt(settings.onceTimeAt, settings.currentDate);
            //Assert
            result.Should().BeFalse();
        }
    }
}
