using Xunit;
using FluentAssertions;
using SchedulerV2;

namespace Scheduler2.Test.Calculate_Tests
{
    public class CalculateRecurringWeeklyDailyOnceTests
    {
        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_once_in_last_day()
        {
            //Arrange
            var settings = new Settings
            {
                occurs = 1,
                occursOnceAt = true,
                currentDate = new System.DateTime(2022, 05, 27, 8, 10, 0),
                occursOnceAtHour = new System.DateTime(2022, 05, 30, 14, 0, 0),
                needToAddDay = false,
                friday = true,
                lastDay = 5,
                weeks = 1
            };
            settings.days.Add(5, "Friday");
            var expectedDate = new System.DateTime(2022, 05, 27, 14, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_once_in_last_day_over_hour()
        {
            //Arrange
            var settings = new Settings
            {
                occurs = 1,
                occursOnceAt = true,
                currentDate = new System.DateTime(2022, 05, 27, 15, 0, 0),
                occursOnceAtHour = new System.DateTime(2022, 05, 30, 14, 0, 0),
                needToAddDay = true,
                friday = true,
                lastDay = 5,
                weeks = 1
            };
            settings.days.Add(5, "Friday");
            //Next Friday
            var expectedDate = new System.DateTime(2022, 06, 03, 14, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_once_in_day_over_hour()
        {
            //Arrange
            var settings = new Settings
            {
                occurs = 1,
                occursOnceAt = true,
                currentDate = new System.DateTime(2022, 05, 27, 15, 0, 0),
                occursOnceAtHour = new System.DateTime(2022, 05, 30, 14, 0, 0),
                needToAddDay = true,
                friday = true,
                lastDay = 7,
                weeks = 1
            };
            settings.days.Add(5, "Friday");
            settings.days.Add(7, "Sunday");
            //Next Friday
            var expectedDate = new System.DateTime(2022, 05, 29, 14, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_once_in_day()
        {
            //Arrange
            var settings = new Settings
            {
                occurs = 1,
                occursOnceAt = true,
                currentDate = new System.DateTime(2022, 05, 27, 10, 0, 0),
                occursOnceAtHour = new System.DateTime(2022, 05, 30, 14, 0, 0),
                needToAddDay = false,
                friday = true,
                lastDay = 7,
                weeks = 1
            };
            settings.days.Add(5, "Friday");
            settings.days.Add(7, "Sunday");
            //Next Friday
            var expectedDate = new System.DateTime(2022, 05, 27, 14, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_once_not_in_day_after_last_day()
        {
            //Arrange
            var settings = new Settings
            {
                occurs = 1,
                occursOnceAt = true,
                currentDate = new System.DateTime(2022, 05, 29, 10, 0, 0),
                occursOnceAtHour = new System.DateTime(2022, 05, 30, 14, 0, 0),
                needToAddDay = false,
                friday = true,
                lastDay = 4,
                weeks = 1
            };
            settings.days.Add(2, "Tuesday");
            settings.days.Add(3, "Wednesday");
            //Next Friday
            var expectedDate = new System.DateTime(2022, 05, 31, 14, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_once_not_in_day_not_after_last_day()
        {
            //Arrange
            var settings = new Settings
            {
                occurs = 1,
                occursOnceAt = true,
                currentDate = new System.DateTime(2022, 05, 27, 10, 0, 0),
                occursOnceAtHour = new System.DateTime(2022, 05, 30, 14, 0, 0),
                needToAddDay = false,
                friday = true,
                lastDay = 7,
                weeks = 1
            };
            settings.days.Add(2, "Tuesday");
            settings.days.Add(7, "Sunday");
            //Next Friday
            var expectedDate = new System.DateTime(2022, 05, 29, 14, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }
    }
}
