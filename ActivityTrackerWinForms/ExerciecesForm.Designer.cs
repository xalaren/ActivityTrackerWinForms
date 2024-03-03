namespace ActivityTrackerWinForms
{
    partial class ExerciecesForm
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
            this.exercHistoryListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exercHistoryListBox
            // 
            this.exercHistoryListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exercHistoryListBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.exercHistoryListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.exercHistoryListBox.FormattingEnabled = true;
            this.exercHistoryListBox.ItemHeight = 19;
            this.exercHistoryListBox.Location = new System.Drawing.Point(12, 69);
            this.exercHistoryListBox.Name = "exercHistoryListBox";
            this.exercHistoryListBox.Size = new System.Drawing.Size(660, 380);
            this.exercHistoryListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "УПРАЖНЕНИЯ";
            // 
            // ExerciecesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exercHistoryListBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ExerciecesForm";
            this.Text = "Журнал упражнений";
            this.Load += new System.EventHandler(this.ExerciecesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox exercHistoryListBox;
        private System.Windows.Forms.Label label1;
    }
}