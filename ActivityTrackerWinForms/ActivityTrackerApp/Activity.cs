using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ActivityTrackerWinForms.ActivityTrackerApp
{
    [DataContract]
    public class Activity
    {
        [DataMember]
        public uint Steps { get; set; }
        [DataMember]
        public double Distance { get; set; }
        [DataMember]
        public byte SleepTimeHour { get; set; }
        [DataMember]
        public byte SleepTimeMinute { get; set; }
        [DataMember]
        public byte StartSleepHour { get; set; }
        [DataMember]
        public byte StartSleepMinute { get; set; }
        [DataMember]
        public byte EndSleepHour { get; set; }
        [DataMember]
        public byte EndSleepMinute { get; set; }
        [DataMember]
        public uint WaterCounter { get; set; }
        [DataMember]
        public List<string> Exercices { get; set; }
        [DataMember]
        public List<string> SavedExercices { get; set; }
        [DataMember]
        public DateTime Date { get; set; }

        public Activity()
        {
            Exercices = new List<string>();
            SavedExercices = new List<string>();
            Date = DateTime.Now;
        }

        public void AddWater()
        {
            WaterCounter++;
        }

        public void RemoveWater()
        {
            if (WaterCounter > 0)
            {
                WaterCounter--;
            }
        }

        public string FixSleepTime()
        {
            if (StartSleepHour < EndSleepHour)
            {
                SleepTimeHour = (byte)(EndSleepHour - StartSleepHour);
                SleepTimeMinute = (byte)(Math.Abs(EndSleepMinute - StartSleepMinute));
            }
            else
            {
                SleepTimeMinute = (byte)((60 - StartSleepMinute) + EndSleepMinute);
                SleepTimeHour = (byte)((24 - StartSleepHour) + EndSleepHour + (SleepTimeMinute / 60) - 1);

                SleepTimeMinute = (byte)(SleepTimeMinute % 60);
            }

            return $"{SleepTimeHour:00} ч. {SleepTimeMinute:00} мин.";
        }

        public void ConvertToDistance(uint height)
        {
            double stepValue = ((int)height / 4d) + 37;
            Distance = Math.Round((Steps * stepValue) / 100000, 2);
        }
    }
}
