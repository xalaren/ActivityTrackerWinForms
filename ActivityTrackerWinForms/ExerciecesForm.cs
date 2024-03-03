using ActivityTrackerWinForms.ActivityTrackerApp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ActivityTrackerWinForms
{
    public partial class ExerciecesForm : Form
    {
        public ExerciecesForm()
        {
            InitializeComponent();
        }

        private void ExerciecesForm_Load(object sender, EventArgs e)
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
