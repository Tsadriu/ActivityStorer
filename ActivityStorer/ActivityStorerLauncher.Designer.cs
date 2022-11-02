namespace ActivityStorer
{
    partial class ActivityStorerLauncher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveButton = new System.Windows.Forms.Button();
            this.viewActivityButton = new System.Windows.Forms.Button();
            this.workersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(330, 34);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save new activity";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewActivityButton
            // 
            this.viewActivityButton.Location = new System.Drawing.Point(330, 73);
            this.viewActivityButton.Name = "viewActivityButton";
            this.viewActivityButton.Size = new System.Drawing.Size(110, 23);
            this.viewActivityButton.TabIndex = 1;
            this.viewActivityButton.Text = "View activity";
            this.viewActivityButton.UseVisualStyleBackColor = true;
            this.viewActivityButton.Click += new System.EventHandler(this.viewActivityButton_Click);
            // 
            // workersButton
            // 
            this.workersButton.Location = new System.Drawing.Point(330, 113);
            this.workersButton.Name = "workersButton";
            this.workersButton.Size = new System.Drawing.Size(110, 23);
            this.workersButton.TabIndex = 2;
            this.workersButton.Text = "Workers List";
            this.workersButton.UseVisualStyleBackColor = true;
            this.workersButton.Click += new System.EventHandler(this.workersButton_Click);
            // 
            // ActivityStorerLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.workersButton);
            this.Controls.Add(this.viewActivityButton);
            this.Controls.Add(this.saveButton);
            this.Name = "ActivityStorerLauncher";
            this.Text = "Activity Storer 1.0.0";
            this.ResumeLayout(false);

        }

        #endregion

        private Button saveButton;
        private Button viewActivityButton;
        private Button workersButton;
    }
}