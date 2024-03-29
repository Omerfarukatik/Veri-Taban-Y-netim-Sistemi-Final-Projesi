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
    public partial class GorevEkle : Form
    {
        public GorevEkle(string ID)
        {
            InitializeComponent();
            kullanici = ID;
        }
        public string kullanici;
        MySqlConnection baglanti = new MySqlConnection("server = localhost;database = proje;uid = root;pwd = rakonda");


        public void GorevEkle_Load(object sender, EventArgs e)
        {
            DataTable proje = new DataTable();
            MySqlDataAdapter daproje = new MySqlDataAdapter("SELECT * FROM proje WHERE Kullanici_KullaniciID = '" + kullanici + "'", baglanti);
            daproje.Fill(proje);
            projeComboBox.ValueMember = "ProjeID";
            projeComboBox.DisplayMember = "ProjeAdı";
            projeComboBox.DataSource = proje;
            // Seçilen öğenin DataRowView olduğunu varsayalım
            DataRowView selectedRow = (DataRowView)projeComboBox.SelectedItem;

            // DataRowView üzerinden ProjeID değerini al
            int projeID = Convert.ToInt32(selectedRow["ProjeID"]);
            projeIDD = projeID;

            DataTable calisanlar = new DataTable();
            MySqlDataAdapter dacalisan = new MySqlDataAdapter("SELECT * FROM kullanici", baglanti);
            dacalisan.Fill(calisanlar);
            CalisanlarComboBox.DisplayMember = "KullaniciAd";
            CalisanlarComboBox.ValueMember = "KullaniciID";
            CalisanlarComboBox.DataSource = calisanlar;

        }

        private void projeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (projeComboBox.SelectedIndex != -1)
            {
                DataTable projeid = new DataTable();
                MySqlDataAdapter daproje= new MySqlDataAdapter("SELECT * FROM proje WHERE ProjeID = '" + projeComboBox.SelectedValue + "'", baglanti);
                daproje.Fill(projeid);
                projeComboBox.DisplayMember = "ProjeAdı";
                projeComboBox.ValueMember = "ProjeID";
                projeComboBox.DataSource = projeid;
                // Seçilen öğenin DataRowView olduğunu varsayalım
                DataRowView Row = (DataRowView)projeComboBox.SelectedItem;

                // DataRowView üzerinden ProjeID değerini al
                int projeID = Convert.ToInt32(Row["ProjeID"]);
                projeIDD = projeID;
            }
        }

        private void CalisanlarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CalisanlarComboBox.SelectedIndex != -1)
            {
                DataTable calisanlar = new DataTable();
                MySqlDataAdapter dacalisan = new MySqlDataAdapter("SELECT * FROM kullanici WHERE KullaniciID = '"+ CalisanlarComboBox.SelectedValue + "'", baglanti);
                dacalisan.Fill(calisanlar);
                CalisanlarComboBox.DisplayMember = "KullaniciAd";
                CalisanlarComboBox.ValueMember = "KullaniciID";
                CalisanlarComboBox.DataSource = calisanlar;
                // Seçilen öğenin DataRowView olduğunu varsayalım
                DataRowView Row = (DataRowView)CalisanlarComboBox.SelectedItem;

                // DataRowView üzerinden ProjeID değerini al
                int kullaniciID = Convert.ToInt32(Row["KullaniciID"]);
                kullaniciIDD = kullaniciID;
            }
        }

        public int projeIDD;
        public int kullaniciIDD;
        public void KaydetButton_Click(object sender, EventArgs e)
        {

            string gorevad = GorevTextBox.Text;
            string baslangictarihi = BaslangicTextBox.Text;
            string bitistarihi = BitisTextBox.Text;
            string durum = "Başlanacak";

            if (gorevad == "" || baslangictarihi == "" || bitistarihi == "")
            {
                MessageBox.Show("Lütfen Boş Bıraktığınız Yerleri Doldurunuz!!!");
            }
            else
            {

                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("INSERT INTO gorevler (GorevBaslangicTarihi,GorevBitisTarihi,GorevAdi,Proje_ProjeID,Durum,Kullanici_KullaniciID) VALUES('" + baslangictarihi + "','" + bitistarihi + "','" + gorevad + "','" + projeIDD + "','" + durum + "','" + kullaniciIDD + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Görev Eklendi");
                this.Hide();
            }
            this.Hide();

        }

        
    }
}
