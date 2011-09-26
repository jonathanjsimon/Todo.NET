namespace Todo.NET
{
    partial class Settings
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
            this.settingsTitle = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.createBackupCheck = new System.Windows.Forms.CheckBox();
            this.createBackupLabel = new System.Windows.Forms.Label();
            this.includeDateLabel = new System.Windows.Forms.Label();
            this.includeDateCheck = new System.Windows.Forms.CheckBox();
            this.settingsSaveButton = new System.Windows.Forms.Button();
            this.settingsCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settingsTitle
            // 
            this.settingsTitle.AutoSize = true;
            this.settingsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsTitle.Location = new System.Drawing.Point(117, 9);
            this.settingsTitle.Name = "settingsTitle";
            this.settingsTitle.Size = new System.Drawing.Size(220, 29);
            this.settingsTitle.TabIndex = 0;
            this.settingsTitle.Text = "Todo.NET Settings";
            this.settingsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(33, 60);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(82, 13);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "Path to todo.txt:";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(119, 60);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(271, 20);
            this.pathBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // createBackupCheck
            // 
            this.createBackupCheck.AutoSize = true;
            this.createBackupCheck.Location = new System.Drawing.Point(396, 85);
            this.createBackupCheck.Name = "createBackupCheck";
            this.createBackupCheck.Size = new System.Drawing.Size(15, 14);
            this.createBackupCheck.TabIndex = 5;
            this.createBackupCheck.UseVisualStyleBackColor = true;
            // 
            // createBackupLabel
            // 
            this.createBackupLabel.AutoSize = true;
            this.createBackupLabel.Location = new System.Drawing.Point(33, 85);
            this.createBackupLabel.Name = "createBackupLabel";
            this.createBackupLabel.Size = new System.Drawing.Size(199, 13);
            this.createBackupLabel.TabIndex = 6;
            this.createBackupLabel.Text = "Create backup before writing to todo.txt?";
            // 
            // includeDateLabel
            // 
            this.includeDateLabel.AutoSize = true;
            this.includeDateLabel.Location = new System.Drawing.Point(33, 110);
            this.includeDateLabel.Name = "includeDateLabel";
            this.includeDateLabel.Size = new System.Drawing.Size(198, 13);
            this.includeDateLabel.TabIndex = 8;
            this.includeDateLabel.Text = "Include date in new todos (yyyy-mm-dd)?";
            // 
            // includeDateCheck
            // 
            this.includeDateCheck.AutoSize = true;
            this.includeDateCheck.Location = new System.Drawing.Point(396, 110);
            this.includeDateCheck.Name = "includeDateCheck";
            this.includeDateCheck.Size = new System.Drawing.Size(15, 14);
            this.includeDateCheck.TabIndex = 7;
            this.includeDateCheck.Tag = "";
            this.includeDateCheck.UseVisualStyleBackColor = true;
            // 
            // settingsSaveButton
            // 
            this.settingsSaveButton.Location = new System.Drawing.Point(128, 153);
            this.settingsSaveButton.Name = "settingsSaveButton";
            this.settingsSaveButton.Size = new System.Drawing.Size(75, 23);
            this.settingsSaveButton.TabIndex = 9;
            this.settingsSaveButton.Text = "Save";
            this.settingsSaveButton.UseVisualStyleBackColor = true;
            // 
            // settingsCancelButton
            // 
            this.settingsCancelButton.Location = new System.Drawing.Point(251, 153);
            this.settingsCancelButton.Name = "settingsCancelButton";
            this.settingsCancelButton.Size = new System.Drawing.Size(75, 23);
            this.settingsCancelButton.TabIndex = 10;
            this.settingsCancelButton.Text = "Cancel";
            this.settingsCancelButton.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 188);
            this.Controls.Add(this.settingsCancelButton);
            this.Controls.Add(this.settingsSaveButton);
            this.Controls.Add(this.includeDateLabel);
            this.Controls.Add(this.includeDateCheck);
            this.Controls.Add(this.createBackupLabel);
            this.Controls.Add(this.createBackupCheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.settingsTitle);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label settingsTitle;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox createBackupCheck;
        private System.Windows.Forms.Label createBackupLabel;
        private System.Windows.Forms.Label includeDateLabel;
        private System.Windows.Forms.CheckBox includeDateCheck;
        private System.Windows.Forms.Button settingsSaveButton;
        private System.Windows.Forms.Button settingsCancelButton;
    }
}