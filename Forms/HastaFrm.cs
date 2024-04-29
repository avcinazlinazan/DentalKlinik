using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DisKlinikYS;
//using DisKlinikYS.Class;
using ServiceStack;
using Kimtoo.DbManager;
using ServiceStack.OrmLite;
using NpgsqlTypes;
using System.Text.RegularExpressions;

namespace DisKlinikYS.Forms
{


    public partial class HastaFrm : Form
    {
        SqlHelper con = new SqlHelper();
        FrmMain MainFrm = new FrmMain();

        public HastaFrm()
        {
            InitializeComponent();

        }
        public bool Kontrol(string eposta)
        {    // @"^([a-zA-Z0-9_\-\.]+)@(([0-9){1,2}" +
            string str = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return (new Regex(str).IsMatch(eposta));
        }
        public bool TelKontrol(string cepTel)
        {
            string str = @"^\(?\d{3}\)?[-. ]?\d{3}[-. ]?\d{4}$";
            //@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$";
            return (new Regex(str).IsMatch(cepTel));
        }
        private void button4_Click(object sender, EventArgs e)
        {

            MainFrm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainFrm.getir(dataGridView1, "select * from hasta;");
        }

        private void HastaFrm_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

           try
           {
             
            // Formdaki textbox'lardan hasta bilgilerini al
            int hasta_id = int.Parse(hasIdTxt.Text);
            string ad = AdTxt.Text;
            string soyad = SoyadTxt.Text;
            DateTime dogum_tarihi = DogTPicker.Value;
            string cinsiyet = CinsiyetcomboBox.SelectedItem?.ToString();
            string telefon = TelTxt.Text;
            string eposta = EpostaTxt.Text;

            // Hasta bilgilerini veritabanına kaydet
            // connectionsql.KaydetHasta(hasta_id, ad, soyad, dogumTarihi, cinsiyet, telefon, eposta);
            if (ad == "")
                {
                    MessageBox.Show("Lütfen hasta adı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (soyad == "")
                {
                    MessageBox.Show("Lütfen hasta soyadı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (telefon == "")
                {
                    MessageBox.Show("Lütfen cep telefonu giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (eposta == "")
                {
                    MessageBox.Show("Lütfen eposta adresi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool telKontrol = TelKontrol(telefon);
                    bool kontrol = Kontrol(eposta);
                    if (telKontrol == true)
                    {

                        if (kontrol == true)
                        {

                            con.ExecuteProc("hasta_kaydet",
                            new NpgsqlParameter("hasta_id", NpgsqlDbType.Integer) { Value = hasta_id },
                            new NpgsqlParameter("ad", NpgsqlDbType.Varchar) { Value = ad },

                            new NpgsqlParameter("soyad", NpgsqlDbType.Varchar) { Value = soyad },
                            new NpgsqlParameter("dogum_tarihi", NpgsqlDbType.Date) { Value = dogum_tarihi },
                            new NpgsqlParameter("cinsiyet", NpgsqlDbType.Varchar) { Value = cinsiyet },
                            new NpgsqlParameter("telefon", NpgsqlDbType.Varchar) { Value = telefon },
                            new NpgsqlParameter("eposta", NpgsqlDbType.Varchar) { Value = eposta }
                            );
                            MessageBox.Show("Hasta Kaydı başarıyla gerçekleşti", "Bilgi", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Lütfen geçerli bir eposta adresi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hasta kaydı yapılamadı: " + ex.Message);
            }
            MainFrm.getir(dataGridView1, "select * from hasta;");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            if (MessageBox.Show("Hasta kaydı silinirken randevu ve tedavi kayıtları da silinecektir. Silmeyi onaylıyor musunuz", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int hasta_id = int.Parse(hasIdTxt.Text);

                con.ExecuteProc("hasta_Sil",
                 new NpgsqlParameter("p_hasta_id", NpgsqlDbType.Integer) { Value = hasta_id }
                 );
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show("Hekim silinemedi: " + ex.Message);
            }
            MainFrm.getir(dataGridView1, "select * from hasta;");
        }
        private void label7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                int hasta_id = int.Parse(hasIdTxt.Text);
                string ad = AdTxt.Text;
                string soyad = SoyadTxt.Text;
                DateTime dogumTarihi = DogTPicker.Value;
                string cinsiyet = CinsiyetcomboBox.SelectedItem?.ToString();
                string telefon = TelTxt.Text;
                string eposta = EpostaTxt.Text;



                con.ExecuteProc("hasta_guncelle",
                       new NpgsqlParameter("p_hasta_id", NpgsqlDbType.Integer) { Value = hasta_id },
                       new NpgsqlParameter("p_ad", NpgsqlDbType.Varchar) { Value = ad },
                       new NpgsqlParameter("p_soyad", NpgsqlDbType.Varchar) { Value = soyad },
                       new NpgsqlParameter("p_dogum_tarihi", NpgsqlDbType.Date) { Value = dogumTarihi },
                       new NpgsqlParameter("p_cinsiyet", NpgsqlDbType.Varchar) { Value = cinsiyet },
                       new NpgsqlParameter("p_telefon", NpgsqlDbType.Varchar) { Value = telefon },
                       new NpgsqlParameter("p_eposta", NpgsqlDbType.Varchar) { Value = eposta }


                   );
                MessageBox.Show("Hasta Kaydı başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hasta güncellenemedi: " + ex.Message);
            }
            MainFrm.getir(dataGridView1, "select * from hasta;");
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Satır indeksi geçerli ise
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // DataGridView'deki ilgili hücrelerden verileri TextBox'lara aktar
                hasIdTxt.Text = row.Cells["hasta_id"].Value.ToString();
                AdTxt.Text = row.Cells["ad"].Value.ToString();
                SoyadTxt.Text = row.Cells["soyad"].Value.ToString();

                DogTPicker.Text = row.Cells["dogum_tarihi"].Value.ToString();
                CinsiyetcomboBox.Text = row.Cells["cinsiyet"].Value.ToString();
                TelTxt.Text = row.Cells["telefon"].Value.ToString();
                EpostaTxt.Text = row.Cells["eposta"].Value.ToString();
                // Diğer verileri de benzer şekilde aktarabilirsiniz

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainFrm.getir(dataGridView1, "select * from hasta Where ad like '%" + textBoxAra.Text + "%'");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainFrm.getir(dataGridView1, "select * from hasta;");
        }
    }
}
