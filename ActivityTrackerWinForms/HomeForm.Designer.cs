namespace ActivityTrackerWinForms
{
    partial class HomeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.myprofileButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.activityButton = new System.Windows.Forms.Button();
            this.tasksButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(113, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "ГЛАВНАЯ";
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.backPanel;
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.myprofileButton);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.activityButton);
            this.mainPanel.Controls.Add(this.tasksButton);
            this.mainPanel.Location = new System.Drawing.Point(28, 115);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(443, 290);
            this.mainPanel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Roboto", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.label2.Location = new System.Drawing.Point(123, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Мой профиль";
            // 
            // myprofileButton
            // 
            this.myprofileButton.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.button2;
            this.myprofileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myprofileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.myprofileButton.FlatAppearance.BorderSize = 0;
            this.myprofileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.myprofileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.myprofileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myprofileButton.Location = new System.Drawing.Point(19, 14);
            this.myprofileButton.Name = "myprofileButton";
            this.myprofileButton.Size = new System.Drawing.Size(70, 70);
            this.myprofileButton.TabIndex = 3;
            this.myprofileButton.UseVisualStyleBackColor = true;
            this.myprofileButton.Click += new System.EventHandler(this.myprofileButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Roboto", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.label3.Location = new System.Drawing.Point(123, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Активность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Roboto", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.label4.Location = new System.Drawing.Point(120, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Задачи";
            // 
            // activityButton
            // 
            this.activityButton.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.button3;
            this.activityButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activityButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.activityButton.FlatAppearance.BorderSize = 0;
            this.activityButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.activityButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.activityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activityButton.Location = new System.Drawing.Point(19, 110);
            this.activityButton.Name = "activityButton";
            this.activityButton.Size = new System.Drawing.Size(70, 70);
            this.activityButton.TabIndex = 4;
            this.activityButton.UseVisualStyleBackColor = true;
            this.activityButton.Click += new System.EventHandler(this.activityButton_Click);
            // 
            // tasksButton
            // 
            this.tasksButton.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.button4;
            this.tasksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tasksButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tasksButton.FlatAppearance.BorderSize = 0;
            this.tasksButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.tasksButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.tasksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tasksButton.Location = new System.Drawing.Point(16, 214);
            this.tasksButton.Name = "tasksButton";
            this.tasksButton.Size = new System.Drawing.Size(70, 70);
            this.tasksButton.TabIndex = 5;
            this.tasksButton.UseVisualStyleBackColor = true;
            this.tasksButton.Click += new System.EventHandler(this.tasksButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.Text = "Activity Tracker";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button myprofileButton;
        private System.Windows.Forms.Button activityButton;
        private System.Windows.Forms.Button tasksButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel mainPanel;
    }
}

