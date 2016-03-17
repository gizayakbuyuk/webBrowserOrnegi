namespace web_Browser_Örneği
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonGeri = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonileri = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonYenile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAnasayfa = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxAdres = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonGiris = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 43);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(877, 437);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonGeri,
            this.toolStripButtonileri,
            this.toolStripButtonYenile,
            this.toolStripButtonAnasayfa,
            this.toolStripComboBoxAdres,
            this.toolStripButtonGiris});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(877, 43);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonGeri
            // 
            this.toolStripButtonGeri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGeri.Image = global::web_Browser_Örneği.Properties.Resources.geri;
            this.toolStripButtonGeri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGeri.Name = "toolStripButtonGeri";
            this.toolStripButtonGeri.Size = new System.Drawing.Size(34, 40);
            this.toolStripButtonGeri.Text = "Geri";
            this.toolStripButtonGeri.Click += new System.EventHandler(this.toolStripButtonGeri_Click);
            // 
            // toolStripButtonileri
            // 
            this.toolStripButtonileri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonileri.Image = global::web_Browser_Örneği.Properties.Resources.ileri;
            this.toolStripButtonileri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonileri.Name = "toolStripButtonileri";
            this.toolStripButtonileri.Size = new System.Drawing.Size(34, 40);
            this.toolStripButtonileri.Text = "İleri";
            this.toolStripButtonileri.Click += new System.EventHandler(this.toolStripButtonileri_Click);
            // 
            // toolStripButtonYenile
            // 
            this.toolStripButtonYenile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonYenile.Image = global::web_Browser_Örneği.Properties.Resources.yenile;
            this.toolStripButtonYenile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonYenile.Name = "toolStripButtonYenile";
            this.toolStripButtonYenile.Size = new System.Drawing.Size(34, 40);
            this.toolStripButtonYenile.Text = "Yenile";
            this.toolStripButtonYenile.Click += new System.EventHandler(this.toolStripButtonYenile_Click);
            // 
            // toolStripButtonAnasayfa
            // 
            this.toolStripButtonAnasayfa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAnasayfa.Image = global::web_Browser_Örneği.Properties.Resources.anasayfa;
            this.toolStripButtonAnasayfa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAnasayfa.Name = "toolStripButtonAnasayfa";
            this.toolStripButtonAnasayfa.Size = new System.Drawing.Size(34, 40);
            this.toolStripButtonAnasayfa.Text = "Ana Sayfaya Git";
            this.toolStripButtonAnasayfa.Click += new System.EventHandler(this.toolStripButtonAnasayfa_Click);
            // 
            // toolStripComboBoxAdres
            // 
            this.toolStripComboBoxAdres.Name = "toolStripComboBoxAdres";
            this.toolStripComboBoxAdres.Size = new System.Drawing.Size(500, 43);
            this.toolStripComboBoxAdres.Sorted = true;
            this.toolStripComboBoxAdres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripComboBoxAdres_KeyDown);
            // 
            // toolStripButtonGiris
            // 
            this.toolStripButtonGiris.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGiris.Image = global::web_Browser_Örneği.Properties.Resources.giriş;
            this.toolStripButtonGiris.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGiris.Name = "toolStripButtonGiris";
            this.toolStripButtonGiris.Size = new System.Drawing.Size(34, 40);
            this.toolStripButtonGiris.Text = "Giriş";
            this.toolStripButtonGiris.Click += new System.EventHandler(this.toolStripButtonGiris_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(877, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(135, 17);
            this.toolStripStatusLabel1.Text = "Sayfa Görüntülenemiyor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 502);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonGeri;
        private System.Windows.Forms.ToolStripButton toolStripButtonileri;
        private System.Windows.Forms.ToolStripButton toolStripButtonYenile;
        private System.Windows.Forms.ToolStripButton toolStripButtonAnasayfa;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxAdres;
        private System.Windows.Forms.ToolStripButton toolStripButtonGiris;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

