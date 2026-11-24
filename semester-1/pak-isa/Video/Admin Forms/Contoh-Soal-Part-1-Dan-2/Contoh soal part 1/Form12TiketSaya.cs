using Contoh_soal_part_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContohSoal
{
    public partial class Form12TiketSaya : Form
    {
        BandaraEntities db = new BandaraEntities();

        public Form12TiketSaya()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form9Customermain customerMain = new Form9Customermain();
            customerMain.Show();

            this.Hide();
        }

        private void Form12TiketSaya_Load(object sender, EventArgs e)
        {
            MuatDaftarTiket();
        }

        private void MuatDaftarTiket()
        {

            var daftarTiket = db.TransaksiHeaders

                .Where(t => t.AkunID == Session.loggedIn.ID)

                .Where(t => t.JadwalPenerbangan.TanggalWaktuKeberangkatan >= DateTime.Now)

                .Select(t => new
                {
                    KodePenerbangan = t.JadwalPenerbangan.KodePenerbangan,
                    Maskapai = t.JadwalPenerbangan.Maskapai.Nama,
                    BandaraKeberangkatan = t.JadwalPenerbangan.Bandara.Nama,
                    BandaraTujuan = t.JadwalPenerbangan.Bandara1.Nama,
                    TanggalKeberangkatan = t.JadwalPenerbangan.TanggalWaktuKeberangkatan,
                    WaktuPenerbangan = t.JadwalPenerbangan.TanggalWaktuKeberangkatan,
                    t.JadwalPenerbangan.DurasiPenerbangan,
                    JadwalPenerbanganID = t.JadwalPenerbangan.ID
                }).ToList();

            var dataTampil = daftarTiket
                .Select(t => new
                {
                    t.KodePenerbangan,
                    t.Maskapai,
                    t.BandaraKeberangkatan,
                    t.BandaraTujuan,
                    t.TanggalKeberangkatan,
                    WaktuPenerbangan = t.WaktuPenerbangan.ToString("HH:mm") + " - " + t.WaktuPenerbangan.AddMinutes(t.DurasiPenerbangan).ToString("HH:mm"),

                    StatusTerakhir = AmbilStatusTerakhir(t.JadwalPenerbanganID)
                }).ToList();

            dataGridTiket.DataSource = dataTampil;
        }

        private string AmbilStatusTerakhir(int IdJadwalPenerbangan)
        {
            var statusTerbaru = db.PerubahanStatusJadwalPenerbangans

                .Where(p => p.JadwalPenerbanganID == IdJadwalPenerbangan)

                .OrderByDescending(p => p.WaktuPerubahanTerjadi)

                .FirstOrDefault();

            if (statusTerbaru == null)
            {
                return "Sesuai jadwal";
            }

            string namaStatus = statusTerbaru.StatusPenerbangan.Nama;

            if (namaStatus == "Delay" && statusTerbaru.PerkiraanDurasiDelay != null)
            {

                int totalMenit = statusTerbaru.PerkiraanDurasiDelay.Value;

                int jam = totalMenit / 60;

                int menit = totalMenit % 60;

                return "Delay (kurang lebih)" + jam.ToString("00") + " Jam " + menit.ToString("00") + " Menit)";
            }

            return namaStatus;
        }
    }
}
