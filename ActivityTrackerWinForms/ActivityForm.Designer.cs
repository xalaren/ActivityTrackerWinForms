namespace ActivityTrackerWinForms
{
    partial class ActivityForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statButton = new System.Windows.Forms.Button();
            this.saveResultsButton = new System.Windows.Forms.Button();
            this.exercPanel = new System.Windows.Forms.Panel();
            this.resetTimerButton = new System.Windows.Forms.Button();
            this.exercTextBox = new System.Windows.Forms.TextBox();
            this.showSavedExercsButton = new System.Windows.Forms.Button();
            this.exercRemoveButton = new System.Windows.Forms.Button();
            this.stopTimerButton = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.startTimerButton = new System.Windows.Forms.Button();
            this.exercsListBox = new System.Windows.Forms.ListBox();
            this.exercAddButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.waterRemoveButton = new System.Windows.Forms.Button();
            this.waterLabel = new System.Windows.Forms.Label();
            this.waterAddButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.sleepPanel1 = new System.Windows.Forms.Panel();
            this.editSleepButton = new System.Windows.Forms.Button();
            this.sleepPanel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sleepEndMinutes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sleepStartMinutes = new System.Windows.Forms.TextBox();
            this.sleepStartHours = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sleepEndHours = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fixButton = new System.Windows.Forms.Button();
            this.sleepLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.stepsPanel = new System.Windows.Forms.Panel();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.stepsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exercPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.sleepPanel1.SuspendLayout();
            this.sleepPanel2.SuspendLayout();
            this.stepsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "АКТИВНОСТЬ";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateLabel.Font = new System.Drawing.Font("Roboto", 16F);
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dateLabel.Location = new System.Drawing.Point(22, 625);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(120, 27);
            this.dateLabel.TabIndex = 21;
            this.dateLabel.Text = "01.01.2022";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statButton
            // 
            this.statButton.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.button14;
            this.statButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statButton.FlatAppearance.BorderSize = 0;
            this.statButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.statButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.statButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.statButton.ForeColor = System.Drawing.Color.White;
            this.statButton.Location = new System.Drawing.Point(810, 598);
            this.statButton.Name = "statButton";
            this.statButton.Size = new System.Drawing.Size(150, 50);
            this.statButton.TabIndex = 20;
            this.statButton.Text = "Статистика";
            this.statButton.UseVisualStyleBackColor = true;
            this.statButton.Click += new System.EventHandler(this.statButton_Click);
            // 
            // saveResultsButton
            // 
            this.saveResultsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveResultsButton.BackgroundImage")));
            this.saveResultsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveResultsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveResultsButton.FlatAppearance.BorderSize = 0;
            this.saveResultsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.saveResultsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.saveResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveResultsButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.saveResultsButton.ForeColor = System.Drawing.Color.White;
            this.saveResultsButton.Location = new System.Drawing.Point(574, 598);
            this.saveResultsButton.Name = "saveResultsButton";
            this.saveResultsButton.Size = new System.Drawing.Size(210, 50);
            this.saveResultsButton.TabIndex = 19;
            this.saveResultsButton.Text = "Сохранить результаты";
            this.saveResultsButton.UseVisualStyleBackColor = true;
            this.saveResultsButton.Click += new System.EventHandler(this.saveResultsButton_Click);
            // 
            // exercPanel
            // 
            this.exercPanel.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.backPanel3;
            this.exercPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exercPanel.Controls.Add(this.resetTimerButton);
            this.exercPanel.Controls.Add(this.exercTextBox);
            this.exercPanel.Controls.Add(this.showSavedExercsButton);
            this.exercPanel.Controls.Add(this.exercRemoveButton);
            this.exercPanel.Controls.Add(this.stopTimerButton);
            this.exercPanel.Controls.Add(this.timerLabel);
            this.exercPanel.Controls.Add(this.startTimerButton);
            this.exercPanel.Controls.Add(this.exercsListBox);
            this.exercPanel.Controls.Add(this.exercAddButton);
            this.exercPanel.Controls.Add(this.label13);
            this.exercPanel.Location = new System.Drawing.Point(485, 86);
            this.exercPanel.Name = "exercPanel";
            this.exercPanel.Size = new System.Drawing.Size(487, 398);
            this.exercPanel.TabIndex = 18;
            // 
            // resetTimerButton
            // 
            this.resetTimerButton.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.cross;
            this.resetTimerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetTimerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetTimerButton.FlatAppearance.BorderSize = 0;
            this.resetTimerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.resetTimerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.resetTimerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetTimerButton.Location = new System.Drawing.Point(151, 322);
            this.resetTimerButton.Name = "resetTimerButton";
            this.resetTimerButton.Size = new System.Drawing.Size(20, 20);
            this.resetTimerButton.TabIndex = 20;
            this.resetTimerButton.UseVisualStyleBackColor = true;
            this.resetTimerButton.Click += new System.EventHandler(this.resetTimerButton_Click);
            // 
            // exercTextBox
            // 
            this.exercTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.exercTextBox.Location = new System.Drawing.Point(24, 63);
            this.exercTextBox.Name = "exercTextBox";
            this.exercTextBox.Size = new System.Drawing.Size(290, 27);
            this.exercTextBox.TabIndex = 23;
            // 
            // showSavedExercsButton
            // 
            this.showSavedExercsButton.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.button12;
            this.showSavedExercsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showSavedExercsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showSavedExercsButton.FlatAppearance.BorderSize = 0;
            this.showSavedExercsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.showSavedExercsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.showSavedExercsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSavedExercsButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showSavedExercsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(4)))), ((int)(((byte)(216)))));
            this.showSavedExercsButton.Location = new System.Drawing.Point(427, 9);
            this.showSavedExercsButton.Name = "showSavedExercsButton";
            this.showSavedExercsButton.Size = new System.Drawing.Size(35, 35);
            this.showSavedExercsButton.TabIndex = 22;
            this.showSavedExercsButton.UseVisualStyleBackColor = true;
            this.showSavedExercsButton.Click += new System.EventHandler(this.showSavedExercsButton_Click);
            // 
            // exercRemoveButton
            // 
            this.exercRemoveButton.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.button11;
            this.exercRemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exercRemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exercRemoveButton.FlatAppearance.BorderSize = 0;
            this.exercRemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.exercRemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.exercRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exercRemoveButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exercRemoveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(4)))), ((int)(((byte)(216)))));
            this.exercRemoveButton.Location = new System.Drawing.Point(235, 9);
            this.exercRemoveButton.Name = "exercRemoveButton";
            this.exercRemoveButton.Size = new System.Drawing.Size(35, 35);
            this.exercRemoveButton.TabIndex = 21;
            this.exercRemoveButton.UseVisualStyleBackColor = true;
            this.exercRemoveButton.Click += new System.EventHandler(this.exercRemoveButton_Click);
            // 
            // stopTimerButton
            // 
            this.stopTimerButton.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.button9;
            this.stopTimerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopTimerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopTimerButton.FlatAppearance.BorderSize = 0;
            this.stopTimerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.stopTimerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.stopTimerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopTimerButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopTimerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(4)))), ((int)(((byte)(216)))));
            this.stopTimerButton.Location = new System.Drawing.Point(342, 336);
            this.stopTimerButton.Name = "stopTimerButton";
            this.stopTimerButton.Size = new System.Drawing.Size(120, 40);
            this.stopTimerButton.TabIndex = 20;
            this.stopTimerButton.Text = "Стоп";
            this.stopTimerButton.UseVisualStyleBackColor = true;
            this.stopTimerButton.Click += new System.EventHandler(this.stopTimerButton_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.timerLabel.Location = new System.Drawing.Point(17, 336);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(143, 38);
            this.timerLabel.TabIndex = 18;
            this.timerLabel.Text = "00:00.00";
            // 
            // startTimerButton
            // 
            this.startTimerButton.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.button9;
            this.startTimerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startTimerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startTimerButton.FlatAppearance.BorderSize = 0;
            this.startTimerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.startTimerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.startTimerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startTimerButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTimerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(4)))), ((int)(((byte)(216)))));
            this.startTimerButton.Location = new System.Drawing.Point(196, 336);
            this.startTimerButton.Name = "startTimerButton";
            this.startTimerButton.Size = new System.Drawing.Size(127, 40);
            this.startTimerButton.TabIndex = 19;
            this.startTimerButton.Text = "Начать";
            this.startTimerButton.UseVisualStyleBackColor = true;
            this.startTimerButton.Click += new System.EventHandler(this.startTimerButton_Click);
            // 
            // exercsListBox
            // 
            this.exercsListBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.exercsListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.exercsListBox.FormattingEnabled = true;
            this.exercsListBox.ItemHeight = 19;
            this.exercsListBox.Location = new System.Drawing.Point(22, 109);
            this.exercsListBox.Name = "exercsListBox";
            this.exercsListBox.Size = new System.Drawing.Size(440, 194);
            this.exercsListBox.TabIndex = 19;
            // 
            // exercAddButton
            // 
            this.exercAddButton.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.button10;
            this.exercAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exercAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exercAddButton.FlatAppearance.BorderSize = 0;
            this.exercAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.exercAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.exercAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exercAddButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exercAddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(4)))), ((int)(((byte)(216)))));
            this.exercAddButton.Location = new System.Drawing.Point(184, 9);
            this.exercAddButton.Name = "exercAddButton";
            this.exercAddButton.Size = new System.Drawing.Size(35, 35);
            this.exercAddButton.TabIndex = 18;
            this.exercAddButton.UseVisualStyleBackColor = true;
            this.exercAddButton.Click += new System.EventHandler(this.exercAddButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Roboto Medium", 14F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(4)))), ((int)(((byte)(216)))));
            this.label13.Location = new System.Drawing.Point(20, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 23);
            this.label13.TabIndex = 8;
            this.label13.Text = "Упражнения";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.backPanel2;
            this.panel3.Controls.Add(this.waterRemoveButton);
            this.panel3.Controls.Add(this.waterLabel);
            this.panel3.Controls.Add(this.waterAddButton);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(27, 436);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 120);
            this.panel3.TabIndex = 17;
            // 
            // waterRemoveButton
            // 
            this.waterRemoveButton.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.button11;
            this.waterRemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.waterRemoveButton.FlatAppearance.BorderSize = 0;
            this.waterRemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.waterRemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.waterRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.waterRemoveButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waterRemoveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(4)))), ((int)(((byte)(216)))));
            this.waterRemoveButton.Location = new System.Drawing.Point(336, 42);
            this.waterRemoveButton.Name = "waterRemoveButton";
            this.waterRemoveButton.Size = new System.Drawing.Size(50, 50);
            this.waterRemoveButton.TabIndex = 17;
            this.waterRemoveButton.UseVisualStyleBackColor = true;
            this.waterRemoveButton.Click += new System.EventHandler(this.waterRemoveButton_Click);
            // 
            // waterLabel
            // 
            this.waterLabel.AutoSize = true;
            this.waterLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.waterLabel.Location = new System.Drawing.Point(16, 54);
            this.waterLabel.Name = "waterLabel";
            this.waterLabel.Size = new System.Drawing.Size(120, 38);
            this.waterLabel.TabIndex = 8;
            this.waterLabel.Text = "0 стак.";
            // 
            // waterAddButton
            // 
            this.waterAddButton.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.button10;
            this.waterAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.waterAddButton.FlatAppearance.BorderSize = 0;
            this.waterAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.waterAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.waterAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.waterAddButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waterAddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(4)))), ((int)(((byte)(216)))));
            this.waterAddButton.Location = new System.Drawing.Point(264, 42);
            this.waterAddButton.Name = "waterAddButton";
            this.waterAddButton.Size = new System.Drawing.Size(50, 50);
            this.waterAddButton.TabIndex = 16;
            this.waterAddButton.UseVisualStyleBackColor = true;
            this.waterAddButton.Click += new System.EventHandler(this.waterAddButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Roboto Medium", 14F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(4)))), ((int)(((byte)(216)))));
            this.label12.Location = new System.Drawing.Point(13, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 23);
            this.label12.TabIndex = 5;
            this.label12.Text = "Вода";
            // 
            // sleepPanel1
            // 
            this.sleepPanel1.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.backPanel2;
            this.sleepPanel1.Controls.Add(this.editSleepButton);
            this.sleepPanel1.Controls.Add(this.sleepPanel2);
            this.sleepPanel1.Controls.Add(this.fixButton);
            this.sleepPanel1.Controls.Add(this.sleepLabel);
            this.sleepPanel1.Controls.Add(this.label7);
            this.sleepPanel1.Location = new System.Drawing.Point(27, 261);
            this.sleepPanel1.Name = "sleepPanel1";
            this.sleepPanel1.Size = new System.Drawing.Size(425, 120);
            this.sleepPanel1.TabIndex = 8;
            // 
            // editSleepButton
            // 
            this.editSleepButton.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.pencil;
            this.editSleepButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editSleepButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editSleepButton.FlatAppearance.BorderSize = 0;
            this.editSleepButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.editSleepButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.editSleepButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSleepButton.Location = new System.Drawing.Point(389, 12);
            this.editSleepButton.Name = "editSleepButton";
            this.editSleepButton.Size = new System.Drawing.Size(15, 15);
            this.editSleepButton.TabIndex = 19;
            this.editSleepButton.UseVisualStyleBackColor = true;
            this.editSleepButton.Click += new System.EventHandler(this.editSleepButton_Click);
            // 
            // sleepPanel2
            // 
            this.sleepPanel2.Controls.Add(this.label11);
            this.sleepPanel2.Controls.Add(this.label10);
            this.sleepPanel2.Controls.Add(this.sleepEndMinutes);
            this.sleepPanel2.Controls.Add(this.label6);
            this.sleepPanel2.Controls.Add(this.sleepStartMinutes);
            this.sleepPanel2.Controls.Add(this.sleepStartHours);
            this.sleepPanel2.Controls.Add(this.label5);
            this.sleepPanel2.Controls.Add(this.sleepEndHours);
            this.sleepPanel2.Controls.Add(this.label8);
            this.sleepPanel2.Location = new System.Drawing.Point(17, 38);
            this.sleepPanel2.Name = "sleepPanel2";
            this.sleepPanel2.Size = new System.Drawing.Size(250, 67);
            this.sleepPanel2.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Roboto", 12F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label11.Location = new System.Drawing.Point(134, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "Подъем";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Roboto", 12F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label10.Location = new System.Drawing.Point(1, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Начало сна";
            // 
            // sleepEndMinutes
            // 
            this.sleepEndMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sleepEndMinutes.Font = new System.Drawing.Font("Roboto", 18F);
            this.sleepEndMinutes.Location = new System.Drawing.Point(199, 29);
            this.sleepEndMinutes.MaxLength = 2;
            this.sleepEndMinutes.Name = "sleepEndMinutes";
            this.sleepEndMinutes.Size = new System.Drawing.Size(44, 29);
            this.sleepEndMinutes.TabIndex = 14;
            this.sleepEndMinutes.Text = "20";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 18F);
            this.label6.Location = new System.Drawing.Point(176, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = ":";
            // 
            // sleepStartMinutes
            // 
            this.sleepStartMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sleepStartMinutes.Font = new System.Drawing.Font("Roboto", 18F);
            this.sleepStartMinutes.Location = new System.Drawing.Point(62, 29);
            this.sleepStartMinutes.MaxLength = 2;
            this.sleepStartMinutes.Name = "sleepStartMinutes";
            this.sleepStartMinutes.Size = new System.Drawing.Size(36, 29);
            this.sleepStartMinutes.TabIndex = 8;
            this.sleepStartMinutes.Text = "20";
            // 
            // sleepStartHours
            // 
            this.sleepStartHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sleepStartHours.Font = new System.Drawing.Font("Roboto", 18F);
            this.sleepStartHours.Location = new System.Drawing.Point(3, 29);
            this.sleepStartHours.MaxLength = 2;
            this.sleepStartHours.Name = "sleepStartHours";
            this.sleepStartHours.Size = new System.Drawing.Size(37, 29);
            this.sleepStartHours.TabIndex = 7;
            this.sleepStartHours.Text = "20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 18F);
            this.label5.Location = new System.Drawing.Point(37, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = ":";
            // 
            // sleepEndHours
            // 
            this.sleepEndHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sleepEndHours.Font = new System.Drawing.Font("Roboto", 18F);
            this.sleepEndHours.Location = new System.Drawing.Point(141, 29);
            this.sleepEndHours.MaxLength = 2;
            this.sleepEndHours.Name = "sleepEndHours";
            this.sleepEndHours.Size = new System.Drawing.Size(34, 29);
            this.sleepEndHours.TabIndex = 13;
            this.sleepEndHours.Text = "20";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 18F);
            this.label8.Location = new System.Drawing.Point(103, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "-";
            // 
            // fixButton
            // 
            this.fixButton.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.button9;
            this.fixButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fixButton.FlatAppearance.BorderSize = 0;
            this.fixButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.fixButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.fixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fixButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fixButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(4)))), ((int)(((byte)(216)))));
            this.fixButton.Location = new System.Drawing.Point(273, 52);
            this.fixButton.Name = "fixButton";
            this.fixButton.Size = new System.Drawing.Size(140, 40);
            this.fixButton.TabIndex = 16;
            this.fixButton.Text = "Зафиксировать";
            this.fixButton.UseVisualStyleBackColor = true;
            this.fixButton.Click += new System.EventHandler(this.fixButton_Click);
            // 
            // sleepLabel
            // 
            this.sleepLabel.AutoSize = true;
            this.sleepLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.sleepLabel.Location = new System.Drawing.Point(16, 54);
            this.sleepLabel.Name = "sleepLabel";
            this.sleepLabel.Size = new System.Drawing.Size(173, 38);
            this.sleepLabel.TabIndex = 18;
            this.sleepLabel.Text = "0 ч. 0 мин.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Roboto Medium", 14F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(4)))), ((int)(((byte)(216)))));
            this.label7.Location = new System.Drawing.Point(13, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Сон";
            // 
            // stepsPanel
            // 
            this.stepsPanel.BackgroundImage = global::ActivityTrackerWinForms.ControlsUI.backPanel2;
            this.stepsPanel.Controls.Add(this.distanceLabel);
            this.stepsPanel.Controls.Add(this.stepsTextBox);
            this.stepsPanel.Controls.Add(this.label3);
            this.stepsPanel.Controls.Add(this.label2);
            this.stepsPanel.Location = new System.Drawing.Point(27, 86);
            this.stepsPanel.Name = "stepsPanel";
            this.stepsPanel.Size = new System.Drawing.Size(425, 120);
            this.stepsPanel.TabIndex = 4;
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.distanceLabel.Location = new System.Drawing.Point(257, 51);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(94, 38);
            this.distanceLabel.TabIndex = 5;
            this.distanceLabel.Text = "0 км.";
            // 
            // stepsTextBox
            // 
            this.stepsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stepsTextBox.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepsTextBox.Location = new System.Drawing.Point(20, 51);
            this.stepsTextBox.MaxLength = 6;
            this.stepsTextBox.Name = "stepsTextBox";
            this.stepsTextBox.Size = new System.Drawing.Size(131, 39);
            this.stepsTextBox.TabIndex = 7;
            this.stepsTextBox.Text = "0";
            this.stepsTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.stepsTextBox_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(4)))), ((int)(((byte)(216)))));
            this.label3.Location = new System.Drawing.Point(249, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пройдено";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(4)))), ((int)(((byte)(216)))));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Шаги";
            // 
            // ActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.statButton);
            this.Controls.Add(this.saveResultsButton);
            this.Controls.Add(this.exercPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sleepPanel1);
            this.Controls.Add(this.stepsPanel);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ActivityForm";
            this.Text = "Трекер активности";
            this.Load += new System.EventHandler(this.ActivityForm_Load);
            this.exercPanel.ResumeLayout(false);
            this.exercPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.sleepPanel1.ResumeLayout(false);
            this.sleepPanel1.PerformLayout();
            this.sleepPanel2.ResumeLayout(false);
            this.sleepPanel2.PerformLayout();
            this.stepsPanel.ResumeLayout(false);
            this.stepsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel stepsPanel;
        private System.Windows.Forms.TextBox stepsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Panel sleepPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sleepEndMinutes;
        private System.Windows.Forms.TextBox sleepEndHours;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sleepStartMinutes;
        private System.Windows.Forms.TextBox sleepStartHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button fixButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label waterLabel;
        private System.Windows.Forms.Button waterAddButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button waterRemoveButton;
        private System.Windows.Forms.Panel sleepPanel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel exercPanel;
        private System.Windows.Forms.Button stopTimerButton;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button startTimerButton;
        private System.Windows.Forms.ListBox exercsListBox;
        private System.Windows.Forms.Button exercAddButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button showSavedExercsButton;
        private System.Windows.Forms.Button exercRemoveButton;
        private System.Windows.Forms.TextBox exercTextBox;
        private System.Windows.Forms.Label sleepLabel;
        private System.Windows.Forms.Button saveResultsButton;
        private System.Windows.Forms.Button statButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button editSleepButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button resetTimerButton;
    }
}