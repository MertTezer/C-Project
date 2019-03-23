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
    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("1.SOL BÖLÜM");
            comboBox1.Items.Add("2.ORTA BÖLÜM");
            comboBox1.Items.Add("3.SAĞ BÖLÜM");

            comboBox3.Items.Add("İstanbul");
            comboBox3.Items.Add("Ankara");
            comboBox3.Items.Add("Bursa");
            comboBox3.Items.Add("İzmir");
            comboBox3.Items.Add("Adana");
            comboBox3.Items.Add("Trabzon");
            comboBox3.Items.Add("Diyarbakır");

            comboBox4.Items.Add("İstanbul");
            comboBox4.Items.Add("Ankara");
            comboBox4.Items.Add("Bursa");
            comboBox4.Items.Add("İzmir");
            comboBox4.Items.Add("Adana");
            comboBox4.Items.Add("Trabzon");
            comboBox4.Items.Add("Diyarbakır");
        }

        public static string gonder, gonder1, gonder2, gonder3, gonder4, gonder5, gonder6, gonder7, gonder8, gonder9;

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, surname, tc, phone, email;

            name = Convert.ToString(textBox1.Text);
            surname = Convert.ToString(textBox2.Text);
            tc = Convert.ToString(textBox3.Text);
            phone = Convert.ToString(textBox4.Text);
            email = Convert.ToString(textBox5.Text);

            gonder = textBox1.Text;
            gonder1 = textBox2.Text;
            gonder2 = textBox3.Text;
            gonder3 = textBox4.Text;
            gonder4 = textBox5.Text;
            gonder5 = comboBox3.Text;
            gonder6 = comboBox4.Text;
            gonder8 = comboBox1.Text;
            gonder9 = comboBox2.Text;

            if (checkBox1.Enabled == true )
            {
                gonder7 = checkBox1.Text;
            }
            else
            {
                gonder7 = checkBox2.Text;
            }

           
            
            Form form3 = new Form3();
            form3.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Add("A7");
                comboBox2.Items.Add("A8");
                comboBox2.Items.Add("A9");
                comboBox2.Items.Add("B7");
                comboBox2.Items.Add("B8");
                comboBox2.Items.Add("B9");
                comboBox2.Items.Add("C7");
                comboBox2.Items.Add("C8");
                comboBox2.Items.Add("C9");
                comboBox2.Items.Add("D7");
                comboBox2.Items.Add("D8");
                comboBox2.Items.Add("D9");
                comboBox2.Items.Clear();
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("A4");
                comboBox2.Items.Add("A5");
                comboBox2.Items.Add("A6");
                comboBox2.Items.Add("B4");
                comboBox2.Items.Add("B5");
                comboBox2.Items.Add("B6");
                comboBox2.Items.Add("C4");
                comboBox2.Items.Add("C5");
                comboBox2.Items.Add("C6");
                comboBox2.Items.Add("D4");
                comboBox2.Items.Add("D5");
                comboBox2.Items.Add("D6");
            }

            else if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("A1");
                comboBox2.Items.Add("A2");
                comboBox2.Items.Add("A3");
                comboBox2.Items.Add("B1");
                comboBox2.Items.Add("B2");
                comboBox2.Items.Add("B3");
                comboBox2.Items.Add("C1");
                comboBox2.Items.Add("C2");
                comboBox2.Items.Add("C3");
                comboBox2.Items.Add("D1");
                comboBox2.Items.Add("D2");
                comboBox2.Items.Add("D3");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
