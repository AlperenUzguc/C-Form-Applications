using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evdersi
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int k, m;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int kx, mx;
            kx = rnd.Next(1, 50);
            mx = rnd.Next(1, 50);
            pictureBox1.Left += kx;
            pictureBox2.Left += mx;

            if (pictureBox1.Left >= 700 && pictureBox1.Left > pictureBox2.Left)
            {   timer1.Stop();
                //MessageBox.Show("Kırmızı Kazandı")
                m++;
                button2.Text=m.ToString();
                pictureBox1.Left = 0;
                pictureBox2.Left = 0;
            }
            else if (pictureBox2.Left >=700 && pictureBox2.Left >pictureBox1.Left)
            {   timer1.Stop();
                //MessageBox.Show("Mavi Kazandı")
                k++;
                button3.Text = k.ToString();
                pictureBox1.Left = 0;
                pictureBox2.Left = 0;
            }
            else if (pictureBox1.Left >= 700 && pictureBox2.Left>=700 && pictureBox1.Left== pictureBox2.Left)
            { timer1.Stop();
            //MessageBox.Show("Berabere")
            }
            if (m == 5)
                MessageBox.Show("Mavi Kazandı");
            else if (k == 5)
                MessageBox.Show("Kırmızı Kazandı");
            else
                timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            timer1.Start();
            k = 0;
            m = 0;
            button2.Text = "";
            button3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
