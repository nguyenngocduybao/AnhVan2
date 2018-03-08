using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV2
{
    public partial class Question7 : Form
    {
        public Question7()
        {
            InitializeComponent();
        }

        private void true1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulation!");
        }

        private void btn_Return_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void false1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your answer's wrong. \n Better luck next time!!!");
        }

        private void false2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your answer's wrong. \n Better luck next time!!!");

        }

        private void false3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your answer's wrong. \n Better luck next time!!!");

        }
    }
}
