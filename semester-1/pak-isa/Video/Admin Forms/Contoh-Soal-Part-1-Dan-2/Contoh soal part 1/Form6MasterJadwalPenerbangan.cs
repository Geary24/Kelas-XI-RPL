using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contoh_soal_part_1
{
    public partial class Form6MasterJadwalPenerbangan : Form
    {
        BandaraEntities db = new BandaraEntities();
        private int idJadwal = -1; 

        public Form6MasterJadwalPenerbangan()
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

        private void Form6JadwalPenerbangan_Load(object sender, EventArgs e)
        {
            dataGridJadwal.AutoGenerateColumns = false;
            dataGridJadwal.AllowUserToAddRows = false;
            dataGridJadwal.ReadOnly = true;

            departureTime.Format = DateTimePickerFormat.Custom;
            departureTime.CustomFormat = "HH:mm";
            departureTime.ShowUpDown = true;

            LoadBandara();
            LoadMaskapai();
            LoadJadwal();
        }

        private void LoadBandara()
        {

            departureBox.DataSource = db.Bandaras.OrderBy(b => b.Nama).ToList();
            departureBox.DisplayMember = "Nama";
            departureBox.ValueMember = "ID";
            departureBox.SelectedIndex = -1;

            destinationBox.DataSource = db.Bandaras.OrderBy(b => b.Nama).ToList();
            destinationBox.DisplayMember = "Nama";
            destinationBox.ValueMember = "ID";
            destinationBox.SelectedIndex = -1;
        }

        private void LoadMaskapai()
        {
            maskapaiBox.DataSource = db.Maskapais.OrderBy(b => b.Nama).ToList();
            maskapaiBox.DisplayMember = "Nama";
            maskapaiBox.ValueMember = "ID";
            maskapaiBox.SelectedIndex = -1;
        }

        private void LoadJadwal()
        {

            dataGridJadwal.DataSource = db.JadwalPenerbangans
                                        .OrderByDescending(j => j.TanggalWaktuKeberangkatan)
                                        .ToList()
                                        .Select(j => new
                                        {
                                            j.ID,
                                            j.KodePenerbangan,
                                            BandaraAsal = j.Bandara.Nama,
                                            BandaraTujuan = j.Bandara1.Nama,
                                            Maskapai = j.Maskapai.Nama,
                                            TanggalKeberangkatan = j.TanggalWaktuKeberangkatan.ToString("dd/MM/yy"),
                                            WaktuKeberangkatan = j.TanggalWaktuKeberangkatan.ToString("HH:mm"),
                                            DurasiPenerbangan = (j.DurasiPenerbangan / 60) + " Jam " + (j.DurasiPenerbangan % 60) + " Menit ",
                                            j.HargaPerTiket
                                        }).ToList();
        }

        private void ClearForm()
        {
            codeText.Clear();
            durationText.Text = "__ Jam __ Menit";

            departureBox.SelectedIndex = -1;
            destinationBox.SelectedIndex = -1;
            maskapaiBox.SelectedIndex = -1;

            departureDate.Value = DateTime.Now;
            departureTime.Value = DateTime.Now;

            priceCount.Value = 0;

            idJadwal = -1;

            saveBtn.Text = "Simpan";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (codeText.Text == "" || durationText.Text == "" || departureBox.SelectedIndex == -1 || destinationBox.SelectedIndex == -1 || maskapaiBox.SelectedIndex == -1)
            {
                MessageBox.Show("Semua data harus diisi!");
                return;
            }

            if (codeText.Text.Length != 7)
            {
                MessageBox.Show("Format kode: AA-0000");
                return;
            }

            if (!char.IsLetter(codeText.Text[0]) || !char.IsLetter(codeText.Text[1]))
            {
                MessageBox.Show("2 karakter pertama harus berupa huruf");
                return;
            }

            if (codeText.Text[2] != '-')
            {
                MessageBox.Show("Kode harus mengandung '-'");
                return;
            }

            if (!char.IsDigit(codeText.Text[3]) || !char.IsDigit(codeText.Text[4]) || !char.IsDigit(codeText.Text[5]) || !char.IsDigit(codeText.Text[6]))
            {
                MessageBox.Show("4 karakter terakhir harus berupa angka");
                return;
            }

            if (departureBox.SelectedValue.Equals(destinationBox.SelectedValue))
            {
                MessageBox.Show("Bandara asal dan tujuan tidak boleh sama!");
                return;
            }

            string[] durasi = durationText.Text.Split(' '); 

            if (durasi.Length != 4)
            {
                MessageBox.Show("Format durasi : xx Jam xx Menit");
                return;
            }

            if (durasi[1] != "Jam" || durasi[3] != "Menit")
            {
                MessageBox.Show("Format durasi : xx Jam xx Menit");
                return;
            }

            if (!durasi[0].All(char.IsDigit) || !durasi[2].All(char.IsDigit))
            {
                MessageBox.Show("Jam dan Menit harus berupa Angka");
                return;
            }

            int jam = Convert.ToInt32(durasi[0]);
            int menit = Convert.ToInt32(durasi[2]);

            int totalMenit = (jam * 60) + menit;

            if (priceCount.Value < 1)
            {
                MessageBox.Show("Harga tidak valid");
                return;
            }

            if (departureDate.Value < DateTime.Today)
            {
                MessageBox.Show("Tanggal keberangkatan tidak boleh hari kemarin");
                return;
            }

            MessageBox.Show("Data berhasil ditambahkan");

            if (idJadwal == -1) 
            {
                JadwalPenerbangan jadwalBaru = new JadwalPenerbangan();
                PerubahanStatusJadwalPenerbangan statusJadwal = new PerubahanStatusJadwalPenerbangan();

                jadwalBaru.KodePenerbangan = codeText.Text;
                jadwalBaru.BandaraKeberangkatanID = Convert.ToInt32(departureBox.SelectedValue);
                jadwalBaru.BandaraTujuanID = Convert.ToInt32(destinationBox.SelectedValue);
                jadwalBaru.MaskapaiID = Convert.ToInt32(maskapaiBox.SelectedValue);
                jadwalBaru.TanggalWaktuKeberangkatan = departureDate.Value.Date + departureTime.Value.TimeOfDay;
                jadwalBaru.DurasiPenerbangan = totalMenit; 
                jadwalBaru.HargaPerTiket = Convert.ToInt32(priceCount.Value);

                db.JadwalPenerbangans.Add(jadwalBaru);
                db.SaveChanges();

                statusJadwal.JadwalPenerbanganID = jadwalBaru.ID;
                statusJadwal.StatusPenerbanganID = 1;
                statusJadwal.WaktuPerubahanTerjadi = DateTime.Now;
                statusJadwal.PerkiraanDurasiDelay = null;

                db.PerubahanStatusJadwalPenerbangans.Add(statusJadwal);
                MessageBox.Show("Jadwal berhasil dibuat");
            }
            else
            {
                JadwalPenerbangan editJadwal = db.JadwalPenerbangans.Find(idJadwal);

                editJadwal.KodePenerbangan = codeText.Text;
                editJadwal.BandaraKeberangkatanID = Convert.ToInt32(departureBox.SelectedValue);
                editJadwal.BandaraTujuanID = Convert.ToInt32(destinationBox.SelectedValue);
                editJadwal.MaskapaiID = Convert.ToInt32(maskapaiBox.SelectedValue);
                editJadwal.TanggalWaktuKeberangkatan = departureDate.Value.Date + departureTime.Value.TimeOfDay;
                editJadwal.DurasiPenerbangan = totalMenit; 
                editJadwal.HargaPerTiket = Convert.ToInt32(priceCount.Value);

                MessageBox.Show("Jadwal berhasil diubah");
            }

            db.SaveChanges();
            ClearForm();
            LoadJadwal();
        }

        private void dataGridJadwal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dataGridJadwal.Columns[e.ColumnIndex].Name == "edit")
            {

                idJadwal = Convert.ToInt32(dataGridJadwal.Rows[e.RowIndex].Cells["ID"].Value);

                JadwalPenerbangan editJadwal = db.JadwalPenerbangans.Find(idJadwal);

                int jam = editJadwal.DurasiPenerbangan / 60;
                int menit = editJadwal.DurasiPenerbangan % 60;

                string menitKeDurasi = jam + " Jam " + menit + " Menit";

                codeText.Text = editJadwal.KodePenerbangan;
                departureBox.SelectedValue = editJadwal.BandaraKeberangkatanID;
                destinationBox.SelectedValue = editJadwal.BandaraTujuanID;
                maskapaiBox.SelectedValue = editJadwal.MaskapaiID;
                departureDate.Value = editJadwal.TanggalWaktuKeberangkatan;
                departureTime.Value = editJadwal.TanggalWaktuKeberangkatan;
                durationText.Text = menitKeDurasi; 
                priceCount.Value = Convert.ToInt32(editJadwal.HargaPerTiket);

                saveBtn.Text = "Update";
            }
            else if (dataGridJadwal.Columns[e.ColumnIndex].Name == "hapus")
            {
                int id = Convert.ToInt32(dataGridJadwal.Rows[e.RowIndex].Cells["ID"].Value);

                var hasil = MessageBox.Show("Apakah anda yakin menghapus jadwal ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    var hapusJadwal = db.JadwalPenerbangans.Find(id);

                    db.JadwalPenerbangans.Remove(hapusJadwal);
                    db.SaveChanges();

                    LoadJadwal();
                    ClearForm();

                    MessageBox.Show("Data berhasil dihapus");
                }
            }
        }
    }
}
