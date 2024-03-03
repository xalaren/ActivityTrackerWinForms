using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ActivityTrackerWinForms.ActivityTrackerApp
{
    [DataContract]
    public class Accounts
    {
        [DataMember]
        private List<User> users = new List<User>();

        [DataMember]
        public List<User> Users
        {
            get { return users; }
            private set { users = value; }
        }

        [DataMember]
        public User ActiveUser { get; set; }

        public bool Add(User user)
        {
            if (users.Count > 0)
            {
                foreach (var item in users)
                {
                    if (user.NickName == item.NickName)
                    {
                        return false;
                    }
                }
            }

            users.Add(user);
            return true;
        }

        public void Delete(User user)
        {
            if (users.Contains(user))
            {
                users.Remove(user);
            }
        }
    }
}
