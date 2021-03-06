namespace SchedulerV2
{
    public static class CheckRecurringSettings
    {
        public static void CheckSettings (Settings settings)
        {
            switch (settings.occurs)
            {
                case (int)OccursEnum.Occurs.Daily:
                    CheckDailySettings.CheckRecurringDailySettings(settings);
                    break;
                case (int)OccursEnum.Occurs.Weekly:
                    CheckWeeklySettings.CheckRecurrentWeeklySettings(settings);
                    break;
                default:
                    settings.nextExecutionTime = "Select and occurrence.";
                    break;
            }
        }
    }
}
