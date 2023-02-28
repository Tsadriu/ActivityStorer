namespace ActivityStorer
{
    partial class ViewActivityForm
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
            ActivityStorerLauncher.Instance.Show();
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
            this.dateInput = new System.Windows.Forms.MonthCalendar();
            this.dateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderByTimeButton = new System.Windows.Forms.Button();
            this.totalTimeSpentTextBox = new System.Windows.Forms.TextBox();
            this.totalTimeSpentLabel = new System.Windows.Forms.Label();
            this.activityDurationTextBox = new System.Windows.Forms.TextBox();
            this.activityDurationLabel = new System.Windows.Forms.Label();
            this.workerToAddLabel = new System.Windows.Forms.Label();
            this.workerToAddBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.rowLabel = new System.Windows.Forms.Label();
            this.rowInput = new System.Windows.Forms.NumericUpDown();
            this.commitInput = new System.Windows.Forms.TextBox();
            this.fileStateResult = new System.Windows.Forms.Label();
            this.fileStateLabel = new System.Windows.Forms.Label();
            this.workerInput = new System.Windows.Forms.CheckedListBox();
            this.workerLabel = new System.Windows.Forms.Label();
            this.modifyButton = new System.Windows.Forms.Button();
            this.commitLabel = new System.Windows.Forms.Label();
            this.branchInput = new System.Windows.Forms.TextBox();
            this.branchLabel = new System.Windows.Forms.Label();
            this.ticketInput = new System.Windows.Forms.TextBox();
            this.ticketLabel = new System.Windows.Forms.Label();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.activityEndInput = new System.Windows.Forms.DateTimePicker();
            this.activityEndLabel = new System.Windows.Forms.Label();
            this.activityStartInput = new System.Windows.Forms.DateTimePicker();
            this.activityStartLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowInput)).BeginInit();
            this.SuspendLayout();
            // 
            // dateInput
            // 
            this.dateInput.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.dateInput.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dateInput.Location = new System.Drawing.Point(0, 35);
            this.dateInput.MaxSelectionCount = 1;
            this.dateInput.Name = "dateInput";
            this.dateInput.ShowTodayCircle = false;
            this.dateInput.TabIndex = 0;
            this.dateInput.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dateInput_DateChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(3, 11);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(73, 15);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Select a date";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.orderByTimeButton);
            this.panel1.Controls.Add(this.totalTimeSpentTextBox);
            this.panel1.Controls.Add(this.totalTimeSpentLabel);
            this.panel1.Controls.Add(this.activityDurationTextBox);
            this.panel1.Controls.Add(this.activityDurationLabel);
            this.panel1.Controls.Add(this.workerToAddLabel);
            this.panel1.Controls.Add(this.workerToAddBox);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.rowLabel);
            this.panel1.Controls.Add(this.rowInput);
            this.panel1.Controls.Add(this.commitInput);
            this.panel1.Controls.Add(this.fileStateResult);
            this.panel1.Controls.Add(this.fileStateLabel);
            this.panel1.Controls.Add(this.workerInput);
            this.panel1.Controls.Add(this.workerLabel);
            this.panel1.Controls.Add(this.modifyButton);
            this.panel1.Controls.Add(this.commitLabel);
            this.panel1.Controls.Add(this.branchInput);
            this.panel1.Controls.Add(this.branchLabel);
            this.panel1.Controls.Add(this.ticketInput);
            this.panel1.Controls.Add(this.ticketLabel);
            this.panel1.Controls.Add(this.descriptionInput);
            this.panel1.Controls.Add(this.descriptionLabel);
            this.panel1.Controls.Add(this.activityEndInput);
            this.panel1.Controls.Add(this.activityEndLabel);
            this.panel1.Controls.Add(this.activityStartInput);
            this.panel1.Controls.Add(this.activityStartLabel);
            this.panel1.Controls.Add(this.dateInput);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 426);
            this.panel1.TabIndex = 2;
            // 
            // orderByTimeButton
            // 
            this.orderByTimeButton.Location = new System.Drawing.Point(282, 54);
            this.orderByTimeButton.Name = "orderByTimeButton";
            this.orderByTimeButton.Size = new System.Drawing.Size(78, 43);
            this.orderByTimeButton.TabIndex = 2;
            this.orderByTimeButton.Text = "Order by time";
            this.orderByTimeButton.UseVisualStyleBackColor = true;
            this.orderByTimeButton.Click += new System.EventHandler(this.orderByTimeButton_Click);
            // 
            // totalTimeSpentTextBox
            // 
            this.totalTimeSpentTextBox.Location = new System.Drawing.Point(3, 235);
            this.totalTimeSpentTextBox.Name = "totalTimeSpentTextBox";
            this.totalTimeSpentTextBox.ReadOnly = true;
            this.totalTimeSpentTextBox.Size = new System.Drawing.Size(100, 23);
            this.totalTimeSpentTextBox.TabIndex = 44;
            // 
            // totalTimeSpentLabel
            // 
            this.totalTimeSpentLabel.AutoSize = true;
            this.totalTimeSpentLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalTimeSpentLabel.Location = new System.Drawing.Point(3, 217);
            this.totalTimeSpentLabel.Name = "totalTimeSpentLabel";
            this.totalTimeSpentLabel.Size = new System.Drawing.Size(97, 15);
            this.totalTimeSpentLabel.TabIndex = 43;
            this.totalTimeSpentLabel.Text = "Total time spent";
            // 
            // activityDurationTextBox
            // 
            this.activityDurationTextBox.Location = new System.Drawing.Point(394, 143);
            this.activityDurationTextBox.Name = "activityDurationTextBox";
            this.activityDurationTextBox.ReadOnly = true;
            this.activityDurationTextBox.Size = new System.Drawing.Size(92, 23);
            this.activityDurationTextBox.TabIndex = 5;
            // 
            // activityDurationLabel
            // 
            this.activityDurationLabel.AutoSize = true;
            this.activityDurationLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.activityDurationLabel.Location = new System.Drawing.Point(394, 125);
            this.activityDurationLabel.Name = "activityDurationLabel";
            this.activityDurationLabel.Size = new System.Drawing.Size(102, 15);
            this.activityDurationLabel.TabIndex = 41;
            this.activityDurationLabel.Text = "Activity Duration";
            // 
            // workerToAddLabel
            // 
            this.workerToAddLabel.AutoSize = true;
            this.workerToAddLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.workerToAddLabel.Location = new System.Drawing.Point(726, 191);
            this.workerToAddLabel.Name = "workerToAddLabel";
            this.workerToAddLabel.Size = new System.Drawing.Size(96, 15);
            this.workerToAddLabel.TabIndex = 40;
            this.workerToAddLabel.Text = "Workers to add:";
            this.workerToAddLabel.Visible = false;
            // 
            // workerToAddBox
            // 
            this.workerToAddBox.Location = new System.Drawing.Point(726, 209);
            this.workerToAddBox.Multiline = true;
            this.workerToAddBox.Name = "workerToAddBox";
            this.workerToAddBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.workerToAddBox.Size = new System.Drawing.Size(128, 148);
            this.workerToAddBox.TabIndex = 11;
            this.workerToAddBox.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(627, 369);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rowLabel.Location = new System.Drawing.Point(282, 11);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(78, 15);
            this.rowLabel.TabIndex = 37;
            this.rowLabel.Text = "Current Row";
            // 
            // rowInput
            // 
            this.rowInput.Location = new System.Drawing.Point(282, 29);
            this.rowInput.Name = "rowInput";
            this.rowInput.Size = new System.Drawing.Size(78, 23);
            this.rowInput.TabIndex = 1;
            this.rowInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rowInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowInput.ValueChanged += new System.EventHandler(this.rowInput_ValueChanged);
            // 
            // commitInput
            // 
            this.commitInput.Location = new System.Drawing.Point(394, 334);
            this.commitInput.Name = "commitInput";
            this.commitInput.ReadOnly = true;
            this.commitInput.Size = new System.Drawing.Size(92, 23);
            this.commitInput.TabIndex = 8;
            // 
            // fileStateResult
            // 
            this.fileStateResult.AutoSize = true;
            this.fileStateResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileStateResult.Location = new System.Drawing.Point(594, 402);
            this.fileStateResult.Name = "fileStateResult";
            this.fileStateResult.Size = new System.Drawing.Size(38, 15);
            this.fileStateResult.TabIndex = 35;
            this.fileStateResult.Text = "Saved";
            // 
            // fileStateLabel
            // 
            this.fileStateLabel.AutoSize = true;
            this.fileStateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fileStateLabel.Location = new System.Drawing.Point(528, 402);
            this.fileStateLabel.Name = "fileStateLabel";
            this.fileStateLabel.Size = new System.Drawing.Size(60, 15);
            this.fileStateLabel.TabIndex = 34;
            this.fileStateLabel.Text = "File state:";
            // 
            // workerInput
            // 
            this.workerInput.CheckOnClick = true;
            this.workerInput.Enabled = false;
            this.workerInput.FormattingEnabled = true;
            this.workerInput.Location = new System.Drawing.Point(528, 209);
            this.workerInput.Name = "workerInput";
            this.workerInput.Size = new System.Drawing.Size(192, 148);
            this.workerInput.TabIndex = 10;
            // 
            // workerLabel
            // 
            this.workerLabel.AutoSize = true;
            this.workerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.workerLabel.Location = new System.Drawing.Point(528, 191);
            this.workerLabel.Name = "workerLabel";
            this.workerLabel.Size = new System.Drawing.Size(106, 15);
            this.workerLabel.TabIndex = 32;
            this.workerLabel.Text = "Workers involved";
            // 
            // modifyButton
            // 
            this.modifyButton.Enabled = false;
            this.modifyButton.Location = new System.Drawing.Point(528, 369);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(93, 23);
            this.modifyButton.TabIndex = 12;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // commitLabel
            // 
            this.commitLabel.AutoSize = true;
            this.commitLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.commitLabel.Location = new System.Drawing.Point(394, 316);
            this.commitLabel.Name = "commitLabel";
            this.commitLabel.Size = new System.Drawing.Size(51, 15);
            this.commitLabel.TabIndex = 30;
            this.commitLabel.Text = "Commit";
            // 
            // branchInput
            // 
            this.branchInput.Location = new System.Drawing.Point(394, 275);
            this.branchInput.Name = "branchInput";
            this.branchInput.ReadOnly = true;
            this.branchInput.Size = new System.Drawing.Size(92, 23);
            this.branchInput.TabIndex = 7;
            // 
            // branchLabel
            // 
            this.branchLabel.AutoSize = true;
            this.branchLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.branchLabel.Location = new System.Drawing.Point(394, 257);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(46, 15);
            this.branchLabel.TabIndex = 28;
            this.branchLabel.Text = "Branch";
            // 
            // ticketInput
            // 
            this.ticketInput.Location = new System.Drawing.Point(394, 209);
            this.ticketInput.Name = "ticketInput";
            this.ticketInput.ReadOnly = true;
            this.ticketInput.Size = new System.Drawing.Size(92, 23);
            this.ticketInput.TabIndex = 6;
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ticketLabel.Location = new System.Drawing.Point(394, 191);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(42, 15);
            this.ticketLabel.TabIndex = 26;
            this.ticketLabel.Text = "Ticket";
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(528, 29);
            this.descriptionInput.Multiline = true;
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.ReadOnly = true;
            this.descriptionInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionInput.Size = new System.Drawing.Size(326, 149);
            this.descriptionInput.TabIndex = 9;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(528, 11);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(71, 15);
            this.descriptionLabel.TabIndex = 24;
            this.descriptionLabel.Text = "Description";
            // 
            // activityEndInput
            // 
            this.activityEndInput.CustomFormat = "HH:mm";
            this.activityEndInput.Enabled = false;
            this.activityEndInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.activityEndInput.Location = new System.Drawing.Point(394, 85);
            this.activityEndInput.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.activityEndInput.Name = "activityEndInput";
            this.activityEndInput.ShowUpDown = true;
            this.activityEndInput.Size = new System.Drawing.Size(92, 23);
            this.activityEndInput.TabIndex = 4;
            this.activityEndInput.Value = new System.DateTime(2022, 8, 6, 0, 0, 0, 0);
            // 
            // activityEndLabel
            // 
            this.activityEndLabel.AutoSize = true;
            this.activityEndLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.activityEndLabel.Location = new System.Drawing.Point(394, 67);
            this.activityEndLabel.Name = "activityEndLabel";
            this.activityEndLabel.Size = new System.Drawing.Size(73, 15);
            this.activityEndLabel.TabIndex = 22;
            this.activityEndLabel.Text = "Activity End";
            // 
            // activityStartInput
            // 
            this.activityStartInput.CustomFormat = "HH:mm";
            this.activityStartInput.Enabled = false;
            this.activityStartInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.activityStartInput.Location = new System.Drawing.Point(394, 29);
            this.activityStartInput.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.activityStartInput.Name = "activityStartInput";
            this.activityStartInput.ShowUpDown = true;
            this.activityStartInput.Size = new System.Drawing.Size(92, 23);
            this.activityStartInput.TabIndex = 3;
            this.activityStartInput.Value = new System.DateTime(2022, 8, 6, 0, 0, 0, 0);
            // 
            // activityStartLabel
            // 
            this.activityStartLabel.AutoSize = true;
            this.activityStartLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.activityStartLabel.Location = new System.Drawing.Point(394, 11);
            this.activityStartLabel.Name = "activityStartLabel";
            this.activityStartLabel.Size = new System.Drawing.Size(81, 15);
            this.activityStartLabel.TabIndex = 20;
            this.activityStartLabel.Text = "Activity Start";
            // 
            // ViewActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ViewActivityForm";
            this.Text = "View Activity";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MonthCalendar dateInput;
        private Label dateLabel;
        private Panel panel1;
        private Label fileStateResult;
        private Label fileStateLabel;
        private CheckedListBox workerInput;
        private Label workerLabel;
        private Button modifyButton;
        private Label commitLabel;
        private TextBox branchInput;
        private Label branchLabel;
        private TextBox ticketInput;
        private Label ticketLabel;
        private TextBox descriptionInput;
        private Label descriptionLabel;
        private DateTimePicker activityEndInput;
        private Label activityEndLabel;
        private DateTimePicker activityStartInput;
        private Label activityStartLabel;
        private TextBox commitInput;
        private NumericUpDown rowInput;
        private Label rowLabel;
        private Button saveButton;
        private TextBox workerToAddBox;
        private Label workerToAddLabel;
        private TextBox activityDurationTextBox;
        private Label activityDurationLabel;
        private TextBox totalTimeSpentTextBox;
        private Label totalTimeSpentLabel;
        private Button orderByTimeButton;
    }
}