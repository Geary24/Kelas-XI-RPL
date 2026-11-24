using ContohSoal;
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
    public partial class Form1Login : Form
    {
        BandaraEntities db = new BandaraEntities();
        
        public Form1Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form2register register = new Form2register();
            this.Hide();
            register.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {

                MessageBox.Show("Username dan Password harus diisi"); 
                return;
            }

            var user = db.Akuns.FirstOrDefault(a => a.Username == textBox1.Text && a.Password == textBox2.Text);

            if (user == null) 
            {
                MessageBox.Show("Password atau Username salah");
                return;                
            }

            MessageBox.Show("Login Berhasil");
            Session.loggedIn = user;

            if (user.MerupakanAdmin)
            {

                Form3Dashboard dashboard = new Form3Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                Form9Customermain customer = new Form9Customermain();
                customer.Show();
                this.Hide();
            }
        }
    }
}
