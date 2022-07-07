using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Кирпич
{
    public partial class Form1 : Form
    {
        int i;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Простая игра в догони меня кирпич
            Random rnd = new Random();
            int opa = rnd.Next(1, 3);
            if (opa == 1)
            {
                MessageBox.Show("О повезло повезло");
                button3.Visible = true;
            }
            else
            {
                MessageBox.Show("О не повезло не повезло");
                Random rnd1 = new Random();
                button2.Location = new Point(rnd1.Next(100, 500), rnd1.Next(100, 700));
                label1.Visible = true;
                i = 3;
                label1.Text = i.ToString();
                timer1.Interval = 1000;
                timer1.Enabled = true;
                button2.Visible = true;
            }
            button1.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("А ты хорош");
            label1.Visible = false;
            button2.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd2 = new Random();
            int na = rnd2.Next(1, 8);
            if (na == 1 || na == 3 || na == 7)
                MessageBox.Show("Есть пробитие");
            else
                MessageBox.Show("Не пробил");
            button3.Visible = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
           button1.Visible = true;
           button2.Visible = false;
           button2.Location = new Point(464, 214);
           button3.Visible = false;
           i = 3;
           label1.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = (--i).ToString();
            if (i == 0)
            {
                timer1.Stop();
                MessageBox.Show("Прилетел кирпич");
            }
        }
    }
}