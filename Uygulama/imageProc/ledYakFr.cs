using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace imageProc
{
    public partial class ledYakFr : Form
    {
        public ledYakFr()
        {
            InitializeComponent();
        }

        private void ledYakFr_Load(object sender, EventArgs e)
        {
            portCombo.DataSource = SerialPort.GetPortNames();
            toolStripLabel1.Text = "";
            portKes.Enabled = false;
            ledYak.Enabled = false;
            ledKapat.Enabled = false;

            int portSayisi = 0;
            portSayisi = portCombo.Items.Count;
            if (portSayisi < 1)
            {
                portBagla.Enabled = false;
                toolStripLabel1.Text = "Aygıt bulunamadı. Bağlantıyı kontrol et!!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 9600;
            serialPort1.PortName = portCombo.SelectedItem.ToString();
            serialPort1.Open();
            if (serialPort1.IsOpen == true)
            {
                toolStripLabel1.Text = serialPort1.PortName + " portuna bağlandı.";
                portKes.Enabled = true;
                ledYak.Enabled = true;
                ledKapat.Enabled = true;
                portBagla.Enabled = false;

            }
            else
            {
                toolStripLabel1.Text = "Porta bağlamadı. Kontrol et!!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
            toolStripLabel1.Text = "Led Yandı";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");
            toolStripLabel1.Text = "Led Kapandı";
        }

        private void portKes_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            toolStripLabel1.Text = "Bağlantı Kesildi";
            portKes.Enabled = false;
            ledYak.Enabled = false;
            ledKapat.Enabled = false;
            portBagla.Enabled = true;
        }
    }
}
