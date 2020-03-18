using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int x, n;
        public Form1()
        {
           

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int y;
            y = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            n++;
            if (radioButton1.Checked) 
            {
                if (y == x)
                { listBox1.Items.Add("Tebrikler " + n.ToString() + " .denemede bildiniz");
                    if (n < 4)
                    { listBox1.Items.Add("Süpersiniz"); }
                }
                else if (x < y)
                    listBox1.Items.Add(y.ToString() + " sayısından daha KÜÇÜK bir sayı giriniz");
                else
                    listBox1.Items.Add(y.ToString() + " sayısından daha BÜYÜK bir sayı giriniz");
            }
            else if (radioButton2.Checked) 
            {
                if (y == x)
                { listBox1.Items.Add("Tebrikler" + n.ToString() + ".denemede bildiniz");
                    if (n < 4)
                    { listBox1.Items.Add("Süpersiniz"); }
                }
                else if (Math.Abs(y - x) < 3)
                    listBox1.Items.Add(y.ToString() + " Çok sıcak");
                else if (Math.Abs(y - x) < 6)
                    listBox1.Items.Add(y.ToString() + " Sıcak");
                else if (Math.Abs(y - x) < 10)
                    listBox1.Items.Add(y.ToString() + " Ilık");
                else if (Math.Abs(y - x) < 20)
                    listBox1.Items.Add(y.ToString() + " Serin");
                else if (Math.Abs(y - x) < 30)
                    listBox1.Items.Add(y.ToString() + " Soğuk");
                else
                    listBox1.Items.Add(y.ToString() + " Çok Soğuk");
            }
            
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            x = rnd.Next(1, 100);
            listBox1.Items.Clear();
            n = 0;
        }
    }
}
