namespace SchedulerV2
{
    public static class OnceCurrentDateChecker
    {
        public static bool CheckOnceCurrentDate(DateTime currentDate)
        {
            if (!currentDate.ToString("dd/MM/yyyy").Equals(DateTime.Today.ToString("dd/MM/yyyy")))
            {
                return false;
            }
            return true;
        }
    }
}
