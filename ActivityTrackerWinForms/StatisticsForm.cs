using ActivityTrackerWinForms.ActivityTrackerApp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ActivityTrackerWinForms
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm(Activities activities)
        {
            InitializeComponent();

            var text = "";
            foreach (var ac in activities.CompletedActivities)
            {
                text += $"\n\n{ac.Date.ToShortDateString()}\n\n" +
                    $"    Количество шагов: {ac.Steps}\n" +
                    $"    Пройденное расстояние: {ac.Distance} км.\n" +
                    $"    Длительность сна: {ac.SleepTimeHour} ч. {ac.SleepTimeMinute} мин.\n" +
                    $"    Количество выпитой воды: {ac.WaterCounter} стак.\n" +
                    $"    Упражнения:\n";

                for (int i = 0; i < ac.SavedExercices.Count; i++)
                {
                    text += $"           {ac.SavedExercices[i]}";
                }
            }

            statsTextBox.Text = text;
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
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

            label1.Font = new Font(FontClass.Font2.Families[0], label1.Font.Size, label1.Font.Style);
        }
    }
}
