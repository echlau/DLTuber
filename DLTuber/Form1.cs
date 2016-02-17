using System;
using System.Windows.Forms;
using System.Net;
using YoutubeExtractor;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections.Specialized;
using System.Web;
using System.Collections.Generic;
using System.Linq;

namespace DLTuber
{
    public partial class Form1 : Form
    {
        private string title; 

        //private byte[] downloadedByteStream;
        //private IEnumerable<VideoInfo> videoInfos; 
        //private VideoDownloader downloader = new VideoDownloader(); 
        public Form1()
        {
            InitializeComponent();
            //progressBar1.SetState(1);
        }
        private bool isValidUrl(string url)
        {            
            bool flag = false; 
            
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "HEAD";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    flag = response.ResponseUri.ToString().Contains("youtube.com") ? true : false;
            }                
            catch(WebException e)
            {
                return flag; 
            }
            catch(UriFormatException e)
            {
                return flag; 
            }
            return flag; 
        }
        private void loadThumbNail(string url)
        {
            try
            {
                title = GetTitle(url);
                vidTitle.Text = "Title: " + title;
                videoThumbNail.Load("https://i.ytimg.com/vi/" + url + "/mqdefault.jpg");
            } 
            catch(WebException e)
            {
                //videoThumbNail.Image = System.Drawing.Image.ErrorImage; 
            }
            
        }
        private string openFileLocation(string fType)
        {
            string dir = " "; 
            //fileLocationDialog.Filter = "mp3|*.mp3|mp4|*.mp4|wav|*.wav";
            switch(fType)
            {
                case "mp3":
                    fileLocationDialog.Filter = "mp3|*.mp3";
                    break;
                case "mp4":
                    fileLocationDialog.Filter = "mp4|*.mp4";
                    break;
                case "wav":
                    fileLocationDialog.Filter = "wav|*.wav";
                    break;
            }
            if(fileLocationDialog.ShowDialog() == DialogResult.OK)
            {
                //dir = Path.GetDirectoryName(fileLocationDialog.FileName);
                dir = fileLocationDialog.FileName; 
            }

           /* FolderBrowserDialog currentPath = new FolderBrowserDialog();
            fileLoc.InitialDirectory = currentPath.SelectedPath;
            DialogResult res = fileLoc.ShowDialog();
            if (res == DialogResult.OK)
                dir = fileLoc.FileName; */ 

            return dir; 
        }
        private void downloadVideo(string type, string url, string path)
        {
            if (path != " ")
            {
                //Parameter for video type
                IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(url);
                VideoInfo video = videoInfos.Where(info => info.CanExtractAudio).OrderByDescending(info => info.AudioBitrate).First();
                if (video.RequiresDecryption)
                {
                    DownloadUrlResolver.DecryptDownloadUrl(video);
                }
                var audioDownloader = new AudioDownloader(video, path);
                audioDownloader.DownloadProgressChanged += (sender, args) => progressBar1.Value = (int)(args.ProgressPercentage * 0.85);
                audioDownloader.AudioExtractionProgressChanged += (sender, args) => progressBar1.Value = (int)(85 + args.ProgressPercentage * 0.15);

                audioDownloader.Execute();
            }
        }
        private void handleVideoClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string url = urlBox.Text; 
            if(isValidUrl(url))
            {
                loadThumbNail(url.Split('=')[1]);
                string dir;
                //System.Diagnostics.Debug.WriteLine(dir); 
                if (radioButton1.Checked)
                {
                    dir = openFileLocation("mp3");
                    downloadVideo("mp3", url, dir);
                }
                else if (radioButton2.Checked)
                {
                    dir = openFileLocation("mp4");
                    //downloadVideo("mp4", url, dir);
                }
                else
                {
                    dir = openFileLocation("wav");
                }
            }
            //Switch statement for radio buttons
            else
            {
                vidTitle.Text = "Title";
                videoThumbNail.Image = null;
                MessageBox.Show("Not a valid Youtube URL please try again "); 
            }
        }
        public string GetTitle(string url)
        {
            WebClient client = new WebClient();
            return GetArgs(client.DownloadString("http://youtube.com/get_video_info?video_id=" + url), "title", '&');
        }

        private string GetArgs(string args, string key, char query)
        {
            int iqs = args.IndexOf(query);
            string querystring = null;

            if (iqs != -1)
            {
                querystring = (iqs < args.Length - 1) ? args.Substring(iqs + 1) : String.Empty;
                NameValueCollection nvcArgs = HttpUtility.ParseQueryString(querystring);
                return nvcArgs[key];
            }
            return String.Empty; // or throw an error
        }
    }

    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
