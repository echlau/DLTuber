using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DLTuber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.SetState(2);
            progressBar1.Increment(40);
        }
        private bool isValidUrl(string url)
        {
            bool flag = false; 
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "HEAD";
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    flag = response.ResponseUri.ToString().Contains("youtube.com") ? true : false;
            }                
            catch(WebException e)
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
            } 
            catch(WebException e)
            {
                //videoThumbNail.Image = System.Drawing.Image.ErrorImage; 
            }
            MessageBox.Show(videoThumbNail.Image.Size.Width + " " + videoThumbNail.Image.Size.Height);
        }
        private void handleVideoClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string url = urlBox.Text; 
            if(isValidUrl(url))
            {
                loadThumbNail(url.Split('=')[1]); 
            }
            else
            {
                MessageBox.Show("Not a valid Youtube URL please try again "); 
            }
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
