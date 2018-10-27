namespace imageProc
{
    partial class AnaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkGetirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griDönüşümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanalSıralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parlaklıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ikiliGörüntülerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(279, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renkGetirToolStripMenuItem,
            this.griDönüşümToolStripMenuItem,
            this.kanalSıralaToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.ınvertToolStripMenuItem,
            this.parlaklıkToolStripMenuItem,
            this.ikiliGörüntülerToolStripMenuItem,
            this.thresholdToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // renkGetirToolStripMenuItem
            // 
            this.renkGetirToolStripMenuItem.Name = "renkGetirToolStripMenuItem";
            this.renkGetirToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.renkGetirToolStripMenuItem.Text = "Renk Getir";
            this.renkGetirToolStripMenuItem.Click += new System.EventHandler(this.renkGetirToolStripMenuItem_Click);
            // 
            // griDönüşümToolStripMenuItem
            // 
            this.griDönüşümToolStripMenuItem.Name = "griDönüşümToolStripMenuItem";
            this.griDönüşümToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.griDönüşümToolStripMenuItem.Text = "Gri Yöntemleri";
            this.griDönüşümToolStripMenuItem.Click += new System.EventHandler(this.griDönüşümToolStripMenuItem_Click);
            // 
            // kanalSıralaToolStripMenuItem
            // 
            this.kanalSıralaToolStripMenuItem.Name = "kanalSıralaToolStripMenuItem";
            this.kanalSıralaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.kanalSıralaToolStripMenuItem.Text = "Kanal Sırala";
            this.kanalSıralaToolStripMenuItem.Click += new System.EventHandler(this.kanalSıralaToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // ınvertToolStripMenuItem
            // 
            this.ınvertToolStripMenuItem.Name = "ınvertToolStripMenuItem";
            this.ınvertToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ınvertToolStripMenuItem.Text = "Invert";
            this.ınvertToolStripMenuItem.Click += new System.EventHandler(this.ınvertToolStripMenuItem_Click);
            // 
            // parlaklıkToolStripMenuItem
            // 
            this.parlaklıkToolStripMenuItem.Name = "parlaklıkToolStripMenuItem";
            this.parlaklıkToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.parlaklıkToolStripMenuItem.Text = "Parlaklık";
            this.parlaklıkToolStripMenuItem.Click += new System.EventHandler(this.parlaklıkToolStripMenuItem_Click);
            // 
            // ikiliGörüntülerToolStripMenuItem
            // 
            this.ikiliGörüntülerToolStripMenuItem.Name = "ikiliGörüntülerToolStripMenuItem";
            this.ikiliGörüntülerToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ikiliGörüntülerToolStripMenuItem.Text = "İkili Görüntü İşlemleri";
            this.ikiliGörüntülerToolStripMenuItem.Click += new System.EventHandler(this.ikiliGörüntülerToolStripMenuItem_Click);
            // 
            // thresholdToolStripMenuItem
            // 
            this.thresholdToolStripMenuItem.Name = "thresholdToolStripMenuItem";
            this.thresholdToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.thresholdToolStripMenuItem.Text = "Threshold";
            this.thresholdToolStripMenuItem.Click += new System.EventHandler(this.thresholdToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 333);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "Ana Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkGetirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griDönüşümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanalSıralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ınvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parlaklıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ikiliGörüntülerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdToolStripMenuItem;
    }
}

