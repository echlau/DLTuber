using System;
using System.Windows.Forms;
using System.Net;
using YoutubeExtractor;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.Web;
using System.Collections.Generic;
using System.Linq;

namespace DLTuber
{
    public partial class Form1 : Form
    {
        private string title;
        private string ERR_MSSG = "DLTuber has failed to sense an active internet connection," + 
                                  "you can still use DLTuber but some features may not be available";
        private InternetConnection conn; 
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new InternetConnection(); 
            if(!isConnected(conn))
            {
                MessageBox.Show(ERR_MSSG, "No Internet Connection",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                selectVideo.Enabled = false;
            }   
            else
            {
                checkInternet.Enabled = false; 
            }
        }
        private bool isConnected(InternetConnection c)
        {
            return c.connected() ? true : false; 
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
        private void checkConn(object sender, EventArgs e)
        {
            if(conn.connected())
            {
                selectVideo.Enabled = true;
                checkInternet.Enabled = false; 
            }
            else
            {
               MessageBox.Show("DLTuber does not sense an internet connection", "No Internet Connection",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string openFileLocation(string fType)
        {
            string dir = " "; 
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
                
                dir = fileLocationDialog.FileName; 
            }
            return dir; 
        }
        private void downloadAudio(string type, string url, string path)
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
            if (!conn.connected())
            {
                MessageBox.Show("DLTuber does not sense an internet connection", "No Internet Connection",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                selectVideo.Enabled = false;
                checkInternet.Enabled = true; 
            }
            else
            {
                selectVideo.Enabled = true;
                checkInternet.Enabled = false;
                Button b = (Button)sender;
                string url = urlBox.Text;
                if (isValidUrl(url))
                {
                    loadThumbNail(url.Split('=')[1]);
                    string dir;
                    //System.Diagnostics.Debug.WriteLine(dir); 
                    if (radioButton1.Checked)
                    {
                        dir = openFileLocation("mp3");
                        downloadAudio("mp3", url, dir);
                    }
                    else if (radioButton2.Checked)
                    {
                        dir = openFileLocation("mp4");
                        downloadVideo("mp4", url, dir);
                    }
                    else
                    {
                        dir = openFileLocation("wav");
                    }
                }
            }
        }

        private void downloadVideo(string v, string url, string dir)
        {
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(url);
            /*
            * Select the first .mp4 video with 360p resolution
            */
            VideoInfo video = videoInfos
                .First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);

            /*
             * If the video has a decrypted signature, decipher it
             */
            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            /*
             * Create the video downloader.
             * The first argument is the video to download.
             * The second argument is the path to save the video file.
             */
            var videoDownloader = new VideoDownloader(video, dir);
            // Register the ProgressChanged event and print the current progress
            videoDownloader.DownloadProgressChanged += (sender, args) => progressBar1.Value = (int)(args.ProgressPercentage * 0.85);

            /*
             * Execute the video downloader.
             * For GUI applications note, that this method runs synchronously.
             */
            videoDownloader.Execute();
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
