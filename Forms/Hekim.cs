//using DisKlinikYS.Class;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DisKlinikYS.Forms
{
    public partial class Hekim : Form
    {
        SqlHelper con = new SqlHelper();
        FrmMain MainFrm = new FrmMain();
        public Hekim()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Formdaki textbox'lardan hasta bilgilerini al
                int hekim_id = int.Parse(dhIdTxt.Text);
                string ad = dhAdTxt.Text;
                string soyad = dhsoyadTxt.Text;


                string uzmanlik_alani = null;
                if (uzmancomboBox.SelectedItem != null)
                {
                    uzmanlik_alani = uzmancomboBox.SelectedItem.ToString();
                }

                // Hekim bilgilerini veritabanına kaydet
                con.ExecuteProc("hekimkaydet",
                    new NpgsqlParameter("hekim_id", NpgsqlDbType.Integer) { Value = hekim_id },
                    new NpgsqlParameter("ad", NpgsqlDbType.Varchar) { Value = ad },
                    new NpgsqlParameter("soyad", NpgsqlDbType.Varchar) { Value = soyad },
                    new NpgsqlParameter("uzmanlik_alani", NpgsqlDbType.Varchar) { Value = uzmanlik_alani }
                );

                MessageBox.Show("Hekim Kaydı başarıyla gerçekleşti", "Bilgi", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hekim kaydı yapılamadı: " + ex.Message);
            }
            MainFrm.getir(dataGridView1, "select * from hekim;");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MainFrm.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MainFrm.getir(dataGridView1, "select * from hekim;");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int hekim_id = int.Parse(dhIdTxt.Text);

                con.ExecuteProc("hekim_Sil",
                 new NpgsqlParameter("p_hekim_id", NpgsqlDbType.Integer) { Value = hekim_id }
                 );
                MessageBox.Show("Hekim kaydı silinirken randevu ve tedavi kayıtları da silinecektir. Silmeyi onaylıyor musunuz", "Bilgi",
                    MessageBoxButtons.YesNo);
                MainFrm.getir(dataGridView1, "select * from hekim;");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hekim silinemedi: " + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int hekim_id = int.Parse(dhIdTxt.Text);
                string ad = dhAdTxt.Text;
                string soyad = dhsoyadTxt.Text;

                string uzmanlik_alani = null;
                if (uzmancomboBox.SelectedItem != null)
                {
                    uzmanlik_alani = uzmancomboBox.SelectedItem.ToString();
                }
                con.ExecuteProc("hekim_guncelle",
                       new NpgsqlParameter("p_hekim_id", NpgsqlDbType.Integer) { Value = hekim_id },
                       new NpgsqlParameter("p_ad", NpgsqlDbType.Varchar) { Value = ad },
                       new NpgsqlParameter("p_soyad", NpgsqlDbType.Varchar) { Value = soyad },
                       new NpgsqlParameter("p_uzmanlik_alani", NpgsqlDbType.Varchar) { Value = uzmanlik_alani }
                   );
                MessageBox.Show("Hekim Kaydı başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hekim güncellenemedi: " + ex.Message);
            }
            MainFrm.getir(dataGridView1, "select * from hekim;");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Satır indeksi geçerli ise
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // DataGridView'deki ilgili hücrelerden verileri TextBox'lara aktar
                dhIdTxt.Text = row.Cells["hekim_id"].Value.ToString();
                dhAdTxt.Text = row.Cells["ad"].Value.ToString();
                dhsoyadTxt.Text = row.Cells["soyad"].Value.ToString();
                uzmancomboBox.Text = row.Cells["uzmanlik_alani"].Value.ToString();

                // Diğer verileri de benzer şekilde aktarabilirsiniz
            }
        }
        private void buttonAra_Click(object sender, EventArgs e)
        {
            MainFrm.getir(dataGridView1, "select * from hekim Where ad like '%" + textBoxAra.Text + "%'");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainFrm.getir(dataGridView1, "select * from hekim;");
        }
        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
