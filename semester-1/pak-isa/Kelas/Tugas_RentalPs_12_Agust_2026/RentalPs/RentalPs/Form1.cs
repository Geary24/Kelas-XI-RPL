using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalPs
{
    public partial class Form1 : Form
    {
        int hasilRental;

        public Form1()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string playStation = comboBox1.Text.ToString();
            string jenisPaket = comboBox2.Text.ToString();

            int hargaPlayStation = 0;
            int hargaJenisPaket = 0;

            switch (playStation)
            {
                case "PS 3":
                    hargaPlayStation = 3000;
                    break;
                case "PS 4":
                    hargaPlayStation = 4000;
                    break;
                case "PS 5":
                    hargaPlayStation = 5000;
                    break;
                default:
                    break;
            }

            switch (jenisPaket)
            {
                case "Reguler":
                    hargaJenisPaket = 2000;
                    break;
                case "Express":
                    hargaJenisPaket = 3000;
                    break;
                case "Premium":
                    hargaJenisPaket = 5000;
                    break;
                default:
                    break;
            }

            int lamaRental = Convert.ToInt32(numericUpDown1.Value);
            hasilRental = (hargaPlayStation + hargaJenisPaket) * lamaRental;
            textBox4.Text = hasilRental.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int uangBayar = Convert.ToInt32(textBox6.Text);
            int kembalian = uangBayar - hasilRental;
            textBox5.Text = kembalian.ToString();
        }
    }
}
