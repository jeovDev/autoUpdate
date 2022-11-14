using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoUpdate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbnew.Hide();
            labelnew.Hide();
            bw_updateChecker.RunWorkerAsync();
            lbcurrent.Text = Application.ProductVersion.ToString();
        }
        private void checkUpdate() {

            var urlVersion = "http://localhost/update/version.txt";
            var newVersion = (new WebClient().DownloadString(urlVersion));
            var currentVersion = Application.ProductVersion.ToString();

            newVersion = newVersion.Replace(".","");
            currentVersion = currentVersion.Replace(".","");

            this.Invoke(new Action(() =>
            {
                if (Convert.ToInt32(newVersion) > Convert.ToInt32(currentVersion))
                {
                    lbheader.Text = "A New Version is Available.\r\nDo you want to Update ?\r\n";
                    lbnew.Text = (new WebClient().DownloadString(urlVersion));
                    btnUpdate.Enabled = true;
                    lbnew.Show();
                    labelnew.Show();
                }
                else
                {
                    lbheader.Text = "The version is up to date";

                    btnUpdate.Enabled = true;
                    lbnew.Hide();
                    labelnew.Hide();

                }
            }));
           
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            WebClient web = new WebClient();
            web.DownloadFileCompleted += Web_DownloadFileCompleted;
            web.DownloadFileAsync(new Uri("http://localhost/update/update.msi"), "C:\\Users\\Acer\\Downloads\\location\\update.msi");
        }

        private void Web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            initScript(); 
        }

        private void initScript() { 
        
            string path = Application.StartupPath + @"\bat.bat";

            Process p = new Process();
            p.StartInfo.FileName = path;
            p.StartInfo.Arguments = "";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.Verb = "runas";
            p.Start();
            Environment.Exit(1);
        
        }
        private void bw_updateChecker_DoWork(object sender, DoWorkEventArgs e)
        {
            checkUpdate();
        }

        private void bw_updateChecker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bw_updateChecker.RunWorkerAsync();
        }

       
    }
}
