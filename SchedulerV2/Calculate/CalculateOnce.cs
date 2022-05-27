namespace SchedulerV2
{
    public static class CalculateOnce
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            settings.calculatedDate = settings.onceTimeAt;
            settings.nextExecutionTime = settings.onceTimeAt.ToString();
        }
    }
}
