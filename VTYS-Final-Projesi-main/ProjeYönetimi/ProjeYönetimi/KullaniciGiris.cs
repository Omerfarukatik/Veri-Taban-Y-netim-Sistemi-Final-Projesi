using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ProjeYönetimi
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("server = localhost;database = proje;uid = root;pwd = rakonda");

        private void GirisYapButton_Click(object sender, EventArgs e)
        {
            try
            {
                string email = emailTextBox.Text;
                string sifree = sifreTextBox.Text;
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM kullanici WHERE KullaniciEmail ='" + email + "' AND KullaniciSifre ='" + sifree + "'";
                komut.ExecuteNonQuery();
                MySqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    string ID = dr["KullaniciID"].ToString();
                    string ad = dr["KullaniciAd"].ToString();
                    AnaSayfa anasayfa = new AnaSayfa(ad,ID);
                    anasayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email Veya Şifre Yanlış", "DIKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("KULLANİİC BULUNMADI");
                }
                baglanti.Close();
            }
            catch (Exception)
            {

            }

        }


        private void KullaniciGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void KayıtOlLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciYeni yenikullanici = new KullaniciYeni();
            yenikullanici.Show();
            this.Hide();
        }
    }

    
}

