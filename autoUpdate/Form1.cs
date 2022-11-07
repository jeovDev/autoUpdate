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
        //WE ARE GOING TO ADD A FOLDER IN OUR SERVER FOR THIS EXAMPLE I WILL USE XAMPP

        //we need to grant or run this app as an administrator

        //now lets create the setup file
        //first we need to download microsoft visual studio install from extension tab

        //lets create the bat file
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void checkUpdate() {

            var urlVersion = "http://localhost/update/version.txt";
            var newVersion = (new WebClient()).DownloadString(urlVersion);
            var currentVersion = Application.ProductVersion.ToString();

            //this will format or remove the dot in txt version so that we can convert it to integer and compare 
            //the two version
            newVersion = newVersion.Replace(".","");
            currentVersion = currentVersion.Replace(".", "");

            //since we are putthing this method inside the background worker. we need to invoke our controls

            this.Invoke(new Action(() =>
            {

                if (Convert.ToInt32(newVersion) > Convert.ToInt32(currentVersion))
                {
                    //If newversion is greater to the current version it means a new version is available
                 //   textbox1.Text = "A new version is available " + Environment.NewLine + "Do you want to Update ? " + Environment.NewLine +
                  //      "New version Aailbel : " + newVersion + Environment.NewLine + "Current Version : " + Application.ProductVersion.ToString();
                    btnUpdate.Show();
                }
                else
                {
                //    textbox1.Text = "The version is up to date" + Environment.NewLine + "Version : " + Application.ProductVersion.ToString();
                    btnUpdate.Hide();
                }

            }));
          

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //we are using background worker to always check if new version is available
            checkUpdate();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                WebClient web = new WebClient();
                web.DownloadFileCompleted += Web_DownloadFileCompleted;
                web.DownloadFileAsync(new Uri("http://localhost/update/update.msi"), @"C:\Users\Acer\Downloads\location\update.msi");
            } catch (Exception er) { MessageBox.Show(er.ToString()); }
           

        }

        private void Web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            initScript(); 
        }

        private void initScript() {

            

            //run batch script
            String scriptPath = Application.StartupPath + @"\batch.bat"; // we need to place our bat file inside our debug folder

            //the reason we are using batch script is to avoid conflict during the installation of the updated app
            //we need to stop or kill the process of the app before installing or updating the app


            Process p = new Process();
            p.StartInfo.FileName = scriptPath;
            p.StartInfo.Arguments = "";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.Verb = "runas";
            p.Start();
            Environment.Exit(1);
        }
    }
}
