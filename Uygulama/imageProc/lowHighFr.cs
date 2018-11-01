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
    public partial class lowHighFr : Form
    {
        Bitmap kaynak, islem;
        public lowHighFr()
        {
            InitializeComponent();
        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem = new Blur().Apply(kaynak);
            islemBox.Image = islem;
        }

        private void meanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem = new Mean().Apply(kaynak);
            islemBox.Image = islem;
        }

        private void medianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem = new Median().Apply(kaynak);
            islemBox.Image = islem;
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem = new Sharpen().Apply(kaynak);
            islemBox.Image = islem;
        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem = new GrayscaleBT709().Apply(kaynak);
            islem = new Edges().Apply(islem);
            islemBox.Image = islem;
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem = new GrayscaleBT709().Apply(kaynak);
            //islem = new Blur().Apply(islem);
            islem = new SobelEdgeDetector().Apply(islem);
            islemBox.Image = islem;
        }

        private void differenceEdgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem = new GrayscaleBT709().Apply(kaynak);
            islem = new DifferenceEdgeDetector().Apply(islem);
            islemBox.Image = islem;
        }

        private void homogenityEdgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            islem = new GrayscaleBT709().Apply(kaynak);
            islem = new HomogenityEdgeDetector().Apply(islem);
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
