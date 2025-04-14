using System.Windows.Forms;
using System.Data.SQLite;

namespace BurcYorumUygulamasi
{
    public partial class Form1 : Form
    {
        string adi, soyadi, dtarihi, ayString, burc, burc_yorum, vki_yorum, burc_resmi;
        int gun, ay, yil;
        double kilosu, boyu, vki;
        string connectionString = "Data Source=BurcYorumVeritabani.sqlite;Version=3;"; // SQLite baðlantý dizesi
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form açýldýðý anda veritabanýndaki kiþiler gözüksün
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT adi, soyadi FROM Bilgiler"; // Adý ve soyadý al
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string adiSoyadi = reader["adi"].ToString() + " " + reader["soyadi"].ToString();
                            listBox1.Items.Add(adiSoyadi); // ListBox'a ekle
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adi = text_adi.Text;
            soyadi = text_soyadi.Text;
            kilosu = double.Parse(text_kilosu.Text);
            boyu = double.Parse(text_boyu.Text);
            dtarihi = text_dtarihi.Text;

            gun = int.Parse(dtarihi.Substring(0, 2));
            ay = int.Parse(dtarihi.Substring(3, 2));
            yil = int.Parse(dtarihi.Substring(6, 4));

            //aylar
            switch (ay)
            {
                case 01: ayString = "Ocak"; break;
                case 02: ayString = "Þubat"; break;
                case 03: ayString = "Mart"; break;
                case 04: ayString = "Nisan"; break;
                case 05: ayString = "Mayýs"; break;
                case 06: ayString = "Haziran"; break;
                case 07: ayString = "Temmuz"; break;
                case 08: ayString = "Aðustos"; break;
                case 09: ayString = "Eylül"; break;
                case 10: ayString = "Ekim"; break;
                case 11: ayString = "Kasým"; break;
                case 12: ayString = "Aralýk"; break;
            }

            //vki
            vki = kilosu / (boyu * boyu);
            if (vki < 18.5)
                vki_yorum = "Zayýf";
            else if (vki < 25)
                vki_yorum = "Normal kilolu";
            else if (vki < 30)
                vki_yorum = "Fazla kilolu";
            else
                vki_yorum = "Obez";

            //Burçlar
            if ((ay == 3 && gun >= 21) || (ay == 4 && gun <= 20))
            {
                burc = "Koç";
                burc_yorum = "Lider ruhlusunuz, enerjiniz yüksek!";
                burc_resmi = "koc.png";
            }
            else if ((ay == 4 && gun >= 21) || (ay == 5 && gun <= 21))
            {
                burc = "Boða";
                burc_yorum = "Sabýrlý ve kararlýsýnýz.";
                burc_resmi = "boga.png";
            }
            else if ((ay == 5 && gun >= 22) || (ay == 6 && gun <= 22))
            {
                burc = "Ýkizler";
                burc_yorum = "Zeki ve iletiþimcisiniz.";
                burc_resmi = "ikizler.png";
            }
            else if ((ay == 6 && gun >= 23) || (ay == 7 && gun <= 22))
            {
                burc = "Yengeç";
                burc_yorum = "Duygusal ve sezgiselsiniz.";
                burc_resmi = "yengec.png";
            }
            else if ((ay == 7 && gun >= 23) || (ay == 8 && gun <= 22))
            {
                burc = "Aslan";
                burc_yorum = "Kendine güvenen ve yaratýcý birisiniz.";
                burc_resmi = "aslan.png";
            }
            else if ((ay == 8 && gun >= 23) || (ay == 9 && gun <= 22))
            {
                burc = "Baþak";
                burc_yorum = "Titiz ve detaycýsýnýz.";
                burc_resmi = "basak.png";
            }
            else if ((ay == 9 && gun >= 23) || (ay == 10 && gun <= 22))
            {
                burc = "Terazi";
                burc_yorum = "Adaletli ve uyumlusunuz.";
                burc_resmi = "terazi.png";
            }
            else if ((ay == 10 && gun >= 23) || (ay == 11 && gun <= 21))
            {
                burc = "Akrep";
                burc_yorum = "Tutkulu ve kararlýsýnýz.";
                burc_resmi = "akrep.png";
            }
            else if ((ay == 11 && gun >= 22) || (ay == 12 && gun <= 21))
            {
                burc = "Yay";
                burc_yorum = "Maceracý ve iyimser bir ruhunuz var.";
                burc_resmi = "yay.png";
            }
            else if ((ay == 12 && gun >= 22) || (ay == 1 && gun <= 21))
            {
                burc = "Oðlak";
                burc_yorum = "Çalýþkan ve disiplinlisiniz.";
                burc_resmi = "oglak.png";
            }
            else if ((ay == 1 && gun >= 22) || (ay == 2 && gun <= 19))
            {
                burc = "Kova";
                burc_yorum = "Yenilikçi ve baðýmsýzsýnýz.";
                burc_resmi = "kova.png";
            }
            else if ((ay == 2 && gun >= 20) || (ay == 3 && gun <= 20))
            {
                burc = "Balýk";
                burc_yorum = "Hayal gücünüz yüksek ve sezgiselsiniz.";
                burc_resmi = "balik.png";
            }

