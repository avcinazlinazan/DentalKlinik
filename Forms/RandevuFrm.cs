//using DisKlinikYS.Class;
using Npgsql;
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
using NpgsqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DisKlinikYS.Forms
{
    public partial class RandevuFrm : Form
    {
        
        SqlHelper con = new SqlHelper();
        FrmMain MainFrm = new FrmMain();
        public RandevuFrm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainFrm.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Formdaki textbox'lardan hasta bilgilerini al

                int randevu_id = int.Parse(RandevuIdTxt.Text);

                if (DurumcomboBox.SelectedItem != null && TcomboBox.SelectedValue != null 
                    && HastacomboBox.SelectedValue != null && HekimcomboBox.SelectedValue != null)
                {
                    string durum = DurumcomboBox.SelectedItem.ToString();
                    int tedavi_id = int.Parse(TcomboBox.SelectedValue.ToString());
                    int hasta_id = int.Parse(HastacomboBox.SelectedValue.ToString());
                    int hekim_id = int.Parse(HekimcomboBox.SelectedValue.ToString());

                    DateTime randevu_tarihi = DateTime.Parse(TarihPicker.Text);
                    TimeOnly randevu_saati = TimeOnly.Parse(RandevuSaatiPicker.Text);
                    // Randevu bilgilerini veritabanına kaydet
                    con.ExecuteProc("randevu_kaydet",
                    new NpgsqlParameter("randevu_id", NpgsqlDbType.Integer) { Value = randevu_id },
                    new NpgsqlParameter("hekim_id", NpgsqlDbType.Integer) { Value = hekim_id },
                    new NpgsqlParameter("hasta_id", NpgsqlDbType.Integer) { Value = hasta_id },
                    new NpgsqlParameter("tedavi_id", NpgsqlDbType.Integer) { Value = tedavi_id },
                    new NpgsqlParameter("randevu_tarihi", NpgsqlDbType.Date) { Value = randevu_tarihi },
                    new NpgsqlParameter("randevu_saati", NpgsqlDbType.Time) { Value = randevu_saati },
                    new NpgsqlParameter("durum", NpgsqlDbType.Varchar) { Value = durum });
                }
                else
                {
                    MessageBox.Show("Randevu seçilemedi");
                }

                MessageBox.Show("Randevu Kaydı başarıyla onaylandı", "Bilgi", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu kaydı yapılamadı: " + ex.Message);
            }
            MainFrm.getir(dataGridView1, "select * from randevu;");

        }
        private void button8_Click(object sender, EventArgs e)
        {
            MainFrm.getir(dataGridView1, "select * from randevu_view;");
        }
        private void RandevuFrm_Load(object sender, EventArgs e)
        {
            // Hasta verilerini HastacomboBox'a doldurun
            string hastaQuery = "SELECT * FROM hasta";
            DataTable hastaTable = con.GetTable(hastaQuery);
            HastacomboBox.DisplayMember = "ad";
            HastacomboBox.ValueMember = "hasta_id";
            HastacomboBox.DataSource = hastaTable;

            // Hekim verilerini HekimcomboBox'a doldurun
            string hekimQuery = "SELECT * FROM hekim";
            DataTable hekimTable = con.GetTable(hekimQuery);
            HekimcomboBox.DisplayMember = "ad";
            HekimcomboBox.ValueMember = "hekim_id";
            HekimcomboBox.DataSource = hekimTable;
            // Tedavi verilerini TedavicomboBox'a doldurun
            string tedaviQuery = "SELECT * FROM tedavi";
            DataTable tedaviTable = con.GetTable(tedaviQuery);
            TcomboBox.DisplayMember = "tedavi_tarihi";
            TcomboBox.ValueMember = "tedavi_id";
            TcomboBox.DataSource = tedaviTable;
            MainFrm.getir(dataGridView1, "select * from randevu;");
        }
        private void buttonIptal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Randevu iptal edilecektir. Silmeyi onaylıyor musunuz", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int randevu_id = int.Parse(RandevuIdTxt.Text);

                con.ExecuteProc("Randevu_Sil",
                new NpgsqlParameter("p_randevu_id", NpgsqlDbType.Integer) { Value = randevu_id }
                );
                MainFrm.getir(dataGridView1, "select * from randevu;");
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonYenile_Click(object sender, EventArgs e)
        {
            MainFrm.getir(dataGridView1, "select * from randevu_view;");
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            MainFrm.getir(dataGridView1, "select * from randevu_view Where durum like '%" + textBoxAra.Text + "%'");
        }

        private void buttonErtele_Click(object sender, EventArgs e)
        {
            try
            {
                // Formdaki textbox'lardan hasta bilgilerini al

                int randevu_id = int.Parse(RandevuIdTxt.Text);

                if (DurumcomboBox.SelectedItem != null && TcomboBox.SelectedValue != null && HastacomboBox.SelectedValue != null && HekimcomboBox.SelectedValue != null)
                {
                    string durum = DurumcomboBox.SelectedItem.ToString();
                    int tedavi_id = int.Parse(TcomboBox.SelectedValue.ToString());
                    int hasta_id = int.Parse(HastacomboBox.SelectedValue.ToString());
                    int hekim_id = int.Parse(HekimcomboBox.SelectedValue.ToString());

                    DateTime randevu_tarihi = DateTime.Parse(TarihPicker.Text);
                    TimeOnly randevu_saati = TimeOnly.Parse(RandevuSaatiPicker.Text);
                    // Randevu bilgilerini veritabanına kaydet
                    con.ExecuteProc("randevu_guncelle",
                    new NpgsqlParameter("p_randevu_id", NpgsqlDbType.Integer) { Value = randevu_id },
                    new NpgsqlParameter("p_hekim_id", NpgsqlDbType.Integer) { Value = hekim_id },
                    new NpgsqlParameter("p_hasta_id", NpgsqlDbType.Integer) { Value = hasta_id },
                    new NpgsqlParameter("p_tedavi_id", NpgsqlDbType.Integer) { Value = tedavi_id },
                    new NpgsqlParameter("p_randevu_tarihi", NpgsqlDbType.Date) { Value = randevu_tarihi },
                    new NpgsqlParameter("p_randevu_saati", NpgsqlDbType.Time) { Value = randevu_saati },
                    new NpgsqlParameter("p_durum", NpgsqlDbType.Varchar) { Value = durum });
                }
                else
                {
                    MessageBox.Show("Randevu seçilemedi");
                }
                //int randevu_id = int.Parse(RandevuIdTxt.Text);

                
                MainFrm.getir(dataGridView1, "select * from randevu;");
                MessageBox.Show("Randevu güncellendi", "Bilgi", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevu kaydı güncellenemedi: " + ex.Message);
            }
            MainFrm.getir(dataGridView1, "select * from randevu;");

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Satır indeksi geçerli ise
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // DataGridView'deki ilgili hücrelerden verileri TextBox'lara aktar

                RandevuIdTxt.Text = row.Cells["randevu_id"].Value.ToString();
                DurumcomboBox.SelectedItem = row.Cells["durum"].Value.ToString();
                TcomboBox.SelectedValue = row.Cells["tedavi_id"].Value.ToString();
                HastacomboBox.SelectedValue = row.Cells["hasta_id"].Value.ToString();
                HekimcomboBox.SelectedValue = row.Cells["hekim_id"].Value.ToString();
                TarihPicker.Text = row.Cells["randevu_tarihi"].Value.ToString();
                RandevuSaatiPicker.Text = row.Cells["randevu_saati"].Value.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainFrm.getir(dataGridView1, "select * from randevu;");
        }
    }
}
