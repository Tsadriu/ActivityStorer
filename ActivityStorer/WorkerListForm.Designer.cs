namespace ActivityStorer
{
    partial class WorkerListForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.workerSettingsLabel = new System.Windows.Forms.Label();
            this.workerCheckedBox = new System.Windows.Forms.CheckedListBox();
            this.workerListLabel = new System.Windows.Forms.Label();
            this.workerTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.modifyButton);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.workerSettingsLabel);
            this.groupBox1.Controls.Add(this.workerCheckedBox);
            this.groupBox1.Controls.Add(this.workerListLabel);
            this.groupBox1.Controls.Add(this.workerTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // workerSettingsLabel
            // 
            this.workerSettingsLabel.AutoSize = true;
            this.workerSettingsLabel.Location = new System.Drawing.Point(301, 38);
            this.workerSettingsLabel.Name = "workerSettingsLabel";
            this.workerSettingsLabel.Size = new System.Drawing.Size(149, 15);
            this.workerSettingsLabel.TabIndex = 3;
            this.workerSettingsLabel.Text = "Workers in the settings file.";
            // 
            // workerCheckedBox
            // 
            this.workerCheckedBox.FormattingEnabled = true;
            this.workerCheckedBox.Location = new System.Drawing.Point(301, 56);
            this.workerCheckedBox.Name = "workerCheckedBox";
            this.workerCheckedBox.Size = new System.Drawing.Size(269, 364);
            this.workerCheckedBox.TabIndex = 2;
            // 
            // workerListLabel
            // 
            this.workerListLabel.AutoSize = true;
            this.workerListLabel.Location = new System.Drawing.Point(6, 23);
            this.workerListLabel.Name = "workerListLabel";
            this.workerListLabel.Size = new System.Drawing.Size(155, 30);
            this.workerListLabel.TabIndex = 1;
            this.workerListLabel.Text = "Worker list.\r\nSeperate workers by \'ENTER\'";
            // 
            // workerTextBox
            // 
            this.workerTextBox.Location = new System.Drawing.Point(6, 56);
            this.workerTextBox.Multiline = true;
            this.workerTextBox.Name = "workerTextBox";
            this.workerTextBox.PlaceholderText = "Fabio Oliveira";
            this.workerTextBox.Size = new System.Drawing.Size(289, 364);
            this.workerTextBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(576, 56);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save worker list";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(576, 85);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(118, 23);
            this.modifyButton.TabIndex = 5;
            this.modifyButton.Text = "Modify worker list";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // WorkerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "WorkerListForm";
            this.Text = "WorkerListFormcs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label workerListLabel;
        private TextBox workerTextBox;
        private Label workerSettingsLabel;
        private CheckedListBox workerCheckedBox;
        private Button saveButton;
        private Button modifyButton;
    }
}