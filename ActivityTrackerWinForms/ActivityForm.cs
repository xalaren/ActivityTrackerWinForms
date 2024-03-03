using ActivityTrackerWinForms.ActivityTrackerApp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ActivityTrackerWinForms
{
    public partial class ActivityForm : Form
    {
        private User user;
        private Activity activity;
        private Time time = new Time();
        private int completedExercIndex = 0;
        private ExerciecesForm exerciecesForm;

        public ActivityForm(User e)
        {
            InitializeComponent();
            user = e;
            activity = user.Activities.CurrentActivity;
            exerciecesForm = new ExerciecesForm();

            Init();
            Reset();
            LoadData();
        }

        private void Init()
        {
            editSleepButton.Hide();
            stepsTextBox.LostFocus += StepsTextBox_LostFocus;
            stepsTextBox.TextChanged += AnyTextBoxChanged;
            sleepStartHours.TextChanged += AnyTextBoxChanged;
            sleepStartMinutes.TextChanged += AnyTextBoxChanged;
            sleepEndHours.TextChanged += AnyTextBoxChanged;
            sleepEndMinutes.TextChanged += AnyTextBoxChanged;

            dateLabel.Text = activity.Date.ToShortDateString();
        }

        private void Reset()
        {
            stepsTextBox.Text = "0";
            distanceLabel.Text = "0 км.";
            sleepStartHours.Text = "00";
            sleepStartMinutes.Text = "00";
            sleepEndHours.Text = "00";
            sleepEndMinutes.Text = "00";
            waterLabel.Text = "0 стак.";
            sleepLabel.Text = "0 ч. 0 мин.";
            timerLabel.Text = "00:00.00";
            dateLabel.Text = DateTime.Now.ToShortDateString();
            exercTextBox.Clear();
            exercsListBox.Items.Clear();
            exerciecesForm.exercHistoryListBox.Items.Clear();
        }

        private void LoadData()
        {
            stepsTextBox.Text = activity.Steps.ToString();

            EnterDistance();

            sleepStartHours.Text = $"{activity.StartSleepHour:00}";
            sleepStartMinutes.Text = $"{activity.StartSleepMinute:00}";
            sleepEndHours.Text = $"{activity.EndSleepHour:00}";
            sleepEndMinutes.Text = $"{activity.EndSleepMinute:00}";
            waterLabel.Text = $"{activity.WaterCounter} стак.";
            sleepLabel.Text = $"{activity.SleepTimeHour} ч. {activity.SleepTimeMinute} мин.";
            timerLabel.Text = "00:00.00";

            activity.Date = DateTime.Now;
            dateLabel.Text = activity.Date.ToShortDateString();

            foreach (var item in activity.Exercices)
            {
                exercsListBox.Items.Add(item);
            }

            foreach (var item in activity.SavedExercices)
            {
                exerciecesForm.exercHistoryListBox.Items.Add(item);
            }
        }

        private void EnterDistance()
        {
            activity.Steps = uint.Parse(stepsTextBox.Text);
            activity.ConvertToDistance(user.Height);
            distanceLabel.Text = $"{activity.Distance} км.";
        }

        private void AnyTextBoxChanged(object sender, EventArgs e)
        {
            var textBoxSender = sender as TextBox;
            foreach (var letter in textBoxSender.Text)
            {
                if (!Char.IsDigit(letter))
                {
                    textBoxSender.Text = textBoxSender.Text.Replace(letter.ToString(), "");
                    textBoxSender.SelectionStart = textBoxSender.TextLength;
                }
            }

            if (textBoxSender.Name == "sleepStartHours" || textBoxSender.Name == "sleepEndHours")
            {
                if (String.IsNullOrWhiteSpace(textBoxSender.Text))
                {
                    textBoxSender.Text = "00";
                }

                if (int.Parse(textBoxSender.Text) > 23)
                {
                    textBoxSender.Text = "00";
                    textBoxSender.SelectionStart = textBoxSender.TextLength;
                }

                activity.StartSleepHour = byte.Parse(sleepStartHours.Text);
                activity.EndSleepHour = byte.Parse(sleepEndHours.Text);
            }

            if (textBoxSender.Name == "sleepStartMinutes" || textBoxSender.Name == "sleepEndMinutes")
            {
                if (String.IsNullOrWhiteSpace(textBoxSender.Text))
                {
                    textBoxSender.Text = "00";
                }

                if (int.Parse(textBoxSender.Text) > 59)
                {
                    textBoxSender.Text = "00";
                    textBoxSender.SelectionStart = textBoxSender.TextLength;
                }

                activity.StartSleepMinute = byte.Parse(sleepStartMinutes.Text);
                activity.EndSleepMinute = byte.Parse(sleepEndMinutes.Text);
            }
        }

        private void StepsTextBox_LostFocus(object sender, EventArgs e)
        {
            EnterDistance();
        }

        private void fixButton_Click(object sender, EventArgs e)
        {
            sleepPanel2.Hide();
            editSleepButton.Show();

            activity.StartSleepHour = byte.Parse(sleepStartHours.Text);
            activity.StartSleepMinute = byte.Parse(sleepStartMinutes.Text);
            activity.EndSleepHour = byte.Parse(sleepEndHours.Text);
            activity.EndSleepMinute = byte.Parse(sleepEndMinutes.Text);

            sleepLabel.Text = activity.FixSleepTime();
        }

        private void editSleepButton_Click(object sender, EventArgs e)
        {
            editSleepButton.Hide();
            sleepPanel2.Show();
        }

        private void waterAddButton_Click(object sender, EventArgs e)
        {
            if (activity.WaterCounter < 256)
            {
                activity.AddWater();
                waterLabel.Text = $"{activity.WaterCounter} стак.";
            }
        }

        private void waterRemoveButton_Click(object sender, EventArgs e)
        {
            activity.RemoveWater();
            waterLabel.Text = $"{activity.WaterCounter} стак.";
        }

        private void exercAddButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(exercTextBox.Text))
            {
                activity.Exercices.Add(exercTextBox.Text);
                exercsListBox.Items.Add(exercTextBox.Text);
                exercTextBox.Clear();
            }
        }

        private void exercRemoveButton_Click(object sender, EventArgs e)
        {
            if (exercsListBox.SelectedIndex > -1)
            {
                activity.Exercices.Remove(exercsListBox.SelectedItem.ToString());
                exercsListBox.Items.Remove(exercsListBox.SelectedItem.ToString());
            }
        }

        private void startTimerButton_Click(object sender, EventArgs e)
        {
            if (exercsListBox.SelectedIndex > -1)
            {
                timer1.Start();
            }
        }

        private void stopTimerButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (exercsListBox.SelectedIndex > -1)
            {
                completedExercIndex++;
                var completedExerc = $"{completedExercIndex}. \t\t\t{exercsListBox.SelectedItem}{new String('\t', 4)}{timerLabel.Text}";
                activity.SavedExercices.Add(completedExerc);
                exerciecesForm.exercHistoryListBox.Items.Add(completedExerc);
            }
        }

        private void resetTimerButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timerLabel.Text = "00:00.00";
            time.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.SetTime();
            timerLabel.Text = time.GetTime();
        }

        private void showSavedExercsButton_Click(object sender, EventArgs e)
        {
            exerciecesForm.ShowDialog();
        }

        private void saveResultsButton_Click(object sender, EventArgs e)
        {
            EnterDistance();
            user.Activities.CompleteActivity();
            Reset();
        }

        private void statButton_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm(user.Activities);
            statisticsForm.ShowDialog();
        }

        private void ActivityForm_Load(object sender, EventArgs e)
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
                        if (c is Panel)
                        {
                            foreach (var c1 in (c as Panel).Controls)
                            {
                                var control1 = c1 as Control;
                                control1.Font = new Font(FontClass.Font1.Families[0], control1.Font.Size, control1.Font.Style);
                            }
                            continue;
                        }
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

        private void stepsTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                EnterDistance();
            }
        }
    }
}
