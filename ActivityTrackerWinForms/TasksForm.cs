using ActivityTrackerWinForms.ActivityTrackerApp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ActivityTrackerWinForms
{
    public partial class TasksForm : Form
    {
        private TasksList tasksList;

        public TasksForm(TasksList e)
        {
            InitializeComponent();
            tasksList = e;

            Init();
            LoadTasks();
        }

        private void Init()
        {
            addTextBox.Hide();
            addTextBox.Clear();

            activetasksListBox.MouseDown += TasksForm_MouseDown;
            completedTasksListBox.MouseDown += TasksForm_MouseDown;
        }

        private void LoadTasks()
        {
            foreach (var item in tasksList.ActiveTasks)
            {
                activetasksListBox.Items.Add(item);
            }

            foreach (var item in tasksList.CompletedTasks)
            {
                completedTasksListBox.Items.Add(item);
            }
        }

        private void EnterText()
        {
            var taskDescription = addTextBox.Text;

            if (!String.IsNullOrWhiteSpace(taskDescription))
            {
                activetasksListBox.Items.Add(taskDescription);
                tasksList.ActiveTasks.Add(taskDescription);
            }

            addTextBox.Hide();
            addTextBox.Clear();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addTextBox.Show();
            addTextBox.Focus();

        }

        private void TasksForm_MouseDown(object sender, MouseEventArgs e)
        {
            EnterText();
        }

        private void addTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                EnterText();
            }
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            if (activetasksListBox.SelectedIndex > -1)
            {
                completedTasksListBox.Items.Add(activetasksListBox.SelectedItem);
                tasksList.CompleteTask(activetasksListBox.SelectedItem.ToString());
                activetasksListBox.Items.Remove(activetasksListBox.SelectedItem);
            }
        }

        private void deleteActiveButton_Click(object sender, EventArgs e)
        {
            if (activetasksListBox.SelectedIndex > -1)
            {
                tasksList.RemoveActiveTask(activetasksListBox.SelectedItem.ToString());
                activetasksListBox.Items.Remove(activetasksListBox.SelectedItem);
            }
        }

        private void deleteCompletedButton_Click(object sender, EventArgs e)
        {
            if (completedTasksListBox.SelectedIndex > -1)
            {
                tasksList.RemoveCompletedTask(completedTasksListBox.SelectedItem.ToString());
                completedTasksListBox.Items.Remove(completedTasksListBox.SelectedItem);
            }
        }

        private void TasksForm_Load(object sender, EventArgs e)
        {
            foreach (var c in Controls)
            {
                var control = c as Control;

                control.Font = new Font(FontClass.Font1.Families[0], control.Font.Size, control.Font.Style);
            }

            label1.Font = new Font(FontClass.Font2.Families[0], label1.Font.Size, label1.Font.Style);
        }
    }
}
