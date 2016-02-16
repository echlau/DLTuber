using System;
using System.Windows.Forms;
using System.Net;
using YoutubeExtractor;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections.Specialized;
using System.Web;

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
            progressBar1.SetState(2);
            progressBar1.Increment(40);
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
                videoThumbNail.Load("https://i.ytimg.com/vi/" + url + "/mqdefault.jpg");
                title = GetTitle(url);
                vidTitle.Text = "Title: " + title;
            } 
            catch(WebException e)
            {
                //videoThumbNail.Image = System.Drawing.Image.ErrorImage; 
            }
            
        }
        private string openFileLocation()
        {
            string dir = " ";
            DialogResult res = fileLocationDialog.ShowDialog(); 
            if(res == DialogResult.OK)
            {
                dir = Path.GetDirectoryName(fileLocationDialog.FileName); 
            }

           /* FolderBrowserDialog currentPath = new FolderBrowserDialog();
            fileLoc.InitialDirectory = currentPath.SelectedPath;
            DialogResult res = fileLoc.ShowDialog();
            if (res == DialogResult.OK)
                dir = fileLoc.FileName; */ 

            return dir; 
        }
        private void downloadVideo()
        {
            //Parameter for video type
        }
        private void handleVideoClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string url = urlBox.Text; 
            if(isValidUrl(url))
            {
                loadThumbNail(url.Split('=')[1]);
                //string dir = openFileLocation();
                //MessageBox.Show(dir); 
                if (radioButton1.Checked)
                {
                    MessageBox.Show(radioButton1.Text);
                }
                else if (radioButton2.Checked)
                {
                    MessageBox.Show(radioButton2.Text);
                }
                else
                {
                    
                    MessageBox.Show(radioButton3.Text);
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
