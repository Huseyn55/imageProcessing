using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageProc
{
    public partial class ParlaklikFr : Form
    {
        Bitmap kaynak, islem;
        public ParlaklikFr()
        {
            InitializeComponent();
        }

        private void ParlaklikFr_Load(object sender, EventArgs e)
        {
            label1.Text = "P:"+trackBar1.Value.ToString();
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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "P: " + trackBar1.Value.ToString();
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renkliRenk = kaynak.GetPixel(x, y);
                    int red = renkliRenk.R + trackBar1.Value;
                    int green = renkliRenk.G + trackBar1.Value;
                    int blue = renkliRenk.B + trackBar1.Value;
                    if (red < 0) red = 0;
                    if (red > 255) red = 255;
                    if (green < 0) green = 0;
                    if (green > 255) green = 255;
                    if (blue < 0) blue = 0;
                    if (blue > 255) blue = 255;
                    Color yeniRenk = Color.FromArgb(red, green, blue);
                    islem.SetPixel(x, y, yeniRenk);
                }
            }

            islemBox.Image = islem;
        }
    }
}
