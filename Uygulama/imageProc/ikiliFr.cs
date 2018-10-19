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
    public partial class ikiliFr : Form
    {
        Bitmap kaynak, kaynak2, islem;

        private void görüntüAçToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog2.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak2 = new Bitmap(openFileDialog2.FileName);
                kaynak2Box.Image = kaynak2;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            int red, green, blue = 0;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renk1 = kaynak.GetPixel(x, y);
                    Color renk2 = kaynak2.GetPixel(x, y);
                    red = renk1.R + renk2.R;
                    green = renk1.G + renk2.G;
                    blue = renk1.B + renk2.B;
                    if (red > 255) red = 255;
                    if (green > 255) green = 255;
                    if (blue > 255) blue = 255;
                    Color yeniRenk = Color.FromArgb(red, green, blue);
                    islem.SetPixel(x, y, yeniRenk);
                }
            }
            islemBox.Image = islem;
        }

        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            int red, green, blue = 0;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renk1 = kaynak.GetPixel(x, y);
                    Color renk2 = kaynak2.GetPixel(x, y);
                    red = renk1.R - renk2.R;
                    green = renk1.G - renk2.G;
                    blue = renk1.B - renk2.B;
                    if (red < 0) red = 0;
                    if (green < 0) green = 0;
                    if (blue < 0) blue = 0;
                    Color yeniRenk = Color.FromArgb(red, green, blue);
                    islem.SetPixel(x, y, yeniRenk);
                }
            }
            islemBox.Image = islem;
        }

        private void MergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            int red, green, blue = 0;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renk1 = kaynak.GetPixel(x, y);
                    Color renk2 = kaynak2.GetPixel(x, y);
                    if (renk1.R > renk2.R) { red = renk1.R; } else { red = renk2.R; }
                    if (renk1.G > renk2.G) { green = renk1.G; } else { green = renk2.G; }
                    if (renk1.B > renk2.B) { blue = renk1.B; } else { blue = renk2.B; }

                    Color yeniRenk = Color.FromArgb(red, green, blue);
                    islem.SetPixel(x, y, yeniRenk);
                }
            }
            islemBox.Image = islem;
        }

        private void IntersectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;
            int red, green, blue = 0;
            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color renk1 = kaynak.GetPixel(x, y);
                    Color renk2 = kaynak2.GetPixel(x, y);
                    if (renk1.R < renk2.R) { red = renk1.R; } else { red = renk2.R; }
                    if (renk1.G < renk2.G) { green = renk1.G; } else { green = renk2.G; }
                    if (renk1.B < renk2.B) { blue = renk1.B; } else { blue = renk2.B; }

                    Color yeniRenk = Color.FromArgb(red, green, blue);
                    islem.SetPixel(x, y, yeniRenk);
                }
            }
            islemBox.Image = islem;
        }

        public ikiliFr()
        {
            InitializeComponent();
        }

        private void görüntüAçToolStripMenuItem_Click(object sender, EventArgs e)
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
