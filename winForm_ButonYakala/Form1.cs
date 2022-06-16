using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winForm_ButonYakala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = btnTuruncu.Left;
            int y = btnTuruncu.Top;

            btnTuruncu.Left = 200;
            btnTuruncu.Top = 200;

        }

        private void btnYukari_Click(object sender, EventArgs e)
        {
            if (btnTuruncu.Top > 0)
            {
                btnTuruncu.Top -= 10;
            }
            else if (btnTuruncu.Top == 0)
            {
                MessageBox.Show("It can not go up any further.");
            }
        }
        
        private void btnAsagi_Click(object sender, EventArgs e)
        {            
            if (btnTuruncu.Bottom < ClientSize.Height)
            {
                btnTuruncu.Top += 10;
            }
            else if (btnTuruncu.Bottom >= ClientSize.Height)
            {
                MessageBox.Show("It can not go down any further.");
            }            
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            if (btnTuruncu.Left > 0)
            {
                btnTuruncu.Left -= 10;
            }
            else if (btnTuruncu.Left == 0)
            {
                MessageBox.Show("It can not go any further to the left.");
            }
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            if (btnTuruncu.Right < ClientSize.Width)
            {
                btnTuruncu.Left += 10;
            }
            else if (btnTuruncu.Right >= ClientSize.Width)
            {
                MessageBox.Show("It can not go any further to the right.");
            }
        }
    }
}
