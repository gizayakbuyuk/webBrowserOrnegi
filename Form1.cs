using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace web_Browser_Örneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.google.com.tr");
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                if (e.CurrentProgress > 0 && e.MaximumProgress > 0 )
                 {
                   toolStripProgressBar1.ProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
                  }
            }
            catch (Exception)
            {
                toolStripProgressBar1.ProgressBar.Value = 0;
            }

        }

        private void toolStripButtonGiris_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripComboBoxAdres.Text);
            toolStripStatusLabel1.Text = "Sayfa Yükleniyor...";
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Sayfa Yüklendi";
            toolStripProgressBar1.ProgressBar.Value = 0;
        }

        private void toolStripButtonGeri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButtonileri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButtonYenile_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButtonAnasayfa_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.google.com.tr");
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            toolStripComboBoxAdres.Text = webBrowser1.Url.ToString();
            toolStripStatusLabel1.Text = "Sayfa Yükleniyor...";
            string adres = webBrowser1.Url.ToString();
            if (toolStripComboBoxAdres.Items.IndexOf(adres)==-1)
                toolStripComboBoxAdres.Items.Add(adres);
        }

        private void toolStripComboBoxAdres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                toolStripButtonGiris.PerformClick();
        }
    }
}
