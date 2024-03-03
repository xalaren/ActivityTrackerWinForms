using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ActivityTrackerWinForms.ActivityTrackerApp
{
    [DataContract]
    public class Activities
    {
        [DataMember]
        public List<Activity> CompletedActivities { get; private set; } = new List<Activity>();

        [DataMember]
        public Activity CurrentActivity { get; private set; } = new Activity();

        public Activities()
        {
        }

        public void CompleteActivity()
        {
            CompletedActivities.Add(CurrentActivity);
            CurrentActivity = new Activity();
        }
    }
}
