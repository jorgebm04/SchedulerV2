namespace SchedulerV2
{
    public class OccursEveryChecker
    {
        public static bool CheckOccursEveryComboBox (int index)
        {
            if (index == -1)
            {
                return false;
            }
            return true;
        }

        public static bool CheckOccursEveryLimits(DateTime start, DateTime end)
        {
            if(DateTime.Compare(start, end) > 0)
            {
                return false;
            }
            return true;
        }
    }
}
