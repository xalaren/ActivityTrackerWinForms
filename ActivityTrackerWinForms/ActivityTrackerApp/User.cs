using System.Runtime.Serialization;

namespace ActivityTrackerWinForms.ActivityTrackerApp
{
    [DataContract]
    public class User
    {
        [DataMember]
        private uint height;
        [DataMember]
        private uint weight;
        [DataMember]
        private uint age;

        [DataMember]
        public string Name { get; private set; }
        [DataMember]
        public string LastName { get; private set; }
        [DataMember]
        public string NickName { get; private set; }
        [DataMember]
        public string Password { get; private set; }
        [DataMember]
        public Activities Activities { get; set; }

        [DataMember]
        public TasksList TasksList { get; set; }

        [DataMember]
        public uint Height
        {
            get { return height; }
            set { height = value; }
        }

        [DataMember]
        public uint Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        [DataMember]
        public uint Age
        {
            get { return age; }
            set { age = value; }
        }

        public User(
            string name, string lastName,
            string nickName, string password,
            uint height, uint weight, uint age)
        {
            Name = name;
            LastName = lastName;
            NickName = nickName;
            Password = password;
            Height = height;
            Weight = weight;
            Age = age;
            TasksList = new TasksList();
            Activities = new Activities();
        }
    }
}
