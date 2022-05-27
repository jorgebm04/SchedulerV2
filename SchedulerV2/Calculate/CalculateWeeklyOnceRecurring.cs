namespace SchedulerV2
{
    public static class CalculateWeeklyOnceRecurring
    {
        public static void CalculateNextExecutionTime(Settings settings)
        {
            int lastDayOfWeek = settings.lastDay;
            int firstDayOfWeek = (int)settings.days.GetKey(0);
            int today = (int)settings.currentDate.DayOfWeek;
            int todayIndex = settings.days.IndexOfKey(today);

            //If today is a selected day
            if (settings.days.Contains(today))
            {
                if(today == lastDayOfWeek)
                {
                    if (settings.needToAddDay)
                    {
                        //Calculates de difference to go to the first day of the week and then add the weeks
                        int diff = firstDayOfWeek - today;
                        settings.currentDate=settings.currentDate.AddDays(diff);
                        settings.currentDate=settings.currentDate.AddDays(settings.weeks * 7);
                        ApplyDaily(settings);
                    }
                    else
                    {
                        ApplyDaily(settings);
                    }
                }
                else
                {
                    if (settings.needToAddDay)
                    {
                        int diff = (int)settings.days.GetKey(todayIndex + 1) - (int)settings.days.GetKey(todayIndex);
                        settings.currentDate = settings.currentDate.AddDays(diff);
                        ApplyDaily(settings);
                    }
                    else
                    {
                        ApplyDaily(settings);
                    }
                }
            } 
            else
            {
                if (today > settings.lastDay)
                {
                    int diff = firstDayOfWeek - today;
                    settings.currentDate = settings.currentDate.AddDays(diff);
                    settings.currentDate = settings.currentDate.AddDays(settings.weeks * 7);
                    ApplyDaily(settings);
                } else
                {
                    int diff = 0;
                    for(int i = 0; i <settings.days.Count; i++)
                    {
                        if (today < (int)settings.days.GetKey(i))
                        {
                            diff = (int)settings.days.GetKey(i) - today;
                            break;
                        }
                    }
                    settings.currentDate = settings.currentDate.AddDays(diff);
                    ApplyDaily(settings);
                }
            }
        }

        public static void ApplyDaily(Settings settings)
        {
            string calculated = settings.currentDate.ToString("dd/MM/yyyy") + " " + settings.occursOnceAtHour.ToString("HH:mm");
            settings.calculatedDate = DateTime.ParseExact(calculated, "dd/MM/yyyy HH:mm", null);
            settings.nextExecutionTime = calculated;
        }
    }
}
