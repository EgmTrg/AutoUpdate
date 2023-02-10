using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace AutoUpdateWithGithub {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void checkUpdate() {
            string urlVersion = "https://raw.githubusercontent.com/EgmTrg/AutoUpdateWithGithub/main/AutoUpdateWithGithub/update/version.txt";
            string newVersion = new WebClient().DownloadString(urlVersion);
            string version = Application.ProductVersion.ToString();

            newVersion = newVersion.Replace(".", "");
            version = version.Replace(".", "");

            if (Convert.ToInt32(newVersion) > Convert.ToInt32(version)) {
                hasUpdate_label.Text = "Update Mevcut!";
                newVersion_label.Text = new WebClient().DownloadString(urlVersion);
                button.Enabled = true;
            }
        }

        private void button_Click(object sender, EventArgs e) {
            WebClient web = new WebClient();
            web.DownloadFileCompleted += Web_DownloadFileCompleted;
            web.DownloadFileAsync(
                new Uri("https://github.com/EgmTrg/AutoUpdateWithGithub/blob/main/AutoUpdateWithGithub/update/update.msi"),
                "C:\\Users\\eturo\\Downloads\\update.msi"
                );
        }

        private void Web_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
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

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) {
            checkUpdate();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e) {
            backgroundWorker1.RunWorkerAsync();
        }

        private void Form1_Load(object sender, EventArgs e) {
            backgroundWorker1.RunWorkerAsync();

            appVersion_label.Text = Application.ProductVersion.ToString();
        }
    }
}
