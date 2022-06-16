using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winForm_ButonYakala
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEvet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We lived happily ever after.");
        }

        private void btnHayir_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = rnd.Next(0, ClientSize.Width-btnHayir.Width);
            btnHayir.Left = n;
            n = rnd.Next(0, ClientSize.Height - btnHayir.Width);
            btnHayir.Top = n;
        }

        private void btnHayir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("After this effort I am breaking up with you.");
        }
    }
}
