using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
namespace DLTuber
{
    public partial class FormStatus : Form
    {
        public FormStatus()
        {
            InitializeComponent();
            NetworkChange.NetworkAvailabilityChanged += AvailabilityChanged; 
        }

        public ProgressBar getProgressBar()
        {
            return progressBar1;
        }
        public void setTitle(String title)
        {
            label1.Text = "Title: " + title;
        }
        private void cancelDownload(object sender, EventArgs e)
        {
          
        }
        private void AvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            MessageBox.Show("A problem occured while downloading your video, please check the internet and reset DLTuber"
                            ,"No Internet Connection",MessageBoxButtons.OK
                            , MessageBoxIcon.Error); 
        }
    }
}
