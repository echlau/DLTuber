namespace DLTuber
{
    partial class FormStatus
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
            this.statusBar = new System.Windows.Forms.ProgressBar();
            this.vidTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(21, 61);
            this.statusBar.Margin = new System.Windows.Forms.Padding(2);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(281, 19);
            this.statusBar.TabIndex = 0;
            // 
            // vidTitle
            // 
            this.vidTitle.AutoSize = true;
            this.vidTitle.Location = new System.Drawing.Point(18, 23);
            this.vidTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vidTitle.Name = "vidTitle";
            this.vidTitle.Size = new System.Drawing.Size(30, 13);
            this.vidTitle.TabIndex = 1;
            this.vidTitle.Text = "Title:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 129);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vidTitle);
            this.Controls.Add(this.statusBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormStatus";
            this.Text = "Download Progress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar statusBar;
        private System.Windows.Forms.Label vidTitle;
        private System.Windows.Forms.Button button1;
    }
}