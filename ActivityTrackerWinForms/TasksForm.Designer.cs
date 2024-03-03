namespace ActivityTrackerWinForms
{
    partial class TasksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.activetasksListBox = new System.Windows.Forms.ListBox();
            this.completedTasksListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.deleteActiveButton = new System.Windows.Forms.Button();
            this.completeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteCompletedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "ЗАДАЧИ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(24, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Запланированные";
            // 
            // activetasksListBox
            // 
            this.activetasksListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.activetasksListBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activetasksListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.activetasksListBox.FormattingEnabled = true;
            this.activetasksListBox.ItemHeight = 19;
            this.activetasksListBox.Location = new System.Drawing.Point(28, 147);
            this.activetasksListBox.Name = "activetasksListBox";
            this.activetasksListBox.Size = new System.Drawing.Size(317, 475);
            this.activetasksListBox.TabIndex = 3;
            // 
            // completedTasksListBox
            // 
            this.completedTasksListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.completedTasksListBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completedTasksListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.completedTasksListBox.FormattingEnabled = true;
            this.completedTasksListBox.ItemHeight = 19;
            this.completedTasksListBox.Location = new System.Drawing.Point(442, 147);
            this.completedTasksListBox.Name = "completedTasksListBox";
            this.completedTasksListBox.Size = new System.Drawing.Size(317, 475);
            this.completedTasksListBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(438, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Выполненные";
            // 
            // addTextBox
            // 
            this.addTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.addTextBox.Location = new System.Drawing.Point(28, 109);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(281, 27);
            this.addTextBox.TabIndex = 0;
            this.addTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.addTextBox_PreviewKeyDown);
            // 
            // deleteActiveButton
            // 
            this.deleteActiveButton.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.button7;
            this.deleteActiveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteActiveButton.FlatAppearance.BorderSize = 0;
            this.deleteActiveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.deleteActiveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deleteActiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteActiveButton.Location = new System.Drawing.Point(295, 559);
            this.deleteActiveButton.Name = "deleteActiveButton";
            this.deleteActiveButton.Size = new System.Drawing.Size(50, 50);
            this.deleteActiveButton.TabIndex = 17;
            this.deleteActiveButton.UseVisualStyleBackColor = true;
            this.deleteActiveButton.Click += new System.EventHandler(this.deleteActiveButton_Click);
            // 
            // completeButton
            // 
            this.completeButton.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.button8;
            this.completeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.completeButton.FlatAppearance.BorderSize = 0;
            this.completeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.completeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.completeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeButton.Location = new System.Drawing.Point(295, 503);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(50, 50);
            this.completeButton.TabIndex = 16;
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.button6;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(295, 447);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(50, 50);
            this.addButton.TabIndex = 15;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteCompletedButton
            // 
            this.deleteCompletedButton.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.button7;
            this.deleteCompletedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCompletedButton.FlatAppearance.BorderSize = 0;
            this.deleteCompletedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.deleteCompletedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deleteCompletedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCompletedButton.Location = new System.Drawing.Point(709, 559);
            this.deleteCompletedButton.Name = "deleteCompletedButton";
            this.deleteCompletedButton.Size = new System.Drawing.Size(50, 50);
            this.deleteCompletedButton.TabIndex = 18;
            this.deleteCompletedButton.UseVisualStyleBackColor = true;
            this.deleteCompletedButton.Click += new System.EventHandler(this.deleteCompletedButton_Click);
            // 
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.deleteActiveButton);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteCompletedButton);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.completedTasksListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.activetasksListBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TasksForm";
            this.Text = "Трекер активности";
            this.Load += new System.EventHandler(this.TasksForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TasksForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox activetasksListBox;
        private System.Windows.Forms.ListBox completedTasksListBox;
        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Button deleteActiveButton;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Button deleteCompletedButton;
    }
}