            // Veritabanýna Kaydetme
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Bilgiler (adi, soyadi, gun, ay, yil, burc, burc_yorum, burc_resmi, vki, vki_yorum) " +
                               "VALUES (@adi, @soyadi, @gun, @ay, @yil, @burc, @burc_yorum, @burc_resmi, @vki, @vki_yorum)";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@adi", adi);
                    command.Parameters.AddWithValue("@soyadi", soyadi);
                    command.Parameters.AddWithValue("@gun", gun);
                    command.Parameters.AddWithValue("@ay", ayString);
                    command.Parameters.AddWithValue("@yil", yil);
                    command.Parameters.AddWithValue("@burc", burc);
                    command.Parameters.AddWithValue("@burc_yorum", burc_yorum);
                    command.Parameters.AddWithValue("@burc_resmi", burc_resmi);
                    command.Parameters.AddWithValue("@vki", vki);
                    command.Parameters.AddWithValue("@vki_yorum", vki_yorum);

                    command.ExecuteNonQuery();
                }
            }


            listBox1.Items.Clear();
            //ListBox'a ekleme
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT adi, soyadi FROM Bilgiler"; // Adý ve soyadý al
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string adiSoyadi = reader["adi"].ToString() + " " + reader["soyadi"].ToString();
                            listBox1.Items.Add(adiSoyadi); // ListBox'a ekle
                        }
                    }
                }
            }
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        // Seçilen kiþinin bilgilerini veritabanýndan çekme
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedName = listBox1.SelectedItem.ToString(); // Seçilen kiþinin adý soyadý
                string[] nameParts = selectedName.Split(' '); // Ad ve soyadý ayýr

                if (nameParts.Length == 2)
                {
                    string adi = nameParts[0];
                    string soyadi = nameParts[1];

                    // Seçilen kiþinin bilgilerini veritabanýndan çek
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT * FROM Bilgiler WHERE adi = @adi AND soyadi = @soyadi"; // Ad ve soyadýna göre arama yap

                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@adi", adi);
                            command.Parameters.AddWithValue("@soyadi", soyadi);

                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Veritabanýndaki bilgileri ekrana yazdýr
                                    isim_label.Text = reader["adi"].ToString();
                                    soyisim_label.Text = reader["soyadi"].ToString();
                                    gun_label.Text = reader["gun"].ToString();
                                    ay_label.Text = reader["ay"].ToString();
                                    yil_label.Text = reader["yil"].ToString();
                                    burc_label.Text = reader["burc"].ToString();
                                    burc_yorum_label.Text = reader["burc_yorum"].ToString();
                                    vki_label.Text = reader["vki"].ToString();
                                    vki_yorum_label.Text = reader["vki_yorum"].ToString();
                                    pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "burclar", reader["burc_resmi"].ToString()));
                                }
                            }
                        }
                    }
                }
            }
        }

        //Veritabanýndaki bilgileri silme
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tüm veriler silinecek, emin misiniz?", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Bilgiler"; // Tüm verileri sil

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                // Listbox'ý ve etiketleri temizle
                listBox1.Items.Clear();
                isim_label.Text = "";
                soyisim_label.Text = "";
                gun_label.Text = "";
                ay_label.Text = "";
                yil_label.Text = "";
                burc_label.Text = "";
                burc_yorum_label.Text = "";
                vki_label.Text = "";
                vki_yorum_label.Text = "";
                pictureBox1.Image = null;

                MessageBox.Show("Veritabaný baþarýyla temizlendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
