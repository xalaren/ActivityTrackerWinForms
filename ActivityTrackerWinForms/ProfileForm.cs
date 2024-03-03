using ActivityTrackerWinForms.ActivityTrackerApp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ActivityTrackerWinForms
{
    public partial class ProfileForm : Form
    {
        private User user;
        private AppController appController;

        public ProfileForm(AppController ac)
        {
            InitializeComponent();
            appController = ac;
            user = ac.Profiles.ActiveUser;

            FillData();
        }

        public void FillData()
        {
            if (this.user == null)
            {
                return;
            }

            if (user.Age == 1)
            {
                label7.Text = "год";
            }
            else if (user.Age > 1 & user.Age < 5)
            {
                label7.Text = "года";
            }
            else
            {
                label7.Text = "лет";
            }

            nameLabel.Text = user.Name;
            lastnameLabel.Text = user.LastName;
            nicknameLabel.Text = "@" + user.NickName;
            heightLabel.Text = user.Height.ToString();
            weightLabel.Text = user.Weight.ToString();
            ageLabel.Text = user.Age.ToString();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            appController.LogoutRequest();
            this.Close();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            foreach (var c in Controls)
            {
                if (c is Timer)
                {
                    continue;
                }

                var control = c as Control;
                control.Font = new Font(FontClass.Font1.Families[0], control.Font.Size, control.Font.Style);
            }

            foreach (var p in Controls)
            {
                if (p is Panel)
                {
                    foreach (var c in (p as Panel).Controls)
                    {
                        var control = c as Control;

                        if (control.Font.Bold)
                        {
                            control.Font = new Font(FontClass.Font3.Families[0], control.Font.Size, FontStyle.Bold);
                        }
                        else
                        {
                            control.Font = new Font(FontClass.Font1.Families[0], control.Font.Size, control.Font.Style);
                        }
                    }
                }
            }


            label1.Font = new Font(FontClass.Font2.Families[0], label1.Font.Size, label1.Font.Style);
        }
    }
}
