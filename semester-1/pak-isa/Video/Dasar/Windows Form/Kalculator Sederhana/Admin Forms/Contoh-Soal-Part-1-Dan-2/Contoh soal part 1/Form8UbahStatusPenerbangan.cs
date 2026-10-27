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
    public partial class Form8UbahStatusPenerbangan : Form
    {
        public Form8UbahStatusPenerbangan()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3Dashboard dashboard = new Form3Dashboard();
            this.Close();
            dashboard.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Close();
            this.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Close();
            this.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form8UbahStatusPenerbangan Status = new Form8UbahStatusPenerbangan();
            this.Close();
            Status.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form5MasterMaskapai Maskapai = new Form5MasterMaskapai();
            this.Close();
            Maskapai.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5MasterMaskapai Maskapai = new Form5MasterMaskapai();
            this.Close();
            Maskapai.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form6MasterJadwalPenerbangan Jadwal = new Form6MasterJadwalPenerbangan();
            this.Close();
            Jadwal.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form6MasterJadwalPenerbangan Jadwal = new Form6MasterJadwalPenerbangan();
            this.Close();
            Jadwal.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form7MasterKodePromo Promo = new Form7MasterKodePromo();
            this.Close();
            Promo.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form7MasterKodePromo Promo = new Form7MasterKodePromo();
            this.Close();
            Promo.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form8UbahStatusPenerbangan Status = new Form8UbahStatusPenerbangan();
            this.Close();
            Status.Show();
        }

        private void Form3Dasboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4MasterBandara Bandara = new Form4MasterBandara();
            this.Close();
            Bandara.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form4MasterBandara Bandara = new Form4MasterBandara();
            this.Close();
            Bandara.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3Dashboard dashboard = new Form3Dashboard();
            this.Close();
            dashboard.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Close();
            login.Show();
        }
    }
}
