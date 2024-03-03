using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
namespace ActivityTrackerWinForms.ActivityTrackerApp
{
    [DataContract]
    public class AppController
    {
        private Files files;

        private Accounts accounts;

        [DataMember]
        public Accounts Profiles
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public AppController()
        {
            files = new Files();
            accounts = new Accounts();
        }

        public void Serialize()
        {
            files.ToCatalog("SavedData");
            var jsonFormatter = new DataContractJsonSerializer(typeof(Accounts));

            using (var file = new FileStream(files.DirectoryPath + @"\Accounts.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(file, accounts);
            }
        }

        public void Deserialize()
        {
            files.ToCatalog("SavedData");
            var jsonFormatter = new DataContractJsonSerializer(typeof(Accounts));

            if (File.Exists(files.DirectoryPath + @"\Accounts.json"))
            {
                using (var file = new FileStream(files.DirectoryPath + @"\Accounts.json", FileMode.OpenOrCreate))
                {
                    object data = jsonFormatter.ReadObject(file);

                    if (data != null)
                    {
                        accounts = data as Accounts;
                    }
                }
            }
        }

        public bool RegisterRequest(User user)
        {
            return accounts.Add(user);
        }

        public bool LoginRequest(string nickName, string password)
        {
            foreach (var user in accounts.Users)
            {
                if (String.Equals(nickName, user.NickName) && String.Equals(password, user.Password))
                {
                    accounts.ActiveUser = user;
                    return true;
                }
            }

            return false;
        }

        public void LogoutRequest()
        {
            accounts.ActiveUser = null;
        }
    }
}
