namespace imageProc
{
    partial class ledYakFr
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
            this.components = new System.ComponentModel.Container();
            this.portCombo = new System.Windows.Forms.ComboBox();
            this.portBagla = new System.Windows.Forms.Button();
            this.ledYak = new System.Windows.Forms.Button();
            this.ledKapat = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.portKes = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // portCombo
            // 
            this.portCombo.FormattingEnabled = true;
            this.portCombo.Location = new System.Drawing.Point(133, 45);
            this.portCombo.Name = "portCombo";
            this.portCombo.Size = new System.Drawing.Size(117, 21);
            this.portCombo.TabIndex = 0;
            // 
            // portBagla
            // 
            this.portBagla.Location = new System.Drawing.Point(272, 42);
            this.portBagla.Name = "portBagla";
            this.portBagla.Size = new System.Drawing.Size(82, 23);
            this.portBagla.TabIndex = 1;
            this.portBagla.Text = "Bağlan";
            this.portBagla.UseVisualStyleBackColor = true;
            this.portBagla.Click += new System.EventHandler(this.button1_Click);
            // 
            // ledYak
            // 
            this.ledYak.Location = new System.Drawing.Point(157, 103);
            this.ledYak.Name = "ledYak";
            this.ledYak.Size = new System.Drawing.Size(115, 81);
            this.ledYak.TabIndex = 2;
            this.ledYak.Text = "Led Yak";
            this.ledYak.UseVisualStyleBackColor = true;
            this.ledYak.Click += new System.EventHandler(this.button2_Click);
            // 
            // ledKapat
            // 
            this.ledKapat.Location = new System.Drawing.Point(318, 103);
            this.ledKapat.Name = "ledKapat";
            this.ledKapat.Size = new System.Drawing.Size(112, 81);
            this.ledKapat.TabIndex = 3;
            this.ledKapat.Text = "Led Kapat";
            this.ledKapat.UseVisualStyleBackColor = true;
            this.ledKapat.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 225);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(613, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // portKes
            // 
            this.portKes.Location = new System.Drawing.Point(372, 43);
            this.portKes.Name = "portKes";
            this.portKes.Size = new System.Drawing.Size(80, 23);
            this.portKes.TabIndex = 5;
            this.portKes.Text = "Bağlantı Kes";
            this.portKes.UseVisualStyleBackColor = true;
            this.portKes.Click += new System.EventHandler(this.portKes_Click);
            // 
            // ledYakFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 250);
            this.Controls.Add(this.portKes);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ledKapat);
            this.Controls.Add(this.ledYak);
            this.Controls.Add(this.portBagla);
            this.Controls.Add(this.portCombo);
            this.Name = "ledYakFr";
            this.Text = "Led Kontrol Formu";
            this.Load += new System.EventHandler(this.ledYakFr_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portCombo;
        private System.Windows.Forms.Button portBagla;
        private System.Windows.Forms.Button ledYak;
        private System.Windows.Forms.Button ledKapat;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button portKes;
    }
}