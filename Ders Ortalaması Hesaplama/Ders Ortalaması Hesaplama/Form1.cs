using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_Ortalaması_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double not1, not2, sozlu1, sozlu2, ortalama;
            not1 = Convert.ToDouble(textBox1.Text);
            not2 = Convert.ToDouble(textBox2.Text);
            sozlu1 = Convert.ToDouble(textBox3.Text);
            sozlu2 = Convert.ToDouble(textBox4.Text);
            ortalama = (not1 + not2 + sozlu1 + sozlu2) / 4;
            textBox5.Text = ortalama.ToString();
            if (ortalama >= 50)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/user/Desktop/10-M/Ders Ortalaması Hesaplama/tik.png");
                MessageBox.Show("Matematik Dersini Geçtiniz");

            }
            else 
            {
                pictureBox1.Image = Image.FromFile("C:/Users/user/Desktop/10-M/Ders Ortalaması Hesaplama/false.png");
                MessageBox.Show("Dersten Kaldınız,Telafi Sınavına Bekleriz");
            }


        }
    }
}
