namespace SchedulerV2
{
    public static class OnceTimeAtChecker
    {
        public static bool CheckOnceTimeAt(DateTime time, DateTime currentDate)
        {
            if (DateTime.Compare(time, currentDate) < 0)
            {
                return false;
            }
            return true;
        }
    }
}
