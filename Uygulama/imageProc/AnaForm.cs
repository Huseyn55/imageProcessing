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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void renkGetirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenkAlFr renkFormu = new RenkAlFr();
            renkFormu.ShowDialog();
        }

        private void griDönüşümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GriYontemleriFr griFormu = new GriYontemleriFr();
            griFormu.ShowDialog();
        }

        private void kanalSıralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KanalSiralaFr kanalFormu = new KanalSiralaFr();
            kanalFormu.ShowDialog();
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramFr histogramFormu = new HistogramFr();
            histogramFormu.ShowDialog();
        }

        private void ınvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFr invertFormu = new InvertFr();
            invertFormu.ShowDialog();
        }

        private void parlaklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParlaklikFr parlaklikFormu = new ParlaklikFr();
            parlaklikFormu.ShowDialog();
        }
    }
}
