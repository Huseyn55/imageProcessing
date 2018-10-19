namespace imageProc
{
    partial class ikiliFr
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
            this.görüntüAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüAçToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ikiliİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıntersectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.islemBox = new System.Windows.Forms.PictureBox();
            this.kaynakBox = new System.Windows.Forms.PictureBox();
            this.kaynak2Box = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynak2Box)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.ikiliİşlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1365, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.görüntüAçToolStripMenuItem,
            this.görüntüAçToolStripMenuItem1});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // görüntüAçToolStripMenuItem
            // 
            this.görüntüAçToolStripMenuItem.Name = "görüntüAçToolStripMenuItem";
            this.görüntüAçToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.görüntüAçToolStripMenuItem.Text = "1. Görüntü Aç";
            this.görüntüAçToolStripMenuItem.Click += new System.EventHandler(this.görüntüAçToolStripMenuItem_Click);
            // 
            // görüntüAçToolStripMenuItem1
            // 
            this.görüntüAçToolStripMenuItem1.Name = "görüntüAçToolStripMenuItem1";
            this.görüntüAçToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.görüntüAçToolStripMenuItem1.Text = "2. Görüntü Aç";
            this.görüntüAçToolStripMenuItem1.Click += new System.EventHandler(this.görüntüAçToolStripMenuItem1_Click);
            // 
            // ikiliİşlemlerToolStripMenuItem
            // 
            this.ikiliİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.subtractToolStripMenuItem,
            this.ıntersectToolStripMenuItem,
            this.mergeToolStripMenuItem});
            this.ikiliİşlemlerToolStripMenuItem.Name = "ikiliİşlemlerToolStripMenuItem";
            this.ikiliİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.ikiliİşlemlerToolStripMenuItem.Text = "İkili Görüntü İşlemleri";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // subtractToolStripMenuItem
            // 
            this.subtractToolStripMenuItem.Name = "subtractToolStripMenuItem";
            this.subtractToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subtractToolStripMenuItem.Text = "Subtract";
            this.subtractToolStripMenuItem.Click += new System.EventHandler(this.subtractToolStripMenuItem_Click);
            // 
            // ıntersectToolStripMenuItem
            // 
            this.ıntersectToolStripMenuItem.Name = "ıntersectToolStripMenuItem";
            this.ıntersectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ıntersectToolStripMenuItem.Text = "Merge";
            this.ıntersectToolStripMenuItem.Click += new System.EventHandler(this.MergeToolStripMenuItem_Click);
            // 
            // mergeToolStripMenuItem
            // 
            this.mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            this.mergeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mergeToolStripMenuItem.Text = "Intersect";
            this.mergeToolStripMenuItem.Click += new System.EventHandler(this.IntersectToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // islemBox
            // 
            this.islemBox.Location = new System.Drawing.Point(893, 27);
            this.islemBox.Name = "islemBox";
            this.islemBox.Size = new System.Drawing.Size(460, 480);
            this.islemBox.TabIndex = 4;
            this.islemBox.TabStop = false;
            // 
            // kaynakBox
            // 
            this.kaynakBox.Location = new System.Drawing.Point(12, 27);
            this.kaynakBox.Name = "kaynakBox";
            this.kaynakBox.Size = new System.Drawing.Size(460, 480);
            this.kaynakBox.TabIndex = 3;
            this.kaynakBox.TabStop = false;
            // 
            // kaynak2Box
            // 
            this.kaynak2Box.Location = new System.Drawing.Point(461, 27);
            this.kaynak2Box.Name = "kaynak2Box";
            this.kaynak2Box.Size = new System.Drawing.Size(460, 480);
            this.kaynak2Box.TabIndex = 5;
            this.kaynak2Box.TabStop = false;
            // 
            // ikiliFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 519);
            this.Controls.Add(this.kaynak2Box);
            this.Controls.Add(this.islemBox);
            this.Controls.Add(this.kaynakBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ikiliFr";
            this.Text = "İkili Görüntü Formu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynak2Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntüAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntüAçToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ikiliİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ıntersectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.PictureBox islemBox;
        private System.Windows.Forms.PictureBox kaynakBox;
        private System.Windows.Forms.PictureBox kaynak2Box;
    }
}