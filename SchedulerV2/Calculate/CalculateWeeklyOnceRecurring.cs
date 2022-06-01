namespace SchedulerV2
{
    public static class CalculateWeeklyOnceRecurring
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
                if(today == lastDayOfWeek)
                {
                    if (settings.needToAddDay)
                    {
                        //Calculates de difference to go to the first day of the week and then add the weeks
                        WeeksAdder.AddWeeks(settings, firstDayOfWeek, today);
                        ApplyDaily(settings);
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
                        ApplyDaily(settings);
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
                    ApplyDaily(settings);
                } else
                {
                    DaysAdder.NextAvaibleDay(settings, today);
                    ApplyDaily(settings);
                }
            }
        }

        public static void ApplyDaily(Settings settings)
        {
            string calculated = settings.currentDate.ToString("dd/MM/yyyy") + " " + settings.occursOnceAtHour.ToString("HH:mm");
            settings.calculatedDate = DateTime.ParseExact(calculated, "dd/MM/yyyy HH:mm", null);
            settings.nextExecutionTime = calculated;
        }
    }
}
