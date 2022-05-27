using System.Collections;

namespace SchedulerV2
{
    public class Settings
    {
        public DateTime currentDate { get; set; }
        public int type { get; set; }
        public bool enabled { get; set; }
        public DateTime onceTimeAt { get; set; }
        public int occurs { get; set; }
        public int weeks { get; set; }
        public bool monday { get; set; }
        public bool tuesday { get; set; }
        public bool wednesday { get; set; }
        public bool thursday { get; set; }
        public bool friday { get; set; }
        public bool saturday { get; set; }
        public bool sunday { get; set; }    
        public bool occursOnceAt { get; set; }
        public DateTime occursOnceAtHour { get; set; }
        public bool occursEvery { get; set; }
        public int occursEveryFreq { get; set; }
        public int freq { get; set; }
        public string freqTime { get; set; }
        public DateTime startingHour { get; set; }
        public DateTime endingHour { get; set; }
        public DateTime startingLimit { get; set; }
        public DateTime endingLimit { get; set; }
        public String nextExecutionTime { get; set; }
        public String description { get; set; }
        public DateTime calculatedDate { get; set; }
        public bool needToAddDay { get; set; }
        public int lastDay { get; set; }
        public SortedList days = new SortedList();
    }
}