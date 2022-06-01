namespace SchedulerV2
{
    public static class DaysAdder
    {
        public static void NextDay(Settings settings,int todayIndex)
        {
            int diff = (int)settings.days.GetKey(todayIndex + 1) - (int)settings.days.GetKey(todayIndex);
            settings.currentDate = settings.currentDate.AddDays(diff);
        }

        public static void NextAvaibleDay(Settings settings, int today)
        {
            int diff = 0;
            for (int i = 0; i < settings.days.Count; i++)
            {
                if (today < (int)settings.days.GetKey(i))
                {
                    diff = (int)settings.days.GetKey(i) - today;
                    break;
                }
            }
            settings.currentDate = settings.currentDate.AddDays(diff);
        }
    }
}
