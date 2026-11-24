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
    public partial class Form2register : Form
    {
        BandaraEntities db = new BandaraEntities();

        public Form2register()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Form1Login login = new Form1Login();
            this.Hide();
            login.Show();
        }

        private void daftarBtn_Click(object sender, EventArgs e) 
        {

            if (textBox1.Text == "" || textBox2.Text == "" ||
            textBox3.Text == "" || textBox5.Text == "" ||
            dateTimePicker1.Value.Date == DateTime.Today)
            {
                MessageBox.Show("Tolong lengkapi semua data yang diperlukan untuk membuat akun baru");
                return;
            }

            bool usernameSudahAda = db.Akuns.Any(a => a.Username == textBox1.Text);

            if (usernameSudahAda)
            {
                MessageBox.Show("Username sudah digunakan");
                return;
            }

            if (!textBox3.Text.All(char.IsDigit)) 
            {
                MessageBox.Show("Nomor telepon hanya boleh berisikan angka");
                return;
            }

            if (textBox3.Text.Length < 10 || textBox3.Text.Length > 15) 

            {
                MessageBox.Show("Nomor telepon harus 10 - 15 digit");
                return;
            }

            if (textBox5.Text.Length < 8)
            {
                MessageBox.Show("Password minimal 8 karakter");
                return;
            }

            int umur = DateTime.Now.Year - dateTimePicker1.Value.Year;

            if (dateTimePicker1.Value.Date > DateTime.Today.AddYears(-umur)) 

            {
                umur--; 
            }

            if (umur < 17) 
            {
                MessageBox.Show("Umur minimal 17 tahun!");
                return;
            }

            Akun akunBaru = new Akun();

            akunBaru.Username = textBox1.Text;
            akunBaru.Nama = textBox2.Text;
            akunBaru.TanggalLahir = dateTimePicker1.Value;
            akunBaru.NomorTelepon = textBox3.Text;
            akunBaru.Password = textBox5.Text;
            akunBaru.MerupakanAdmin = false; 

            db.Akuns.Add(akunBaru);
            db.SaveChanges();

            MessageBox.Show("Berhasil membuat akun baru. \nSilahkan login");

            Form1Login login = new Form1Login();
            login.Show();
            this.Hide();
        }
    }
}
