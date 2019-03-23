using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            label1.Text = Form1.gonder;
            label2.Text = Form1.gonder1;
            label3.Text = Form1.gonder2;
            label4.Text = Form1.gonder3;
            label5.Text = Form1.gonder4;

            label8.Text = Form1.gonder5;
            label9.Text = Form1.gonder6;
            label10.Text = Form1.gonder7;
            label11.Text = Form1.gonder8;
            label12.Text = Form1.gonder9;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgileriniz Doğru Mu ?", "EagleEye Airlines", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }
    }
}
