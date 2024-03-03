namespace ActivityTrackerWinForms
{
    public class Time
    {
        public int Milliseconds { get; set; }
        public int Seconds { get; set; }
        public int Minutes { get; set; }

        public void Clear()
        {
            Milliseconds = 0;
            Seconds = 0;
            Minutes = 0;
        }

        public string GetTime()
        {
            return $"{Minutes:00}:{Seconds:00}.{Milliseconds:00}";
        }

        public void SetTime()
        {
            if (Milliseconds <= 100)
            {
                Milliseconds++;
            }
            else if (Seconds <= 60)
            {
                Milliseconds = 0;
                Seconds++;
            }
            else if (Minutes <= 60)
            {
                Seconds = 0;
                Minutes++;
            }
        }
    }
}
