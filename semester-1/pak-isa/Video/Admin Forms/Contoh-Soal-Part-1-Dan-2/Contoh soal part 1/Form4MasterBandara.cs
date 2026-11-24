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
    public partial class Form4MasterBandara : Form
    {
        BandaraEntities db = new BandaraEntities(); 
        private int idBandara = -1; 

        private void Form4Bandara_Load(object sender, EventArgs e)
        {
            LoadNegara(); 
            LoadBandara(); 

            dataGridBandara.AutoGenerateColumns = false;
            dataGridBandara.AllowUserToAddRows = false;
            dataGridBandara.ReadOnly = true;
        }

        private void LoadNegara()
        {
            countryBox.DataSource = db.Negaras.OrderBy(n => n.Nama).ToList();
            countryBox.DisplayMember = "Nama";
            countryBox.ValueMember = "ID";
            countryBox.SelectedIndex = -1;
        }

        private void LoadBandara()
        {
            dataGridBandara.DataSource = db.Bandaras.Include("Negara") 
            .OrderBy(b => b.Nama) 
            .Select(b => new 
            {
                b.ID,
                b.Nama,
                b.KodeIATA,
                b.Kota,
                Negara = b.Negara.Nama,
                b.JumlahTerminal,
                b.Alamat,
            }).ToList();
        }

        private void ResetForm()
        {
            nameTxt.Clear();
            iataTxt.Clear();
            cityTxt.Clear();
            addressTxt.Clear();
            countryBox.SelectedIndex = -1;
            terminalCount.Value = 1;
            idBandara = -1; 
            saveBtn.Text = "Simpan";
        }

        public Form4MasterBandara()
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "" || iataTxt.Text == "" ||
            cityTxt.Text == "" || addressTxt.Text == "" || countryBox.SelectedIndex == -1)
            {
                MessageBox.Show("Semua data harus diisi!");
                return;
            }

            if (iataTxt.Text.Length != 3)
            {
                MessageBox.Show("Kode IATA wajib memiliki 3 huruf!");
                return;
            }

            if (!iataTxt.Text.All(char.IsLetter)) 
            {
                MessageBox.Show("Kode IATA hanya boleh huruf!");
                return;
            }

            bool adaIATA = db.Bandaras.Any(b => b.KodeIATA == iataTxt.Text
            && b.ID != idBandara);

            if (adaIATA)
            {
                MessageBox.Show("Kode IATA sudah digunakan!");
                return;
            }

            if (terminalCount.Value < 1)
            {
                MessageBox.Show("Jumlah terminal minimal 1");
                return;
            }

            bool adaBandara = db.Bandaras.Any(b => b.Nama.ToLower() == nameTxt.Text.ToLower()
            && b.ID != idBandara);

            if (adaBandara)
            {
                MessageBox.Show("Nama bandara sudah dipakai!");
                return;
            }

            if (idBandara == -1) 
            {

                Bandara bandara = new Bandara();
                bandara.Nama = nameTxt.Text;
                bandara.KodeIATA = iataTxt.Text;
                bandara.Kota = cityTxt.Text;
                bandara.NegaraID = Convert.ToInt32(countryBox.SelectedValue);
                bandara.JumlahTerminal = Convert.ToInt32(terminalCount.Value);
                bandara.Alamat = addressTxt.Text;

                db.Bandaras.Add(bandara);
                MessageBox.Show("Data berhasil ditambahkan!");
            }
            else 
            {
                Bandara editBandara = db.Bandaras.Find(idBandara);
                editBandara.Nama = nameTxt.Text;
                editBandara.KodeIATA = iataTxt.Text;
                editBandara.Kota = cityTxt.Text;
                editBandara.NegaraID = Convert.ToInt32(countryBox.SelectedValue);
                editBandara.JumlahTerminal = Convert.ToInt32(terminalCount.Value);
                editBandara.Alamat = addressTxt.Text;

                MessageBox.Show("Data berhasil diedit!");
            }

            db.SaveChanges();

            LoadBandara();
            ResetForm();
        }

        private void dataGridBandara_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) 

            {
                return;
            }

            if (dataGridBandara.Columns[e.ColumnIndex].Name == "edit")
            {

                idBandara = Convert.ToInt32(dataGridBandara.Rows[e.RowIndex].Cells["ID"].Value);

                Bandara bandaraEdit = db.Bandaras.Find(idBandara);

                nameTxt.Text = bandaraEdit.Nama;
                iataTxt.Text = bandaraEdit.KodeIATA;
                cityTxt.Text = bandaraEdit.Kota;
                addressTxt.Text = bandaraEdit.Alamat;

                countryBox.SelectedValue = bandaraEdit.NegaraID;

                terminalCount.Value = bandaraEdit.JumlahTerminal;

                saveBtn.Text = "Update";
            }
            else if (dataGridBandara.Columns[e.ColumnIndex].Name == "hapus")
            {
                int id = Convert.ToInt32(dataGridBandara.Rows[e.RowIndex].Cells["ID"].Value);
                var hasil = MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Bandara bandaraHapus = db.Bandaras.Find(id);
                    db.Bandaras.Remove(bandaraHapus);
                    db.SaveChanges();

                    LoadBandara();
                    ResetForm();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
