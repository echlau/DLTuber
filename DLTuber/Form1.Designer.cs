namespace DLTuber
{
    partial class Form1
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
            this.urlBox = new System.Windows.Forms.TextBox();
            this.selectVideo = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.videoThumbNail = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.videoThumbNail)).BeginInit();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(9, 38);
            this.urlBox.Margin = new System.Windows.Forms.Padding(2);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(282, 20);
            this.urlBox.TabIndex = 0;
            this.urlBox.Text = "http://www.youtube.com/watch?v=KMU0tzLwhbE";
            // 
            // selectVideo
            // 
            this.selectVideo.Location = new System.Drawing.Point(315, 38);
            this.selectVideo.Margin = new System.Windows.Forms.Padding(2);
            this.selectVideo.Name = "selectVideo";
            this.selectVideo.Size = new System.Drawing.Size(95, 24);
            this.selectVideo.TabIndex = 1;
            this.selectVideo.Text = "Select Video";
            this.selectVideo.UseVisualStyleBackColor = true;
            this.selectVideo.Click += new System.EventHandler(this.handleVideoClick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 72);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(401, 19);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 2;
            // 
            // videoThumbNail
            // 
            this.videoThumbNail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.videoThumbNail.Location = new System.Drawing.Point(12, 120);
            this.videoThumbNail.Margin = new System.Windows.Forms.Padding(2);
            this.videoThumbNail.Name = "videoThumbNail";
            this.videoThumbNail.Size = new System.Drawing.Size(120, 132);
            this.videoThumbNail.TabIndex = 3;
            this.videoThumbNail.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(147, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(150, 170);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(91, 82);
            this.listBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Media Type:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 203);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 49);
            this.button2.TabIndex = 7;
            this.button2.Text = "Download";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "URL:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 287);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.videoThumbNail);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.selectVideo);
            this.Controls.Add(this.urlBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoThumbNail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Button selectVideo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox videoThumbNail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}

