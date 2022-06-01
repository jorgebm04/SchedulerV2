namespace SchedulerV2
{
    public static class CalculateWeeklyEveryRecurring
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            
            int lastDayOfWeek = settings.lastDay;
            int firstDayOfWeek = (int)settings.days.GetKey(0);
            int today = (int)settings.currentDate.DayOfWeek;
            int todayIndex = settings.days.IndexOfKey(today);

            //If today is a selected day
            if (settings.days.Contains(today))
            {
                if (today == lastDayOfWeek)
                {
                    if (settings.needToAddDay)
                    {
                        //Calculates de difference to go to the first day of the week and then add the weeks
                        WeeksAdder.AddWeeks(settings, firstDayOfWeek, today);
                        WriteNextExecution(settings);
                    }
                    else
                    {
                        ApplyDaily(settings);
                    }
                }
                else
                {
                    if (settings.needToAddDay)
                    {
                        DaysAdder.NextDay(settings, todayIndex);
                        WriteNextExecution(settings);
                    }
                    else
                    {
                        ApplyDaily(settings);
                    }
                }
            }
            else
            {
                if (today > settings.lastDay)
                {
                    WeeksAdder.AddWeeks(settings, firstDayOfWeek, today);
                    WriteNextExecution(settings);
                }
                else
                {
                    DaysAdder.NextAvaibleDay(settings, today);
                    WriteNextExecution(settings);
                }
            }
        }

        public static void ApplyDaily(Settings settings)
        {
            //Calculate the next execution time
            DateTime calculated = settings.startingHour;
            while (TimeSpan.Compare(calculated.TimeOfDay, settings.currentDate.TimeOfDay) < 0)
            {
                switch (settings.freq)
                {
                    case (int)FreqEnum.frequency.Hours:
                        calculated = calculated.AddHours(settings.occursEveryFreq);
                        break;
                    case (int)FreqEnum.frequency.Minutes:
                        calculated = calculated.AddMinutes(settings.occursEveryFreq);
                        break;
                    case (int)FreqEnum.frequency.Seconds:
                        calculated = calculated.AddSeconds(settings.occursEveryFreq);
                        break;
                }
                if (TimeSpan.Compare(calculated.TimeOfDay, settings.endingHour.TimeOfDay) > 0)
                {
                    calculated = settings.endingHour;
                    break;
                }
            }
            string nextExecution = settings.currentDate.ToString("dd/MM/yyyy") + " " + calculated.ToString("HH:mm");
            settings.calculatedDate = DateTime.ParseExact(nextExecution, "dd/MM/yyyy HH:mm", null);
            settings.nextExecutionTime = nextExecution;
        }

        public static void WriteNextExecution(Settings settings)
        {
            string nextExecution = settings.currentDate.ToString("dd/MM/yyyy") + " " + settings.startingHour.ToString("HH:mm");
            settings.calculatedDate = DateTime.ParseExact(nextExecution, "dd/MM/yyyy HH:mm", null);
            settings.nextExecutionTime = nextExecution;
        }
    }
}

