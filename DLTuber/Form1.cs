using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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
            videoThumbNail.Load("http://img.youtube.com/vi/" + url + "/1.jpg"); 
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
                MessageBox.Show("Not a Valid URL "); 
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

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
