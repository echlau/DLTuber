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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mediaTypeBox = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.videoThumbNail)).BeginInit();
            this.mediaTypeBox.SuspendLayout();
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
            this.selectVideo.Location = new System.Drawing.Point(304, 39);
            this.selectVideo.Margin = new System.Windows.Forms.Padding(2);
            this.selectVideo.Name = "selectVideo";
            this.selectVideo.Size = new System.Drawing.Size(95, 20);
            this.selectVideo.TabIndex = 1;
            this.selectVideo.Text = "Select Video";
            this.selectVideo.UseVisualStyleBackColor = true;
            this.selectVideo.Click += new System.EventHandler(this.handleVideoClick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 292);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(401, 19);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 2;
            // 
            // videoThumbNail
            // 
            this.videoThumbNail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.videoThumbNail.Location = new System.Drawing.Point(12, 108);
            this.videoThumbNail.Margin = new System.Windows.Forms.Padding(2);
            this.videoThumbNail.Name = "videoThumbNail";
            this.videoThumbNail.Size = new System.Drawing.Size(320, 180);
            this.videoThumbNail.TabIndex = 3;
            this.videoThumbNail.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Media Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Youtube URL:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 20);
            this.button1.TabIndex = 9;
            this.button1.Text = "Open Location";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mediaTypeBox
            // 
            this.mediaTypeBox.Controls.Add(this.radioButton3);
            this.mediaTypeBox.Controls.Add(this.radioButton2);
            this.mediaTypeBox.Controls.Add(this.radioButton1);
            this.mediaTypeBox.Location = new System.Drawing.Point(371, 109);
            this.mediaTypeBox.Name = "mediaTypeBox";
            this.mediaTypeBox.Size = new System.Drawing.Size(78, 79);
            this.mediaTypeBox.TabIndex = 10;
            this.mediaTypeBox.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(18, 55);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "wav";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "mp4";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "mp3";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 351);
            this.Controls.Add(this.mediaTypeBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.videoThumbNail);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.selectVideo);
            this.Controls.Add(this.urlBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.videoThumbNail)).EndInit();
            this.mediaTypeBox.ResumeLayout(false);
            this.mediaTypeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Button selectVideo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox videoThumbNail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox mediaTypeBox;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

