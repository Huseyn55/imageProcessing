using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging;
using AForge.Imaging.Filters;

namespace imageProc
{
    public partial class segmenteFr : Form
    {
        Bitmap kaynak, islem;
        public segmenteFr()
        {
            InitializeComponent();
        }

        private void hücreSayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem = new ExtractNormalizedRGBChannel(RGB.G).Apply(kaynak);
            islem = new OtsuThreshold().Apply(islem);
            islem = new Invert().Apply(islem);
            islem = new Opening().Apply(islem);

            BlobCounter bc = new BlobCounter();
            bc.FilterBlobs = false;
            bc.MinHeight = 5;
            bc.MinWidth = 5;
            bc.ProcessImage(islem);
            Rectangle[] rects = bc.GetObjectsRectangles();
            listBox1.Items.Add(rects.Length + " tane hücre var");

            Bitmap cizim = new Bitmap(islem.Width, islem.Height);
            Graphics g = Graphics.FromImage(cizim);
            g.DrawImage(islem, 0, 0);
            Pen cerceve = new Pen(Color.Red,2);
            foreach(Rectangle rect in rects)
            {
                listBox1.Items.Add(rect.Location + " " + rect.Size);
                g.DrawRectangle(cerceve, rect);
            }
            g.Dispose();
            kaynakBox.Image = cizim;
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
