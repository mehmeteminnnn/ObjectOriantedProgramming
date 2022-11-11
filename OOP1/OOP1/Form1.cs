using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otomobil oto=new Otomobil();
            oto.marka = "Ford";
            oto.model = "Focus";
            oto.modelyılı = 2015;
            oto.renk = "Beyaz";
            oto.vitestipi = "Manuel";
            string marka = oto.markagetir();
            label6.Text=oto.marka.ToString();
            label7.Text=oto.model.ToString();
            label8.Text = oto.modelyılı.ToString();
            label9.Text = oto.renk.ToString();
            label10.Text = oto.vitestipi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
