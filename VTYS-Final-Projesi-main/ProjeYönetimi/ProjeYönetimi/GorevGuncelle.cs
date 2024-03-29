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
    public partial class GorevGuncelle : Form
    {
        public GorevGuncelle(string ID)
        {
            InitializeComponent();
            kullanici = ID;
        }
        MySqlConnection baglanti = new MySqlConnection("server = localhost;database = proje;uid = root;pwd = rakonda");
        public string kullanici;

        private void GorevGuncelle_Load(object sender, EventArgs e)
        {
            DataTable proje = new DataTable();
            MySqlDataAdapter daproje = new MySqlDataAdapter("SELECT * FROM proje WHERE Kullanici_KullaniciID = '" + kullanici + "'", baglanti);
            daproje.Fill(proje);
            ProjelerComboBox.ValueMember = "ProjeID";
            ProjelerComboBox.DisplayMember = "ProjeAdı";
            ProjelerComboBox.DataSource = proje;
            

        }

        private void ProjelerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProjelerComboBox.SelectedIndex != -1)
            {
                DataTable projeid = new DataTable();
                MySqlDataAdapter daprojeid = new MySqlDataAdapter("SELECT * FROM proje WHERE ProjeID = '" + ProjelerComboBox.SelectedValue + "'", baglanti);
                daprojeid.Fill(projeid);
                ProjelerComboBox.DisplayMember = "ProjeAdı";
                ProjelerComboBox.ValueMember = "ProjeID";
                ProjelerComboBox.DataSource = projeid;
                // Seçilen öğenin DataRowView olduğunu varsayalım
                DataRowView selectedRow = (DataRowView)ProjelerComboBox.SelectedItem;

                // DataRowView üzerinden ProjeID değerini al
                int projeID = Convert.ToInt32(selectedRow["ProjeID"]);
                projeIDD = projeID;

            }
        }
        public int projeIDD;

        private void GorevlerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GorevlerComboBox.SelectedIndex != -1)
            {
                DataTable gorevler = new DataTable();
                MySqlDataAdapter dagorevler = new MySqlDataAdapter("SELECT * FROM gorevler WHERE ProjeID = '" + GorevlerComboBox.SelectedValue + "'", baglanti);
                dagorevler.Fill(gorevler);
                GorevlerComboBox.DisplayMember = "GorevAdi";
                GorevlerComboBox.ValueMember = "GorevID";
                GorevlerComboBox.DataSource = gorevler;
            }
        }

        private void CalisanlarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void GuncelleButton_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
