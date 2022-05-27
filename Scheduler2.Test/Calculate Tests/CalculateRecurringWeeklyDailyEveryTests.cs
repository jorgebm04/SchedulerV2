using Xunit;
using FluentAssertions;
using SchedulerV2;

namespace Scheduler2.Test.Calculate_Tests
{
    public class CalculateRecurringWeeklyDailyEveryTests
    {
        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_every_hour_before_limits_in_last_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 8, 0, 0),
                occurs = 1,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                needToAddDay = false,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 16, 0, 0),
                lastDay = 5,
                weeks = 1
            };
            settings.days.Add(5, "Friday");
            var expectedDate = new System.DateTime(2022, 05, 27, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_every_hour_in_limits_in_last_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 10, 30, 0),
                occurs = 1,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                needToAddDay = false,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 16, 0, 0),
                lastDay = 5,
                weeks = 1
            };
            settings.days.Add(5, "Friday");
            var expectedDate = new System.DateTime(2022, 05, 27, 11, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_every_hour_in_over_limits_in_last_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 10, 15, 0),
                occurs = 1,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                needToAddDay = false,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 10, 30, 0),
                lastDay = 5,
                weeks = 1
            };
            settings.days.Add(5, "Friday");
            var expectedDate = new System.DateTime(2022, 05, 27, 10, 30, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_every_hour_over_limits_in_last_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 10, 45, 0),
                occurs = 1,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                needToAddDay = true,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 10, 30, 0),
                lastDay = 5,
                weeks = 1
            };
            settings.days.Add(5, "Friday");
            var expectedDate = new System.DateTime(2022, 06, 03, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_every_minute_before_limits_in_last_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 8, 0, 0),
                occurs = 1,
                occursEvery = true,
                occursEveryFreq = 30,
                freq = 1,
                needToAddDay = false,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 16, 0, 0),
                lastDay = 5,
                weeks = 1
            };
            settings.days.Add(5, "Friday");
            var expectedDate = new System.DateTime(2022, 05, 27, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_every_minute_in_limits_in_last_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 10, 15, 0),
                occurs = 1,
                occursEvery = true,
                occursEveryFreq = 30,
                freq = 1,
                needToAddDay = false,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 16, 0, 0),
                lastDay = 5,
                weeks = 1
            };
            settings.days.Add(5, "Friday");
            var expectedDate = new System.DateTime(2022, 05, 27, 10, 30, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_every_minute_in_over_limits_in_last_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 10, 20, 0),
                occurs = 1,
                occursEvery = true,
                occursEveryFreq = 30,
                freq = 1,
                needToAddDay = false,
                startingHour = new System.DateTime(2022, 05, 27, 10, 15, 0),
                endingHour = new System.DateTime(2022, 05, 27, 10, 30, 0),
                lastDay = 5,
                weeks = 1
            };
            settings.days.Add(5, "Friday");
            var expectedDate = new System.DateTime(2022, 05, 27, 10, 30, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_every_minute_over_limits_in_last_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 10, 45, 0),
                occurs = 1,
                occursEvery = true,
                occursEveryFreq = 30,
                freq = 1,
                needToAddDay = true,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 10, 30, 0),
                lastDay = 5,
                weeks = 1
            };
            settings.days.Add(5, "Friday");
            var expectedDate = new System.DateTime(2022, 06, 03, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_every_hour_before_limits_in_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 8, 0, 0),
                occurs = 1,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                needToAddDay = false,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 16, 0, 0),
                lastDay = 6,
                weeks = 1
            };
            settings.days.Add(5, "Friday");
            settings.days.Add(6, "Saturday");
            var expectedDate = new System.DateTime(2022, 05, 27, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_every_hour_in_limits_in_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 10, 30, 0),
                occurs = 1,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                needToAddDay = false,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 16, 0, 0),
                lastDay = 6,
                weeks = 1
            };
            settings.days.Add(5, "Friday");
            settings.days.Add(6, "Saturday");
            var expectedDate = new System.DateTime(2022, 05, 27, 11, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_every_hour_in_over_limits_in_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 10, 15, 0),
                occurs = 1,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                needToAddDay = false,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 10, 30, 0),
                lastDay = 6,
                weeks = 1
            };
            settings.days.Add(5, "Friday");
            settings.days.Add(6, "Saturday");
            var expectedDate = new System.DateTime(2022, 05, 27, 10, 30, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_every_hour_over_limits_in_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 10, 45, 0),
                occurs = 1,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                needToAddDay = true,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 10, 30, 0),
                lastDay = 6,
                weeks = 1
            };
            settings.days.Add(5, "Friday");
            settings.days.Add(6, "Saturday");
            var expectedDate = new System.DateTime(2022, 05, 28, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_every_minute_before_limits_in_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 8, 0, 0),
                occurs = 1,
                occursEvery = true,
                occursEveryFreq = 30,
                freq = 1,
                needToAddDay = false,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 16, 0, 0),
                lastDay = 6,
                weeks = 1
            };
            settings.days.Add(5, "Friday");
            settings.days.Add(6, "Saturday");
            var expectedDate = new System.DateTime(2022, 05, 27, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_every_minute_in_limits_in_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 10, 15, 0),
                occurs = 1,
                occursEvery = true,
                occursEveryFreq = 30,
                freq = 1,
                needToAddDay = false,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 16, 0, 0),
                lastDay = 6,
                weeks = 1
            };
            settings.days.Add(5, "Friday");
            settings.days.Add(6, "Saturday");
            var expectedDate = new System.DateTime(2022, 05, 27, 10, 30, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_every_minute_in_over_limits_in_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 10, 20, 0),
                occurs = 1,
                occursEvery = true,
                occursEveryFreq = 30,
                freq = 1,
                needToAddDay = false,
                startingHour = new System.DateTime(2022, 05, 27, 10, 15, 0),
                endingHour = new System.DateTime(2022, 05, 27, 10, 30, 0),
                lastDay = 6,
                weeks = 1
            };
            settings.days.Add(5, "Friday");
            settings.days.Add(6, "Saturday");
            var expectedDate = new System.DateTime(2022, 05, 27, 10, 30, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }

        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_every_minute_over_limits_in_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 10, 45, 0),
                occurs = 1,
                occursEvery = true,
                occursEveryFreq = 30,
                freq = 1,
                needToAddDay = true,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 10, 30, 0),
                lastDay = 6,
                weeks = 1
            };
            settings.days.Add(5, "Friday");
            settings.days.Add(6, "Saturday");
            var expectedDate = new System.DateTime(2022, 05, 28, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }
        [Fact]
        public void Validate_calculated_date_type_recurring_weekly_occurs_every_not_in_day_after_last_day()
        {
            //Arrange
            var settings = new Settings
            {
                currentDate = new System.DateTime(2022, 05, 27, 10, 45, 0),
                occurs = 1,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                needToAddDay = true,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 10, 30, 0),
                lastDay = 3,
                weeks = 1
            };
            settings.days.Add(2, "Tuesday");
            settings.days.Add(3, "Wednesday");
            //Next Friday
            var expectedDate = new System.DateTime(2022, 05, 31, 10, 0, 0);
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
                currentDate = new System.DateTime(2022, 05, 27, 10, 45, 0),
                occurs = 1,
                occursEvery = true,
                occursEveryFreq = 1,
                freq = 0,
                needToAddDay = true,
                startingHour = new System.DateTime(2022, 05, 27, 10, 0, 0),
                endingHour = new System.DateTime(2022, 05, 27, 10, 30, 0),
                lastDay = 7,
                weeks = 1
            };
            settings.days.Add(2, "Tuesday");
            settings.days.Add(7, "Sunday");
            //Next Friday
            var expectedDate = new System.DateTime(2022, 05, 29, 10, 0, 0);
            //Act
            CalculateRecurring.calculate(settings);
            //Assert
            settings.nextExecutionTime.Should().Be(expectedDate.ToString("dd/MM/yyyy") + " " + expectedDate.ToString("HH:mm"));
        }
    }
}
