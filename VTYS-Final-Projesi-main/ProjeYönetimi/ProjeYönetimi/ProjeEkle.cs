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
    public partial class ProjeEkle : Form
    {
        public ProjeEkle(string ID)
        {
            InitializeComponent();
            kullanici = ID;
        }
        public string kullanici;
        MySqlConnection baglanti = new MySqlConnection("server = localhost;database = proje;uid = root;pwd = rakonda");
        public void OlusturButton_Click(object sender, EventArgs e)
        {
            string projead = ProjeAdıTextBox.Text;
            string baslangictarihi = BaslangicTarihiTextBox.Text;
            string bitistarihi = BitisTarihiTextBox.Text;

            if (projead == "" || baslangictarihi == "" || bitistarihi == "")
            {
                MessageBox.Show("Lütfen Boş Bıraktığınız Yerleri Doldurunuz!!!");
            }
            else
            {

                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("INSERT INTO proje (ProjeAdı, ProjeBaslangicTarihi,ProjeBitisTarihi,Kullanici_KullaniciID) VALUES('" + projead + "','" + baslangictarihi + "','" + bitistarihi + "','" + kullanici + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Proje Eklendi");
                this.Hide();
            }

        }
    }
}
