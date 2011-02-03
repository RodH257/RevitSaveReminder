namespace RevitSaveReminder
{
    partial class SaveComplete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveComplete));
            this.SaveTitleLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveTitleLabel
            // 
            this.SaveTitleLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveTitleLabel.Location = new System.Drawing.Point(74, 9);
            this.SaveTitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SaveTitleLabel.Name = "SaveTitleLabel";
            this.SaveTitleLabel.Size = new System.Drawing.Size(396, 65);
            this.SaveTitleLabel.TabIndex = 0;
            this.SaveTitleLabel.Text = "Document Synchronized with central at 1.00 PM";
            this.SaveTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(198, 95);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(148, 65);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SaveComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 187);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.SaveTitleLabel);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "SaveComplete";
            this.Text = "Save to Central Complete";
            this.Load += new System.EventHandler(this.SaveComplete_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SaveTitleLabel;
        private System.Windows.Forms.Button OkButton;
    }
}