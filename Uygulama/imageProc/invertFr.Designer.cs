namespace imageProc
{
    partial class InvertFr
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
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çAlıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.islemBox = new System.Windows.Forms.PictureBox();
            this.kaynakBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.ınvertToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // ınvertToolStripMenuItem
            // 
            this.ınvertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çAlıştırToolStripMenuItem});
            this.ınvertToolStripMenuItem.Name = "ınvertToolStripMenuItem";
            this.ınvertToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.ınvertToolStripMenuItem.Text = "Invert";
            // 
            // çAlıştırToolStripMenuItem
            // 
            this.çAlıştırToolStripMenuItem.Name = "çAlıştırToolStripMenuItem";
            this.çAlıştırToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.çAlıştırToolStripMenuItem.Text = "Çalıştır";
            this.çAlıştırToolStripMenuItem.Click += new System.EventHandler(this.çAlıştırToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // islemBox
            // 
            this.islemBox.Location = new System.Drawing.Point(510, 27);
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
            // InvertFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 532);
            this.Controls.Add(this.islemBox);
            this.Controls.Add(this.kaynakBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InvertFr";
            this.Text = "Invert Formu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ınvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çAlıştırToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox islemBox;
        private System.Windows.Forms.PictureBox kaynakBox;
    }
}