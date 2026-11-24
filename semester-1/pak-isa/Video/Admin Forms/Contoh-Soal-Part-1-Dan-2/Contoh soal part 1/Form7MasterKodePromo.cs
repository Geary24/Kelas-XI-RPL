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
    public partial class Form7MasterKodePromo : Form
    {
        BandaraEntities db = new BandaraEntities(); 
        private int idPromo = -1; 

        public Form7MasterKodePromo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3Dashboard dashboard = new Form3Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3Dashboard dashboard = new Form3Dashboard();
            this.Hide();
            dashboard.Show();
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

        private void Form7KodePromo_Load(object sender, EventArgs e)
        {
            dataGridPromo.AutoGenerateColumns = false;
            dataGridPromo.AllowUserToAddRows = false;
            dataGridPromo.ReadOnly = true;

            LoadData();
        }

        private void LoadData()
        {
            dataGridPromo.DataSource = db.KodePromoes.ToList();

        }

        private void ClearForm()
        {
            promoText.Clear();
            descriptionText.Clear();

            percentCount.Value = 0;
            maxCount.Value = 0;

            expirationDate.Value = DateTime.Today;

            idPromo = -1; 

            saveBtn.Text = "Simpan";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void promoText_TextChanged(object sender, EventArgs e)
        {
            promoText.Text = promoText.Text.ToUpper();
            promoText.SelectionStart = promoText.Text.Length;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (promoText.Text == "" || descriptionText.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi");
                return;
            }

            bool kodeSudahAda = db.KodePromoes.Any(p => p.Kode == promoText.Text && p.ID == idPromo);

            if (kodeSudahAda)
            {
                MessageBox.Show("Kode promo sudah digunakan");
                return;
            }

            if (percentCount.Value < 1 || maxCount.Value < 1)
            {
                MessageBox.Show("Input nilai tidak boleh kurang dari 1");
                return;
            }

            if (expirationDate.Value < DateTime.Today)
            {
                MessageBox.Show("Tanggal expired tidak boleh kurang dari hari ini");
                return;
            }

            if (idPromo == -1) 
            {
                KodePromo tambahPromo = new KodePromo();

                tambahPromo.Kode = promoText.Text;
                tambahPromo.BerlakuSampai = expirationDate.Value;
                tambahPromo.PersentaseDiskon = Convert.ToInt32(percentCount.Value);
                tambahPromo.MaksimumDiskon = Convert.ToInt32(maxCount.Value);
                tambahPromo.Deskripsi = descriptionText.Text;

                db.KodePromoes.Add(tambahPromo);
                db.SaveChanges();

                MessageBox.Show("Data berhasil disimpan");
            }
            else
            {
                KodePromo editPromo = db.KodePromoes.Find(idPromo);

                editPromo.Kode = promoText.Text;
                editPromo.BerlakuSampai = expirationDate.Value;
                editPromo.PersentaseDiskon = Convert.ToInt32(percentCount.Value);
                editPromo.MaksimumDiskon = Convert.ToInt32(maxCount.Value);
                editPromo.Deskripsi = descriptionText.Text;

                MessageBox.Show("Data berhasil diedit");
            }

            db.SaveChanges();

            LoadData();
            ClearForm();
        }

        private void dataGridPromo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dataGridPromo.Columns[e.ColumnIndex].Name == "edit")
            {
                idPromo = Convert.ToInt32(dataGridPromo.Rows[e.RowIndex].Cells["ID"].Value);

                KodePromo editPromo = db.KodePromoes.Find(idPromo);

                promoText.Text = editPromo.Kode;
                expirationDate.Value = editPromo.BerlakuSampai;
                percentCount.Value = Convert.ToInt32(editPromo.PersentaseDiskon);
                maxCount.Value = Convert.ToInt32(editPromo.MaksimumDiskon);
                descriptionText.Text = editPromo.Deskripsi;

                saveBtn.Text = "Update";
            }
            else if (dataGridPromo.Columns[e.ColumnIndex].Name == "hapus")
            {
                int idHapus = Convert.ToInt32(dataGridPromo.Rows[e.RowIndex].Cells["ID"].Value);

                var hasil = MessageBox.Show("Apakah anda yakin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    KodePromo hapusPromo = db.KodePromoes.Find(idHapus);

                    db.KodePromoes.Remove(hapusPromo);
                    db.SaveChanges();

                    MessageBox.Show("Data berhasil dihapus");

                    LoadData();
                    ClearForm();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
