using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contoh_soal_part_1;

namespace ContohSoal
{
    public partial class Form11BeliTiket : Form
    {
        private Form10ListPenerbangan formSebelumnya;
        private Form9Customermain formCustomerMain;
        private int jadwalID;
        private int jumlahPenumpang;

        private List<PenumpangControl> daftarKartuPenumpang = new List<PenumpangControl>();

        private BandaraEntities db = new BandaraEntities();
        private JadwalPenerbangan jadwal;

        private double totalDiskon;
        private double totalPembayaranAkhir;
        private int? kodePromoID = null;

        private bool transaksiBerhasil;

        public Form11BeliTiket(Form10ListPenerbangan formSebelumnya, Form9Customermain formCustomerMain, int jadwalID, int jumlahPenumpang)
        {
            InitializeComponent();

            this.formSebelumnya = formSebelumnya;
            this.formCustomerMain = formCustomerMain;
            this.jadwalID = jadwalID;
            this.jumlahPenumpang = jumlahPenumpang;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSebelumnya.Show();
        }

        private void Form11BeliTiket_Load(object sender, EventArgs e)
        {
            if (!ValidatePenerbangan()) 
            {
                Close(); 
                return;
            }

            ShowParameter();
            GeneratePassengerCard();
            TotalCount();
        }

        private bool ValidatePenerbangan()
        {
            jadwal = db.JadwalPenerbangans.FirstOrDefault(j => j.ID == jadwalID);

            if (jadwal == null)
            {
                MessageBox.Show("Data penerbangan tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ShowParameter()
        {
            DateTime waktuBerangkat = jadwal.TanggalWaktuKeberangkatan;

            departureLabel.Text = $"{jadwal.Bandara.Nama} ({jadwal.Bandara.KodeIATA})";
            destinationLabel.Text = $"{jadwal.Bandara1.Nama} ({jadwal.Bandara.KodeIATA})";

            maskapaiLabel.Text = jadwal.Maskapai.Nama;

            dateLabel.Text = waktuBerangkat.ToString("dddd, dd MM yyyy");

            timeLabel.Text = waktuBerangkat.ToString("HH:mm") + " - " + waktuBerangkat.AddMinutes(jadwal.DurasiPenerbangan).ToString("HH:mm");

            passengerLabel.Text = jumlahPenumpang + " Penumpang";
        }

        private void GeneratePassengerCard()
        {

            flpPassenger.Controls.Clear();

            daftarKartuPenumpang.Clear();

            for (int nomor = 1; nomor <= jumlahPenumpang; nomor++)
            {

                PenumpangControl card = new PenumpangControl();

                card.NomorPenumpang = nomor;

                card.Width = flpPassenger.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 10;

                daftarKartuPenumpang.Add(card);

                flpPassenger.Controls.Add(card);
            }
        }

        private void TotalCount()
        {

            double totalSebelumDiskon = jadwal.HargaPerTiket * jumlahPenumpang;

            totalPembayaranAkhir = totalSebelumDiskon - totalDiskon;

            totalPembayaranAkhir = Math.Max(totalPembayaranAkhir, 0);

            priceLabel.Text = "IDR " + totalPembayaranAkhir.ToString("N0", CultureInfo.GetCultureInfo("id-ID")); 
        }

        private void useBtn_Click(object sender, EventArgs e)
        {

            string kodeInput = promoText.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(kodeInput))
            {
                MessageBox.Show("Masukkan kode promo terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ApplyPromoCode(kodeInput);
        }

        private void ApplyPromoCode(string kodeInput)
        {
            KodePromo promo = db.KodePromoes.FirstOrDefault(p => p.Kode == kodeInput);

            if (promo == null || promo.BerlakuSampai < DateTime.Today) 
            {
                kodePromoID = null;
                totalDiskon = 0;
                TotalCount();
                MessageBox.Show("Kode promo tidak valid atau sudah kadaluarsa", "Kode Promo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            kodePromoID = promo.ID;

            double totalSebelumDiskon = jadwal.HargaPerTiket * jumlahPenumpang;

            double diskonBerdasarkanPersen = totalSebelumDiskon * promo.PersentaseDiskon / 100.0;

            totalDiskon = Math.Min(diskonBerdasarkanPersen, promo.MaksimumDiskon);

            TotalCount();

            MessageBox.Show("Kode promo berhasil digunakan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValidateDataPenumpang()
        {

            for (int i = 0; i < daftarKartuPenumpang.Count; i++)
            {

                PenumpangControl card = daftarKartuPenumpang[i];

                if (!card.DataSudahLengkap)
                {
                    MessageBox.Show("Mohon lengkapi data penumpang #" + (i + 1), "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void payBtn_Click(object sender, EventArgs e)
        {

            if (!ValidateDataPenumpang())
            {
                return;
            }

            if (!SaveTransaction())
            {
                return;
            }

            transaksiBerhasil = true;

            MessageBox.Show("Pembayaran berhasil! \nTerima kasih telah menggunakan Bromo Airlines.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private bool SaveTransaction()
        {

            using (var databaseTransaction = db.Database.BeginTransaction())
            {
                try
                {

                    TransaksiHeader header = new TransaksiHeader
                    {

                        AkunID = Session.loggedIn.ID,

                        TanggalTransaksi = DateTime.Now,

                        JadwalPenerbanganID = jadwalID,

                        JumlahPenumpang = jumlahPenumpang,

                        TotalHarga = totalPembayaranAkhir,

                        KodePromoID = kodePromoID
                    };

                    db.TransaksiHeaders.Add(header);

                    db.SaveChanges();

                    SavePassengerDetail(header.ID);

                    db.SaveChanges();

                    databaseTransaction.Commit();

                    return true;
                }
                catch (Exception ex)
                {

                    databaseTransaction.Rollback();

                    MessageBox.Show("Transaksi gagal disimpan. \n\n" + "Detail error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
        }

        private void SavePassengerDetail(int transaksiHeaderID)
        {

            foreach (PenumpangControl card in daftarKartuPenumpang)
            {
                TransaksiDetail detail = new TransaksiDetail
                {

                    TransaksiHeaderID = transaksiHeaderID,

                    TitelPenumpang = card.Titel,

                    NamaLengkapPenumpang = card.NamaLengkap
                };

                db.TransaksiDetails.Add(detail);
            }
        }

        private void Form11BeliTiket_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (transaksiBerhasil)
            {
                formCustomerMain.Show();
            }
            else
            {

                formSebelumnya.Show();
            }
        }
    }
}
