namespace ActivityStorer
{
    partial class NewActivityForm
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
            ActivityStorer.Instance.Show();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileStateResult = new System.Windows.Forms.Label();
            this.fileStateLabel = new System.Windows.Forms.Label();
            this.coworkerInput = new System.Windows.Forms.CheckedListBox();
            this.coworkerLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
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
            this.dateInput = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.commitInput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fileStateResult);
            this.panel1.Controls.Add(this.fileStateLabel);
            this.panel1.Controls.Add(this.coworkerInput);
            this.panel1.Controls.Add(this.coworkerLabel);
            this.panel1.Controls.Add(this.saveButton);
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
            this.panel1.Location = new System.Drawing.Point(28, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 377);
            this.panel1.TabIndex = 0;
            // 
            // fileStateResult
            // 
            this.fileStateResult.AutoSize = true;
            this.fileStateResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileStateResult.Location = new System.Drawing.Point(368, 343);
            this.fileStateResult.Name = "fileStateResult";
            this.fileStateResult.Size = new System.Drawing.Size(38, 15);
            this.fileStateResult.TabIndex = 11;
            this.fileStateResult.Text = "Saved";
            // 
            // fileStateLabel
            // 
            this.fileStateLabel.AutoSize = true;
            this.fileStateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fileStateLabel.Location = new System.Drawing.Point(296, 343);
            this.fileStateLabel.Name = "fileStateLabel";
            this.fileStateLabel.Size = new System.Drawing.Size(60, 15);
            this.fileStateLabel.TabIndex = 10;
            this.fileStateLabel.Text = "File state:";
            // 
            // coworkerInput
            // 
            this.coworkerInput.CheckOnClick = true;
            this.coworkerInput.FormattingEnabled = true;
            this.coworkerInput.Items.AddRange(new object[] {
            "Ardizzone Lorenzo",
            "Bettelini Paolo",
            "Grassi Lorenzo",
            "Marinelli Alberto",
            "Oliveira Fabio",
            "Scigliano Andrea",
            "Tochetti Alessio"});
            this.coworkerInput.Location = new System.Drawing.Point(219, 203);
            this.coworkerInput.Name = "coworkerInput";
            this.coworkerInput.Size = new System.Drawing.Size(187, 130);
            this.coworkerInput.TabIndex = 5;
            // 
            // coworkerLabel
            // 
            this.coworkerLabel.AutoSize = true;
            this.coworkerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.coworkerLabel.Location = new System.Drawing.Point(219, 185);
            this.coworkerLabel.Name = "coworkerLabel";
            this.coworkerLabel.Size = new System.Drawing.Size(123, 15);
            this.coworkerLabel.TabIndex = 14;
            this.coworkerLabel.Text = "Co-workers involved";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(215, 339);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // commitLabel
            // 
            this.commitLabel.AutoSize = true;
            this.commitLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.commitLabel.Location = new System.Drawing.Point(18, 317);
            this.commitLabel.Name = "commitLabel";
            this.commitLabel.Size = new System.Drawing.Size(51, 15);
            this.commitLabel.TabIndex = 12;
            this.commitLabel.Text = "Commit";
            // 
            // branchInput
            // 
            this.branchInput.Location = new System.Drawing.Point(18, 274);
            this.branchInput.Name = "branchInput";
            this.branchInput.PlaceholderText = "Ticket_367";
            this.branchInput.Size = new System.Drawing.Size(92, 23);
            this.branchInput.TabIndex = 7;
            // 
            // branchLabel
            // 
            this.branchLabel.AutoSize = true;
            this.branchLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.branchLabel.Location = new System.Drawing.Point(18, 256);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(46, 15);
            this.branchLabel.TabIndex = 10;
            this.branchLabel.Text = "Branch";
            // 
            // ticketInput
            // 
            this.ticketInput.Location = new System.Drawing.Point(18, 215);
            this.ticketInput.Name = "ticketInput";
            this.ticketInput.PlaceholderText = "367";
            this.ticketInput.Size = new System.Drawing.Size(92, 23);
            this.ticketInput.TabIndex = 6;
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ticketLabel.Location = new System.Drawing.Point(18, 197);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(42, 15);
            this.ticketLabel.TabIndex = 8;
            this.ticketLabel.Text = "Ticket";
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(219, 37);
            this.descriptionInput.Multiline = true;
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.PlaceholderText = "Portal Edyna uses a differ...";
            this.descriptionInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionInput.Size = new System.Drawing.Size(187, 136);
            this.descriptionInput.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(219, 19);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(71, 15);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "Description";
            // 
            // activityEndInput
            // 
            this.activityEndInput.CustomFormat = "HH:mm";
            this.activityEndInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.activityEndInput.Location = new System.Drawing.Point(18, 150);
            this.activityEndInput.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.activityEndInput.Name = "activityEndInput";
            this.activityEndInput.ShowUpDown = true;
            this.activityEndInput.Size = new System.Drawing.Size(92, 23);
            this.activityEndInput.TabIndex = 2;
            this.activityEndInput.Value = new System.DateTime(2022, 6, 8, 11, 26, 19, 471);
            // 
            // activityEndLabel
            // 
            this.activityEndLabel.AutoSize = true;
            this.activityEndLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.activityEndLabel.Location = new System.Drawing.Point(18, 132);
            this.activityEndLabel.Name = "activityEndLabel";
            this.activityEndLabel.Size = new System.Drawing.Size(73, 15);
            this.activityEndLabel.TabIndex = 4;
            this.activityEndLabel.Text = "Activity End";
            // 
            // activityStartInput
            // 
            this.activityStartInput.CustomFormat = "HH:mm";
            this.activityStartInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.activityStartInput.Location = new System.Drawing.Point(18, 94);
            this.activityStartInput.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.activityStartInput.Name = "activityStartInput";
            this.activityStartInput.ShowUpDown = true;
            this.activityStartInput.Size = new System.Drawing.Size(92, 23);
            this.activityStartInput.TabIndex = 1;
            this.activityStartInput.Value = new System.DateTime(2022, 6, 8, 10, 26, 19, 473);
            // 
            // activityStartLabel
            // 
            this.activityStartLabel.AutoSize = true;
            this.activityStartLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.activityStartLabel.Location = new System.Drawing.Point(18, 76);
            this.activityStartLabel.Name = "activityStartLabel";
            this.activityStartLabel.Size = new System.Drawing.Size(81, 15);
            this.activityStartLabel.TabIndex = 2;
            this.activityStartLabel.Text = "Activity Start";
            // 
            // dateInput
            // 
            this.dateInput.CustomFormat = "dd.MM.yyyy";
            this.dateInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInput.Location = new System.Drawing.Point(18, 37);
            this.dateInput.MaxDate = DateTime.Today;
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(92, 23);
            this.dateInput.TabIndex = 0;
            this.dateInput.Value = DateTime.Today;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(18, 19);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(34, 15);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date";
            // 
            // commitInput
            // 
            this.commitInput.Location = new System.Drawing.Point(46, 356);
            this.commitInput.Name = "commitInput";
            this.commitInput.PlaceholderText = "7a4b6ed9bd37d9cd625a5e030645c8a15f75d94a";
            this.commitInput.Size = new System.Drawing.Size(92, 23);
            this.commitInput.TabIndex = 8;
            // 
            // NewActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 430);
            this.Controls.Add(this.commitInput);
            this.Controls.Add(this.panel1);
            this.Name = "NewActivityForm";
            this.Text = "Add new activity";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label dateLabel;
        private DateTimePicker dateInput;
        private Label activityStartLabel;
        private DateTimePicker activityStartInput;
        private DateTimePicker activityEndInput;
        private Label activityEndLabel;
        private TextBox descriptionInput;
        private Label descriptionLabel;
        private TextBox ticketInput;
        private Label ticketLabel;
        private Label commitLabel;
        private TextBox branchInput;
        private Label branchLabel;
        private TextBox commitInput;
        private Button saveButton;
        private CheckedListBox coworkerInput;
        private Label coworkerLabel;
        private Label fileStateResult;
        private Label fileStateLabel;
    }
}