namespace SchedulerV2
{
    public static class DaysChecker
    {
        public static int CheckDays(Settings settings)
        {
            int last = -1;
            if (settings.monday)
            {
                last = (int)DayOfWeek.Monday;
                settings.days.Add(1, "Monday");
            }
            if (settings.tuesday)
            {
                last = (int)DayOfWeek.Tuesday;
                settings.days.Add(2, "Tuesday");
            }
            if (settings.wednesday)
            {
                last = (int)DayOfWeek.Wednesday;
                settings.days.Add(3, "Wednesday");
            }
            if (settings.thursday)
            {
                last = (int)DayOfWeek.Thursday;
                settings.days.Add(4, "Thursday");
            }
            if (settings.friday)
            {
                last = (int)DayOfWeek.Friday;
                settings.days.Add(5, "Friday");
            }
            if (settings.saturday)
            {
                last = (int)DayOfWeek.Saturday;
                settings.days.Add(6, "Saturday");
            }
            if (settings.sunday)
            {
                last = 7;
                settings.days.Add(7, "Sunday");
            }
            return last;
        }
    }
}
