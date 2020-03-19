using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaYarisi
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Left = 0;
            button3.Left = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int k, m;
            k = rnd.Next(1, 30);
            m = rnd.Next(1, 30);
            button2.Left += k;
            button3.Left += m;
            button4.Width = k * 20;
            button5.Width = m * 20;
            listBox1.Items.Add("Anlık Hız K= " + (k).ToString() + "m/s  M= " + (m).ToString() + "m/s");
            if (button2.Left >= 800 && button2.Left > button3.Left)
            {
                timer1.Stop();
                MessageBox.Show("Kırmızı Kazandı");
            }
            else if (button3.Left >= 800 && button3.Left > button2.Left)
            {
                timer1.Stop();
                MessageBox.Show("Mavi Kazandı");
            }
            if (button2.Left >= 800 && button3.Left > 800)
            {
                timer1.Stop();
                MessageBox.Show("Berabere");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
