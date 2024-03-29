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
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ProjeYönetimi;

namespace ProjeYönetimi
{
    public partial class AnaSayfa : Form
    {
        MySqlConnection baglanti = new MySqlConnection("server = localhost;database = proje;uid = root;pwd = rakonda");
        //("Data Source = DESKTOP-JUDHADS; Initial Catalog = proje; Integrated Security = True");


        public AnaSayfa(string ad, string ID)
        {
            InitializeComponent();
            HosgeldinizLabel.Text = $"Hoşgeldiniz : {ad}";
            kullanici = ID;
            add = ad;
        }
        public string kullanici;
        public string add;

        public void AnaSayfa_Load(object sender, EventArgs e)
        {

            DataTable tablo = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM proje WHERE Kullanici_KullaniciID = '" + kullanici + "'", baglanti);
            da.Fill(tablo);
            ProjelerimComboBox.ValueMember = "ProjeID";
            ProjelerimComboBox.DisplayMember = "ProjeAdı";
            ProjelerimComboBox.DataSource = tablo;

            DataTable tumcalisanlar = new DataTable();
            MySqlDataAdapter datumcalisanlar = new MySqlDataAdapter("SELECT DISTINCT KullaniciAd,KullaniciID FROM kullanici INNER JOIN gorevler ON KullaniciID = gorevler.Kullanici_KullaniciID", baglanti);
            datumcalisanlar.Fill(tumcalisanlar);
            CalisanlarımComboBox.DisplayMember = "KullaniciAd";
            CalisanlarımComboBox.ValueMember = "KullaniciID";
            CalisanlarımComboBox.DataSource = tumcalisanlar;


        }

        public int calisanlarkullaniciIDD;

        private void ProjeEkleButton_Click(object sender, EventArgs e)
        {
            ProjeEkle projeekle = new ProjeEkle(kullanici);
            projeekle.ShowDialog();
        }

        private void GorevGuncelleButton_Click(object sender, EventArgs e)
        {
            GorevGuncelle gorevguncelle = new GorevGuncelle(kullanici);
            gorevguncelle.ShowDialog();
        }

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void GorevEkleButton_Click(object sender, EventArgs e)
        {
            GorevEkle gorevekle = new GorevEkle(kullanici);
            gorevekle.ShowDialog();
        }

        private void calisanEkle_Click(object sender, EventArgs e)
        {
            CalisanEkle calisanEkle = new CalisanEkle();
            calisanEkle.ShowDialog();
        }

        private void gizleButton_Click(object sender, EventArgs e)
        {

        }

        private void cikisButton_Click(object sender, EventArgs e)
        {

        }

        public void TemizleGorevComboBoxlar()
        {
            GorevliComboBox.DataSource = null;
            GorevBaslangicTarihiComboBox.DataSource = null;
            GorevBitisTarihiComboBox.DataSource = null;
            GorevDurumComboBox.DataSource = null;
            ProjeGorevleriComboBox.DataSource = null;
            SilinecekGorevComboBox.DataSource = null;
        }

