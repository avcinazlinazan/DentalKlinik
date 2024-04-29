//using DisKlinikYS.Class;
using Kimtoo.DbManager;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisKlinikYS.Forms
{
    public partial class TedaviFrm : Form
    {
        SqlHelper con = new SqlHelper();
        FrmMain MainFrm = new FrmMain();
        public TedaviFrm()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            MainFrm.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // Formdaki textbox'lardan hasta bilgilerini al
                //int tedavi_id = int.Parse(TedaviIdTxt.Text);
                if (randevucomboBox.SelectedValue != null && islemcomboBox != null)
                {
                    int randevu_id = int.Parse(randevucomboBox.SelectedValue.ToString());
                    DateTime tedavi_tarihi = DateTime.Parse(TedaviPicker.Text);
                    string aciklama = AciklamaTxt.Text.ToString();
                    Double fiyat = Double.Parse(fiyatTxt.Text);
                    string uygulanan_islemler = islemcomboBox.SelectedItem?.ToString();

                    // Hasta bilgilerini veritabanına kaydet

                    con.ExecuteProc("tedavi_kaydet",
                    new NpgsqlParameter("randevu_id", NpgsqlDbType.Integer) { Value = randevu_id },
                    new NpgsqlParameter("tedavi_tarihi", NpgsqlDbType.Date) { Value = tedavi_tarihi },
                    new NpgsqlParameter("aciklama", NpgsqlDbType.Varchar) { Value = aciklama },
                    new NpgsqlParameter("fiyat", NpgsqlDbType.Double) { Value = fiyat },
                    new NpgsqlParameter("uygulanan_islemler", NpgsqlDbType.Varchar) { Value = uygulanan_islemler }
                   );
                }
                else
                {
                    MessageBox.Show("Tedavi seçilmedi.");
                }
                MessageBox.Show("Tedavi Kaydı başarıyla gerçekleşti", "Bilgi", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tedavi kaydı yapılamadı: " + ex.Message);
            }
            MainFrm.getir(dataGridView1, "select * from tedavi;");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dtgetdata = new DataTable();
            dtgetdata = con.GetTable("select * from tedavi;");
            dataGridView1.DataSource = dtgetdata;
        }

        private void TedaviFrm_Load(object sender, EventArgs e)
        {

            string tedaviQuery = "SELECT * FROM randevu";
            DataTable tedaviTable = con.GetTable(tedaviQuery);
            randevucomboBox.DisplayMember = "randevu_tarihi";
            randevucomboBox.ValueMember = "randevu_id";
            randevucomboBox.DataSource = tedaviTable;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainFrm.getir(dataGridView1, "select * from tedavi_view;");
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            MainFrm.getir(dataGridView1, "select * from tedavi Where aciklama like '%" + textBoxAra.Text + "%'");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            MainFrm.getir(dataGridView1, "select * from tedavi;");
        }
    }
}
