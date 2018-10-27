using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;

namespace imageProc
{
    public partial class thresholdFr : Form
    {
        Bitmap kaynak, islem;
        public thresholdFr()
        {
            InitializeComponent();
        }

        private void önTanımlıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            int tValue = 100;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    int gri = (renkliRenk.R + renkliRenk.G + renkliRenk.B) / 3;
                    if (gri > tValue) gri = 255; else gri = 0;
                    Color griRenk = Color.FromArgb(gri, gri, gri);
                    islem.SetPixel(x, y, griRenk);
                }
            }

            islemBox.Image = islem;
        }

        private void bradleyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem = new GrayscaleBT709().Apply(kaynak);
            islem = new BradleyLocalThresholding().Apply(islem);
            islemBox.Image = islem;
        }

        private void otusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem = new GrayscaleBT709().Apply(kaynak);
            islem = new OtsuThreshold().Apply(islem);
            islemBox.Image = islem;
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;
            }
        }
    }
}
