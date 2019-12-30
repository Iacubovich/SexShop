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
        private int a;
        private int b;
        private string c = "Недостаточное количество";
        private int q;
        private int w = 76;
        private int t = 38;
        private int f;
        private int r;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            if ((a > 76) || (b > 38))
            {
                textBox3.Text = c;
            }
            else
            {
                q = ((a * 570) + (b * 800));
                textBox3.Text = Convert.ToString(q);
                f = w - a;
                r = t - b;
                label4.Text = Convert.ToString(f);
                label5.Text = Convert.ToString(r);

            }

        }
    }
}
