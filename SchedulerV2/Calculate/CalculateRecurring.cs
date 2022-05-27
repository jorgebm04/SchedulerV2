namespace SchedulerV2
{
    public static class CalculateRecurring
    {
        public static void calculate(Settings settings)
        {
            if (settings.occurs == 0)
            {
                if (settings.occursOnceAt)
                {
                    CalculateDailyRecurring.CalculateNextExecutionTime(settings);
                    DailyRecurringDescription.setDescription(settings);
                }
                else if(settings.occursEvery)
                { 
                    CalculateEveryRecurring.CalculateNextExecutionTime(settings);
                    EveryRecurringDescription.SetDescription(settings);
                }
            }
            else if (settings.occurs == 1)
            {
                if (settings.occursOnceAt)
                {
                    CalculateWeeklyOnceRecurring.CalculateNextExecutionTime(settings);
                    WeeklyDailyRecurringDescription.SetDescription(settings);
                }
                else if (settings.occursEvery)
                {
                    CalculateWeeklyEveryRecurring.CalculateNextExecutionTime(settings);
                    WeeklyEveryRecurringDescription.SetDescription(settings);
                }
            }
        }
    }
}