        public void ProjelerimComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ProjelerimComboBox.SelectedIndex != -1)
            {

                DataTable baslangictarihi = new DataTable();
                MySqlDataAdapter dabaslangic = new MySqlDataAdapter("SELECT * FROM proje WHERE ProjeID = '" + ProjelerimComboBox.SelectedValue + "' ", baglanti);
                dabaslangic.Fill(baslangictarihi);
                ProjelerimBaslangicTarihiComboBox.DisplayMember = "ProjeBaslangicTarihi";
                ProjelerimBaslangicTarihiComboBox.DataSource = baslangictarihi;

                DataTable bitistarihi = new DataTable();
                MySqlDataAdapter dabitis = new MySqlDataAdapter("SELECT * FROM proje WHERE ProjeID = '" + ProjelerimComboBox.SelectedValue + "' ", baglanti);
                dabitis.Fill(bitistarihi);
                ProjelerimBitisTarihiComboBox.DisplayMember = "ProjeBitisTarihi";
                ProjelerimBitisTarihiComboBox.DataSource = bitistarihi;

                DataTable gorev = new DataTable();
                MySqlDataAdapter dagorev = new MySqlDataAdapter("SELECT * FROM gorevler WHERE Proje_ProjeID = '" + ProjelerimComboBox.SelectedValue + "' ", baglanti);
                dagorev.Fill(gorev);
                ProjeGorevleriComboBox.DisplayMember = "GorevAdi";
                ProjeGorevleriComboBox.ValueMember = "GorevID";
                ProjeGorevleriComboBox.DataSource = gorev;

                DataTable silgorev = new DataTable();
                MySqlDataAdapter dasilgorev = new MySqlDataAdapter("SELECT * FROM gorevler WHERE Proje_ProjeID = '" + ProjelerimComboBox.SelectedValue + "' ", baglanti);
                dasilgorev.Fill(silgorev);
                SilinecekGorevComboBox.DisplayMember = "GorevAdi";
                SilinecekGorevComboBox.DataSource = silgorev;

                DataTable projedurum = new DataTable();
                MySqlDataAdapter daprojedurum = new MySqlDataAdapter("SELECT * FROM gorevler WHERE Proje_ProjeID = '" + ProjelerimComboBox.SelectedValue + "' ", baglanti);
                daprojedurum.Fill(projedurum);

                bool tumDurumlarTamamlandi = true;

                foreach (DataRow row in projedurum.Rows)
                {
                    string durum = row["Durum"].ToString();

                    if (!durum.Equals("Tamamlandı", StringComparison.OrdinalIgnoreCase))
                    {
                        tumDurumlarTamamlandi = false;
                        break;
                    }
                }

                if (tumDurumlarTamamlandi)
                {
                    ProjelerimDurumComboBox.Text = "Tamamlandı";
                }
                else
                {
                    bool devamediyor = false;

                    foreach (DataRow row in projedurum.Rows)
                    {
                        string durum = row["Durum"].ToString();

                        if (durum.Equals("Devam Ediyor", StringComparison.OrdinalIgnoreCase))
                        {
                            devamediyor = true;
                            break;
                        }
                    }

                    if (devamediyor)
                    {
                        ProjelerimDurumComboBox.Text = "Devam Ediyor";
                    }
                    else
                    {
                        ProjelerimDurumComboBox.Text = "Başlanacak";
                    }
                }

                if (ProjeGorevleriComboBox.Items.Count == 0)
                {
                    TemizleGorevComboBoxlar();
                }

            }
            else
            {
                TemizleGorevComboBoxlar();
            }

        }


        public void ProjeGorevleriComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProjeGorevleriComboBox.SelectedIndex != -1)
            {

                DataTable gorevli = new DataTable();
                MySqlDataAdapter dagorevli = new MySqlDataAdapter("SELECT KullaniciAd FROM kullanici INNER JOIN gorevler " +
                    "ON gorevler.Kullanici_KullaniciID = kullanici.KullaniciID WHERE GorevID = '" + ProjeGorevleriComboBox.SelectedValue + "'", baglanti);
                dagorevli.Fill(gorevli);
                GorevliComboBox.DisplayMember = "KullaniciAd";
                GorevliComboBox.DataSource = gorevli;

                DataTable gorevbaslangictarihi = new DataTable();
                MySqlDataAdapter dagorevbaslangic = new MySqlDataAdapter("SELECT * FROM gorevler WHERE GorevID = '" + ProjeGorevleriComboBox.SelectedValue + "' ", baglanti);
                dagorevbaslangic.Fill(gorevbaslangictarihi);
                GorevBaslangicTarihiComboBox.DisplayMember = "GorevBaslangicTarihi";
                GorevBaslangicTarihiComboBox.DataSource = gorevbaslangictarihi;

                DataTable gorevbitistarihi = new DataTable();
                MySqlDataAdapter dagorevbitis = new MySqlDataAdapter("SELECT * FROM gorevler WHERE GorevID = '" + ProjeGorevleriComboBox.SelectedValue + "' ", baglanti);
                dagorevbitis.Fill(gorevbitistarihi);
                GorevBitisTarihiComboBox.DisplayMember = "GorevBitisTarihi";
                GorevBitisTarihiComboBox.DataSource = gorevbitistarihi;

                DataTable gorevdurum = new DataTable();
                MySqlDataAdapter dadurum = new MySqlDataAdapter("SELECT * FROM gorevler WHERE GorevID = '" + ProjeGorevleriComboBox.SelectedValue + "' ", baglanti);
                dadurum.Fill(gorevdurum);
                GorevDurumComboBox.DisplayMember = "Durum";
                GorevDurumComboBox.DataSource = gorevdurum;

                if (GorevliComboBox.Items.Count == 0)
                {
                    TemizleGorevComboBoxlar();
                }

            }
            else
            {
                TemizleGorevComboBoxlar();
            }
        }

        private void SilinecekGorevComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SilinecekGorevComboBox.SelectedIndex != -1)
            {
                DataTable silinecekgorev = new DataTable();
                MySqlDataAdapter dasilinecekgorev = new MySqlDataAdapter("SELECT * FROM gorevler WHERE GorevID = '" + SilinecekGorevComboBox.SelectedValue + "' ", baglanti);
                dasilinecekgorev.Fill(silinecekgorev);
                SilinecekGorevComboBox.ValueMember = "GorevID";
                SilinecekGorevComboBox.DataSource = silinecekgorev;

                DataRowView Row = (DataRowView)SilinecekGorevComboBox.SelectedItem;


                int gorevID = Convert.ToInt32(Row["GorevID"]);
                gorevIDD = gorevID;
            }

        }
        public int gorevIDD;

        private void GorevSilButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("DELETE FROM gorevler WHERE GorevID = '" + gorevIDD + "'", baglanti);
            MessageBox.Show("Görev Silindi!!");
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void YenileButton_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa(add, kullanici);
            anaSayfa.Show();
        }

        private void DurumGuncelleButton_Click(object sender, EventArgs e)
        {
            string degisendurum = GorevDurumComboBox.Text;
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("UPDATE gorevler SET Durum = '" + degisendurum + "' " +
                "WHERE GorevID = '" + ProjeGorevleriComboBox.SelectedValue + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Görev Durumu Değiştirildi!");
        }

        private void CalisanlarımComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CalisanlarımComboBox.SelectedIndex != -1)
            {
                DevamEdenProjelerComboBox.DataSource = null;
                TamamlananProjelerComboBox.DataSource = null;
                TamamlanmayanProjelerComboBox.DataSource = null;
                ProjeleriListBox.DataSource = null;

                DataTable calisansec = new DataTable();
                MySqlDataAdapter dacalisansec = new MySqlDataAdapter("SELECT Durum FROM gorevler WHERE Kullanici_KullaniciID = '" + CalisanlarımComboBox.SelectedValue + "' ", baglanti);
                dacalisansec.Fill(calisansec);

                Dictionary<string, int> durumSayac = new Dictionary<string, int>
                {
                    { "Tamamlandı", 0 },
                    { "Devam Ediyor", 0 },
                    { "Başlanacak", 0 }
                };

                foreach (DataRow row in calisansec.Rows)
                {
                    string sqlDurum = row["Durum"].ToString();
                    if (durumSayac.ContainsKey(sqlDurum))
                    {
                        durumSayac[sqlDurum]++;
                    }
                }

                TamamlananSayiBox.Text = durumSayac["Tamamlandı"].ToString();
                DevamEdenSayiBox.Text = durumSayac["Devam Ediyor"].ToString();
                BaslanacakSayiBox.Text = durumSayac["Başlanacak"].ToString();
                string devamediyor = "Devam Ediyor";
                string tamamlandi = "Tamamlandı";
                string baslanacak = "Başlanacak";

                DataTable devameden = new DataTable();
                MySqlDataAdapter dadevameden = new MySqlDataAdapter("SELECT * FROM gorevler JOIN kullanici ON gorevler.Kullanici_KullaniciID = KullaniciID " +
                    "WHERE Kullanici_KullaniciID = '" + CalisanlarımComboBox.SelectedValue + "' AND Durum = '"+ devamediyor + "' ", baglanti);
                dadevameden.Fill(devameden);
                DevamEdenProjelerComboBox.ValueMember = "GorevID";
                DevamEdenProjelerComboBox.DisplayMember = "GorevAdi";
                DevamEdenProjelerComboBox.DataSource = devameden;

                DataTable tamamlanan = new DataTable();
                MySqlDataAdapter datamamlanan = new MySqlDataAdapter("SELECT * FROM gorevler JOIN kullanici ON gorevler.Kullanici_KullaniciID = KullaniciID " +
                    "WHERE Kullanici_KullaniciID = '" + CalisanlarımComboBox.SelectedValue + "' AND Durum = '" + tamamlandi + "' ", baglanti);
                datamamlanan.Fill(tamamlanan);
                TamamlananProjelerComboBox.ValueMember = "GorevID";
                TamamlananProjelerComboBox.DisplayMember = "GorevAdi";
                TamamlananProjelerComboBox.DataSource = tamamlanan;

                DataTable baslaniyor = new DataTable();
                MySqlDataAdapter dabaslaniyor = new MySqlDataAdapter("SELECT * FROM gorevler JOIN kullanici ON gorevler.Kullanici_KullaniciID = KullaniciID " +
                    "WHERE Kullanici_KullaniciID = '" + CalisanlarımComboBox.SelectedValue + "' AND Durum = '" + baslanacak + "' ", baglanti);
                dabaslaniyor.Fill(baslaniyor);
                TamamlanmayanProjelerComboBox.ValueMember = "GorevID";
                TamamlanmayanProjelerComboBox.DisplayMember = "GorevAdi";
                TamamlanmayanProjelerComboBox.DataSource = baslaniyor;

                DataTable projeler = new DataTable();
                MySqlDataAdapter daprojeler = new MySqlDataAdapter("SELECT * FROM proje INNER JOIN gorevler ON gorevler.Proje_ProjeID = proje.ProjeID " +
                    "WHERE gorevler.Kullanici_KullaniciID = '" + CalisanlarımComboBox.SelectedValue + "' ", baglanti);
                daprojeler.Fill(projeler);

                ProjeleriListBox.DisplayMember = "ProjeAdı";
                ProjeleriListBox.ValueMember = "ProjeID";
                ProjeleriListBox.DataSource = projeler;

            }
        }
    }
}
