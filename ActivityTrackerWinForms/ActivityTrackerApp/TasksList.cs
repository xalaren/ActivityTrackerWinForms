using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ActivityTrackerWinForms.ActivityTrackerApp
{
    [DataContract]
    public class TasksList
    {
        [DataMember]
        public List<string> ActiveTasks { get; set; }
        [DataMember]
        public List<string> CompletedTasks { get; set; }

        public TasksList()
        {
            ActiveTasks = new List<string>();
            CompletedTasks = new List<string>();
        }

        public void AddTask(string taskDescription)
        {
            if (String.IsNullOrWhiteSpace(taskDescription))
            {
                return;
            }

            ActiveTasks.Add(taskDescription);
        }

        public void CompleteTask(string taskDescription)
        {
            if (String.IsNullOrWhiteSpace(taskDescription))
            {
                return;
            }

            RemoveActiveTask(taskDescription);
            CompletedTasks.Add(taskDescription);
        }

        public void RemoveActiveTask(string taskDescription)
        {
            if (ActiveTasks.Contains(taskDescription))
            {
                ActiveTasks.Remove(taskDescription);
            }
        }

        public void RemoveCompletedTask(string taskDescription)
        {
            if (CompletedTasks.Contains(taskDescription))
            {
                CompletedTasks.Remove(taskDescription);
            }
        }
    }
}
