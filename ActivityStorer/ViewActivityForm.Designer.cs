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
            this.rowLabel = new System.Windows.Forms.Label();
            this.rowInput = new System.Windows.Forms.NumericUpDown();
            this.commitInput = new System.Windows.Forms.TextBox();
            this.fileStateResult = new System.Windows.Forms.Label();
            this.fileStateLabel = new System.Windows.Forms.Label();
            this.coworkerInput = new System.Windows.Forms.CheckedListBox();
            this.coworkerLabel = new System.Windows.Forms.Label();
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
            this.saveButton = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.rowLabel);
            this.panel1.Controls.Add(this.rowInput);
            this.panel1.Controls.Add(this.commitInput);
            this.panel1.Controls.Add(this.fileStateResult);
            this.panel1.Controls.Add(this.fileStateLabel);
            this.panel1.Controls.Add(this.coworkerInput);
            this.panel1.Controls.Add(this.coworkerLabel);
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
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rowLabel.Location = new System.Drawing.Point(313, 11);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(78, 15);
            this.rowLabel.TabIndex = 37;
            this.rowLabel.Text = "Current Row";
            // 
            // rowInput
            // 
            this.rowInput.Location = new System.Drawing.Point(313, 29);
            this.rowInput.Name = "rowInput";
            this.rowInput.Size = new System.Drawing.Size(78, 23);
            this.rowInput.TabIndex = 36;
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
            this.commitInput.Location = new System.Drawing.Point(425, 334);
            this.commitInput.Name = "commitInput";
            this.commitInput.ReadOnly = true;
            this.commitInput.Size = new System.Drawing.Size(92, 23);
            this.commitInput.TabIndex = 7;
            // 
            // fileStateResult
            // 
            this.fileStateResult.AutoSize = true;
            this.fileStateResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileStateResult.Location = new System.Drawing.Point(625, 402);
            this.fileStateResult.Name = "fileStateResult";
            this.fileStateResult.Size = new System.Drawing.Size(38, 15);
            this.fileStateResult.TabIndex = 35;
            this.fileStateResult.Text = "Saved";
            // 
            // fileStateLabel
            // 
            this.fileStateLabel.AutoSize = true;
            this.fileStateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fileStateLabel.Location = new System.Drawing.Point(559, 402);
            this.fileStateLabel.Name = "fileStateLabel";
            this.fileStateLabel.Size = new System.Drawing.Size(60, 15);
            this.fileStateLabel.TabIndex = 34;
            this.fileStateLabel.Text = "File state:";
            // 
            // coworkerInput
            // 
            this.coworkerInput.CheckOnClick = true;
            this.coworkerInput.Enabled = false;
            this.coworkerInput.FormattingEnabled = true;
            this.coworkerInput.Items.AddRange(new object[] {
            "Ardizzone Lorenzo",
            "Bettelini Paolo",
            "Grassi Lorenzo",
            "Grizini Michelle",
            "Marinelli Alberto",
            "Oliveira Fabio",
            "Scigliano Andrea",
            "Tochetti Alessio"});
            this.coworkerInput.Location = new System.Drawing.Point(559, 209);
            this.coworkerInput.Name = "coworkerInput";
            this.coworkerInput.Size = new System.Drawing.Size(187, 148);
            this.coworkerInput.TabIndex = 4;
            // 
            // coworkerLabel
            // 
            this.coworkerLabel.AutoSize = true;
            this.coworkerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.coworkerLabel.Location = new System.Drawing.Point(559, 191);
            this.coworkerLabel.Name = "coworkerLabel";
            this.coworkerLabel.Size = new System.Drawing.Size(123, 15);
            this.coworkerLabel.TabIndex = 32;
            this.coworkerLabel.Text = "Co-workers involved";
            // 
            // modifyButton
            // 
            this.modifyButton.Enabled = false;
            this.modifyButton.Location = new System.Drawing.Point(559, 369);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 8;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // commitLabel
            // 
            this.commitLabel.AutoSize = true;
            this.commitLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.commitLabel.Location = new System.Drawing.Point(425, 316);
            this.commitLabel.Name = "commitLabel";
            this.commitLabel.Size = new System.Drawing.Size(51, 15);
            this.commitLabel.TabIndex = 30;
            this.commitLabel.Text = "Commit";
            // 
            // branchInput
            // 
            this.branchInput.Location = new System.Drawing.Point(425, 275);
            this.branchInput.Name = "branchInput";
            this.branchInput.ReadOnly = true;
            this.branchInput.Size = new System.Drawing.Size(92, 23);
            this.branchInput.TabIndex = 6;
            // 
            // branchLabel
            // 
            this.branchLabel.AutoSize = true;
            this.branchLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.branchLabel.Location = new System.Drawing.Point(425, 257);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(46, 15);
            this.branchLabel.TabIndex = 28;
            this.branchLabel.Text = "Branch";
            // 
            // ticketInput
            // 
            this.ticketInput.Location = new System.Drawing.Point(425, 209);
            this.ticketInput.Name = "ticketInput";
            this.ticketInput.ReadOnly = true;
            this.ticketInput.Size = new System.Drawing.Size(92, 23);
            this.ticketInput.TabIndex = 5;
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ticketLabel.Location = new System.Drawing.Point(425, 191);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(42, 15);
            this.ticketLabel.TabIndex = 26;
            this.ticketLabel.Text = "Ticket";
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(559, 29);
            this.descriptionInput.Multiline = true;
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.ReadOnly = true;
            this.descriptionInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionInput.Size = new System.Drawing.Size(290, 149);
            this.descriptionInput.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(559, 11);
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
            this.activityEndInput.Location = new System.Drawing.Point(425, 85);
            this.activityEndInput.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.activityEndInput.Name = "activityEndInput";
            this.activityEndInput.ShowUpDown = true;
            this.activityEndInput.Size = new System.Drawing.Size(92, 23);
            this.activityEndInput.TabIndex = 2;
            this.activityEndInput.Value = new System.DateTime(2022, 8, 6, 0, 0, 0, 0);
            // 
            // activityEndLabel
            // 
            this.activityEndLabel.AutoSize = true;
            this.activityEndLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.activityEndLabel.Location = new System.Drawing.Point(425, 67);
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
            this.activityStartInput.Location = new System.Drawing.Point(425, 29);
            this.activityStartInput.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.activityStartInput.Name = "activityStartInput";
            this.activityStartInput.ShowUpDown = true;
            this.activityStartInput.Size = new System.Drawing.Size(92, 23);
            this.activityStartInput.TabIndex = 1;
            this.activityStartInput.Value = new System.DateTime(2022, 8, 6, 0, 0, 0, 0);
            // 
            // activityStartLabel
            // 
            this.activityStartLabel.AutoSize = true;
            this.activityStartLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.activityStartLabel.Location = new System.Drawing.Point(425, 11);
            this.activityStartLabel.Name = "activityStartLabel";
            this.activityStartLabel.Size = new System.Drawing.Size(81, 15);
            this.activityStartLabel.TabIndex = 20;
            this.activityStartLabel.Text = "Activity Start";
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(640, 369);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 38;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
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
        private CheckedListBox coworkerInput;
        private Label coworkerLabel;
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
    }
}