using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AV2
{
    public partial class AV2 : Form
    {
        public AV2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "important";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = "a lot";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Text = "throughout";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Text = "opens";
        }

        private void label12_Click(object sender, EventArgs e)
        {
            label12.Text = "run";
        }

        private void label14_Click(object sender, EventArgs e)
        {
            label14.Text = "equality";
        }

        private void label18_Click(object sender, EventArgs e)
        {
            label18.Text = "plays";
        }

        private void label20_Click(object sender, EventArgs e)
        {
            label20.Text = "enhance";
        }

        private void label23_Click(object sender, EventArgs e)
        {
            label23.Text = "through";
        }

        private void label26_Click(object sender, EventArgs e)
        {
            label26.Text = "costly";
        }

        private void label29_Click(object sender, EventArgs e)
        {
            label29.Text = "fewer";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Question1 dlg2 = new Question1();
            dlg2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Question2 dlg2 = new Question2();
            dlg2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Question3 dlg2 = new Question3();
            dlg2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Question4 dlg2 = new Question4();
            dlg2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Question5 dlg2 = new Question5();
            dlg2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Question6 dlg2 = new Question6();
            dlg2.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Question7 dlg2 = new Question7();
            dlg2.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Lucky dlg2 = new Lucky();
            dlg2.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Question8 dlg2 = new Question8();
            dlg2.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Question9 dlg2 = new Question9();
            dlg2.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Question10 dlg2 = new Question10();
            dlg2.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Question11 dlg2 = new Question11();
            dlg2.ShowDialog();
        }        
    }
}
