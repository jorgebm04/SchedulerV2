namespace SchedulerV2
{
    public static class WeeksAdder
    {
        public static void AddWeeks(Settings settings,int firstDayOfWeek, int today)
        {
            int diff = firstDayOfWeek - today;
            settings.currentDate = settings.currentDate.AddDays(diff);
            settings.currentDate = settings.currentDate.AddDays(settings.weeks * 7);
        }
    }
}
