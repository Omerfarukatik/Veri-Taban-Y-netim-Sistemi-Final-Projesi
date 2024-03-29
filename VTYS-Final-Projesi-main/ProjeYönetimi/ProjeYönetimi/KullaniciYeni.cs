using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeYönetimi
{
    public partial class KullaniciYeni : Form
    {
        public KullaniciYeni()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("server = localhost;database = proje;uid = root;pwd = rakonda");
        private void KayıtOlButton_Click(object sender, EventArgs e)
        {
            string ad = İsimText.Text;
            string soyad = SoyadText.Text;
            string sifre = SifreText.Text;
            string email = EmailText.Text;

            if (ad == "" || soyad == "" || sifre == "" || email == "")
            {
                MessageBox.Show("Lütfen Boş Bıraktığınız Yerleri Tekrardan Giriş Yapınız!!!");
            }
            else
            {

                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("INSERT INTO kullanici (KullaniciAd, KullaniciSoyad,KullaniciSifre,KullaniciEmail) VALUES('" + ad + "','" + soyad + "','" + sifre + "','"+ email +"')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarılı!!!");

                KullaniciGiris kullaniciGiris = new KullaniciGiris();
                kullaniciGiris.Show();
                this.Hide();
            }

        }

        private void KullaniciYeni_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            KullaniciGiris kullaniciGiris = new KullaniciGiris();
            kullaniciGiris.Show();
            this.Hide();
        }
    }
}
