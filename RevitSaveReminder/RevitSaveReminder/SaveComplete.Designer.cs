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
            this.lblSaveTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaveTitle
            // 
            this.lblSaveTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveTitle.Location = new System.Drawing.Point(81, 9);
            this.lblSaveTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSaveTitle.Name = "lblSaveTitle";
            this.lblSaveTitle.Size = new System.Drawing.Size(396, 65);
            this.lblSaveTitle.TabIndex = 0;
            this.lblSaveTitle.Text = "Document Synchronized with central at 1.00 PM";
            this.lblSaveTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SaveComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 187);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSaveTitle);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "SaveComplete";
            this.Text = "Save to Central Complete";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSaveTitle;
        private System.Windows.Forms.Button button1;
    }
}