namespace DLTuber
{
    partial class MainForm
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
            this.videoThumbNail = new System.Windows.Forms.PictureBox();
            this.vidTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mediaTypeBox = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.fileLocationDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.videoThumbNail)).BeginInit();
            this.mediaTypeBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(9, 58);
            this.urlBox.Margin = new System.Windows.Forms.Padding(2);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(282, 20);
            this.urlBox.TabIndex = 0;
            this.urlBox.Text = "http://www.youtube.com/watch?v=KMU0tzLwhbE";
            // 
            // selectVideo
            // 
            this.selectVideo.Location = new System.Drawing.Point(215, 82);
            this.selectVideo.Margin = new System.Windows.Forms.Padding(2);
            this.selectVideo.Name = "selectVideo";
            this.selectVideo.Size = new System.Drawing.Size(76, 24);
            this.selectVideo.TabIndex = 1;
            this.selectVideo.Text = "Download ";
            this.selectVideo.UseVisualStyleBackColor = true;
            this.selectVideo.Click += new System.EventHandler(this.handleVideoClick);
            // 
            // videoThumbNail
            // 
            this.videoThumbNail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.videoThumbNail.Location = new System.Drawing.Point(12, 133);
            this.videoThumbNail.Margin = new System.Windows.Forms.Padding(2);
            this.videoThumbNail.Name = "videoThumbNail";
            this.videoThumbNail.Size = new System.Drawing.Size(320, 180);
            this.videoThumbNail.TabIndex = 3;
            this.videoThumbNail.TabStop = false;
            // 
            // vidTitle
            // 
            this.vidTitle.Location = new System.Drawing.Point(9, 108);
            this.vidTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vidTitle.Name = "vidTitle";
            this.vidTitle.Size = new System.Drawing.Size(390, 23);
            this.vidTitle.TabIndex = 4;
            this.vidTitle.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Media Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Youtube URL:";
            // 
            // mediaTypeBox
            // 
            this.mediaTypeBox.Controls.Add(this.radioButton3);
            this.mediaTypeBox.Controls.Add(this.radioButton2);
            this.mediaTypeBox.Controls.Add(this.radioButton1);
            this.mediaTypeBox.Location = new System.Drawing.Point(349, 174);
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
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "mp3";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(453, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkConnectionToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // checkConnectionToolStripMenuItem
            // 
            this.checkConnectionToolStripMenuItem.Name = "checkConnectionToolStripMenuItem";
            this.checkConnectionToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.checkConnectionToolStripMenuItem.Text = "Check Connection";
            this.checkConnectionToolStripMenuItem.Click += new System.EventHandler(this.checkConn);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 342);
            this.Controls.Add(this.mediaTypeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vidTitle);
            this.Controls.Add(this.videoThumbNail);
            this.Controls.Add(this.selectVideo);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = " DLTuber";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoThumbNail)).EndInit();
            this.mediaTypeBox.ResumeLayout(false);
            this.mediaTypeBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Button selectVideo;
        private System.Windows.Forms.PictureBox videoThumbNail;
        private System.Windows.Forms.Label vidTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox mediaTypeBox;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.SaveFileDialog fileLocationDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkConnectionToolStripMenuItem;
    }
}

