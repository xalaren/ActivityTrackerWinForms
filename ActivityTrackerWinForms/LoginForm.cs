using ActivityTrackerWinForms.ActivityTrackerApp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ActivityTrackerWinForms
{
    public partial class LoginForm : Form
    {
        private AppController appController;

        public LoginForm()
        {
            InitializeComponent();
            appController = new AppController();
            appController.Deserialize();

        }

        private void LaunchForm(Form form)
        {
            this.Visible = false;
            form.FormClosed += OtherForms_FormClosed;
            form.Show();
        }

        private void ClearControls()
        {
            nicknameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LaunchForm(new RegisterForm(appController));
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var nickname = nicknameTextBox.Text;
            var password = passwordTextBox.Text;

            if (String.IsNullOrWhiteSpace(nickname) || String.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            if (appController.LoginRequest(nickname, password))
            {
                ClearControls();
                LaunchForm(new HomeForm(appController));
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль");
            }
        }

        private void OtherForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
            appController.Serialize();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            foreach (var c in Controls)
            {
                var control = c as Control;
                control.Font = new Font(FontClass.Font1.Families[0], control.Font.Size, FontStyle.Regular);
            }
            label1.Font = new Font(FontClass.Font2.Families[0], label1.Font.Size, label1.Font.Style);
        }
    }
}
