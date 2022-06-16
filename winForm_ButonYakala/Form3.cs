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
    public partial class Form3 : Form
    {
        int skor = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            btnBaslat.Visible = false;
            btnButon.Visible = true;
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer2.Enabled = true;
            timer2.Interval = 100;
        }
        private void btnButon_Click(object sender, EventArgs e)
        {
            buttonTik = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            btnButon.Visible = false;
            label4.Text = "3:00";
            label2.Text = "0";
            Random rnd = new Random();
            int n = rnd.Next(0, ClientSize.Width - btnButon.Width);
            btnButon.Left = n;
            n = rnd.Next(0, ClientSize.Height - btnButon.Width);
            btnButon.Top = n;
        }

        int saniye = 59;
        int dakika = 2;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label4.Text = dakika.ToString() + ":" + saniye.ToString();
            saniye--;
            if (dakika == 0 && saniye == -1)
            {
                label4.Text = "0:00";
                timer1.Enabled = false;
                timer2.Enabled = false;
                MessageBox.Show("Skorunuz: " + label2.Text);
                btnButon.Visible = false;
            }
            if (saniye == -1)
            {
                dakika--;
                saniye = 59;
            }
        }
        double turSaniye = 50;
        bool buttonTik = false;
        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            turSaniye--;
            if (skor < 100 && turSaniye > 0 && buttonTik == true)
            {
                skor += 10;
                label2.Text = skor.ToString();
                int n = rnd.Next(0, ClientSize.Width - btnButon.Width);
                btnButon.Left = n;
                n = rnd.Next(0, ClientSize.Height - btnButon.Width);
                btnButon.Top = n;
                turSaniye = 50;
                buttonTik = false;
            }
            else if (skor >= 100 && skor < 200 && turSaniye > 0 && buttonTik == true)
            {
                btnButon.Enabled = true;
                skor += 10;
                label2.Text = skor.ToString();
                int n = rnd.Next(0, ClientSize.Width - btnButon.Width);
                btnButon.Left = n;
                n = rnd.Next(0, ClientSize.Height - btnButon.Width);
                btnButon.Top = n;
                turSaniye = 30;
                buttonTik = false;
            }
            else if (skor >= 200 && skor < 300 && turSaniye > 0 && buttonTik == true)
            {
                btnButon.Enabled = true;
                skor += 10;
                label2.Text = skor.ToString();
                int n = rnd.Next(0, ClientSize.Width - btnButon.Width);
                btnButon.Left = n;
                n = rnd.Next(0, ClientSize.Height - btnButon.Width);
                btnButon.Top = n;
                turSaniye = 10;
                buttonTik = false;
            }
            else if (skor >= 300 && skor < 500 && turSaniye > 0 && buttonTik == true)
            {
                btnButon.Enabled = true;
                skor += 10;
                label2.Text = skor.ToString();
                int n = rnd.Next(0, ClientSize.Width - btnButon.Width);
                btnButon.Left = n;
                n = rnd.Next(0, ClientSize.Height - btnButon.Width);
                btnButon.Top = n;
                turSaniye = 5;
                buttonTik = false;
            }
            else if (skor >= 500 && turSaniye > 0 && buttonTik == true)
            {
                btnButon.Enabled = true;
                skor += 10;
                label2.Text = skor.ToString();
                int n = rnd.Next(0, ClientSize.Width - btnButon.Width);
                btnButon.Left = n;
                n = rnd.Next(0, ClientSize.Height - btnButon.Width);
                btnButon.Top = n;
                turSaniye = 2;
                buttonTik = false;
            }
            else if (turSaniye <= 0 && skor < 100)
            {
                int n = rnd.Next(0, ClientSize.Width - btnButon.Width);
                btnButon.Left = n;
                n = rnd.Next(0, ClientSize.Height - btnButon.Width);
                btnButon.Top = n;
                turSaniye = 50;
            }
            else if (turSaniye <= 0 && skor >= 100 && skor < 200)
            {
                int n = rnd.Next(0, ClientSize.Width - btnButon.Width);
                btnButon.Left = n;
                n = rnd.Next(0, ClientSize.Height - btnButon.Width);
                btnButon.Top = n;
                turSaniye = 30;
            }
            else if (turSaniye <= 0 && skor >= 200 && skor < 300)
            {
                int n = rnd.Next(0, ClientSize.Width - btnButon.Width);
                btnButon.Left = n;
                n = rnd.Next(0, ClientSize.Height - btnButon.Width);
                btnButon.Top = n;
                turSaniye = 10;
            }
            else if (turSaniye <= 0 && skor >= 300 && skor < 500)
            {
                int n = rnd.Next(0, ClientSize.Width - btnButon.Width);
                btnButon.Left = n;
                n = rnd.Next(0, ClientSize.Height - btnButon.Width);
                btnButon.Top = n;
                turSaniye = 5;
            }
            else if (turSaniye <= 0 && skor >= 500)
            {
                int n = rnd.Next(0, ClientSize.Width - btnButon.Width);
                btnButon.Left = n;
                n = rnd.Next(0, ClientSize.Height - btnButon.Width);
                btnButon.Top = n;
                turSaniye = 2;
            }
        }
    }
}
