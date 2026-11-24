using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contoh_soal_part_1
{
    public partial class Form3Dashboard : Form
    {
        public Form3Dashboard()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form4MasterBandara bandara = new Form4MasterBandara();
            this.Hide();
            bandara.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4MasterBandara bandara = new Form4MasterBandara();
            this.Hide();
            bandara.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form5MasterMaskapai maskapai = new Form5MasterMaskapai();
            this.Hide();
            maskapai.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5MasterMaskapai maskapai = new Form5MasterMaskapai();
            this.Hide();
            maskapai.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form6MasterJadwalPenerbangan jadwalPenerbangan = new Form6MasterJadwalPenerbangan();
            this.Hide();
            jadwalPenerbangan.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form6MasterJadwalPenerbangan jadwalPenerbangan = new Form6MasterJadwalPenerbangan();
            this.Hide();
            jadwalPenerbangan.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form7MasterKodePromo kodePromo = new Form7MasterKodePromo();
            this.Hide();
            kodePromo.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form7MasterKodePromo kodePromo = new Form7MasterKodePromo();
            this.Hide();
            kodePromo.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form8UbahStatusPenerbangan ubahStatusPenerbangan = new Form8UbahStatusPenerbangan();
            this.Hide();
            ubahStatusPenerbangan.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form8UbahStatusPenerbangan ubahStatusPenerbangan = new Form8UbahStatusPenerbangan();
            this.Hide();
            ubahStatusPenerbangan.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Hide();
            login.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Hide();
            login.Show();
        }
    }
}
