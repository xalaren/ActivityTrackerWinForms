using ActivityTrackerWinForms.ActivityTrackerApp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ActivityTrackerWinForms
{
    public partial class RegisterForm : Form
    {
        AppController appController;

        public RegisterForm(AppController ac)
        {
            InitializeComponent();
            appController = ac;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //Проверка текстовых полей на пустые значения
            foreach (var textBox in Controls)
            {
                if (textBox.GetType().Name == "TextBox")
                {
                    if (String.IsNullOrWhiteSpace((textBox as TextBox).Text))
                    {
                        MessageBox.Show("Заполните все поля!");
                        return;
                    }
                }
            }

            var name = nameTextBox.Text;
            var lastName = lastnameTextBox.Text;
            var nickname = nicknameTextBox.Text;
            var password = passwordTextBox.Text;
            var height = (uint)heightInput.Value;
            var weight = (uint)weightInput.Value;
            var age = (uint)ageInput.Value;

            if (appController.RegisterRequest(new User(name, lastName, nickname, password, height, weight, age)))
            {
                appController.Serialize();
                this.Close();
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
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
