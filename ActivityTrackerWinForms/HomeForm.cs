using ActivityTrackerWinForms.ActivityTrackerApp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ActivityTrackerWinForms
{
    public partial class HomeForm : Form
    {
        private AppController appController;

        public HomeForm(AppController ac)
        {
            InitializeComponent();

            appController = ac;

        }

        private void LaunchForm(Form form)
        {
            Visible = false;
            form.FormClosed += OtherForms_FormClosed;
            form.Show();
        }

        private void OtherForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (appController.Profiles.ActiveUser != null)
            {
                Visible = true;
            }
            else
            {
                Close();
            }
        }

        private void myprofileButton_Click(object sender, EventArgs e)
        {
            LaunchForm(new ProfileForm(appController));
        }

        private void tasksButton_Click(object sender, EventArgs e)
        {
            LaunchForm(new TasksForm(appController.Profiles.ActiveUser.TasksList));
        }

        private void activityButton_Click(object sender, EventArgs e)
        {
            LaunchForm(new ActivityForm(appController.Profiles.ActiveUser));
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            foreach (var c in Controls)
            {
                var control = c as Control;

                control.Font = new Font(FontClass.Font1.Families[0], control.Font.Size, FontStyle.Regular);
            }

            foreach (var c in mainPanel.Controls)
            {
                var control = c as Control;

                control.Font = new Font(FontClass.Font1.Families[0], control.Font.Size, FontStyle.Regular);
            }

            label1.Font = new Font(FontClass.Font2.Families[0], label1.Font.Size, label1.Font.Style);
        }
    }
}
