namespace SchedulerV2
{
    public class OccursOnceAtChecker
    {
        public static bool CheckOccursOnceAt(DateTime currentDate, DateTime hour)
        {
            if (TimeSpan.Compare(currentDate.TimeOfDay, hour.TimeOfDay) < 0)
            {
                return false;
            }
            return true;
        }
    }
}
