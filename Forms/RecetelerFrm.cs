using Npgsql;
using NpgsqlTypes;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DisKlinikYS.Forms
{
    public partial class RecetelerFrm : Form
    {
        SqlHelper con = new SqlHelper();
        FrmMain MainFrm = new FrmMain();
        public RecetelerFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int recete_id = int.Parse(ReceteIdTxt.Text);
                if (HastacomboBox.SelectedValue != null && RandevucomboBox != null)
                {
                    int hasta_id = int.Parse(HastacomboBox.SelectedValue.ToString());
                    int randevu_id = int.Parse(RandevucomboBox.SelectedValue.ToString());
                    DateTime olusturma_tarihi = DateTime.Parse(TarihPicker.Text);

                    decimal kullanim_sikligi = numericUpDown1.Value;
                    string ilac_ad = IlacAdiTxt.Text;
                    string dozaj = DozajTxt.Text;
                    string aciklama = AciklamaTxt.Text;

                    // Recete bilgilerini veritabanına kaydet
                    con.ExecuteProc("recete_kaydet",
                     new NpgsqlParameter("recete_id", NpgsqlDbType.Integer) { Value = recete_id },
                     new NpgsqlParameter("randevu_id", NpgsqlDbType.Integer) { Value = randevu_id },
                     new NpgsqlParameter("hasta_id", NpgsqlDbType.Integer) { Value = hasta_id },
                     new NpgsqlParameter("olusturma_tarihi", NpgsqlDbType.Date) { Value = olusturma_tarihi },
                     new NpgsqlParameter("kullanim_sikligi", NpgsqlDbType.Numeric) { Value = kullanim_sikligi },
                     new NpgsqlParameter("ilac_ad", NpgsqlDbType.Varchar) { Value = ilac_ad },
                     new NpgsqlParameter("dozaj", NpgsqlDbType.Varchar) { Value = dozaj },
                     new NpgsqlParameter("aciklama", NpgsqlDbType.Varchar) { Value = aciklama }

                 );
                }
                else
                {
                    MessageBox.Show("Hasta seçilmedi.");
                }

                // Formdaki textbox'lardan hasta bilgilerini al

                MessageBox.Show("Reçete Kaydı başarıyla oluşturuldu", "Bilgi", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reçete kaydı yapılamadı: " + ex.Message);
            }
            MainFrm.getir(dataGridView1, "select * from recete;");
        }

        private void RecetelerFrm_Load(object sender, EventArgs e)
        {
            // Hasta verilerini HastacomboBox'a doldurun
            string hastaQuery = "SELECT * FROM hasta";
            DataTable hastaTable = con.GetTable(hastaQuery);
            HastacomboBox.DisplayMember = "ad";
            HastacomboBox.ValueMember = "hasta_id";
            HastacomboBox.DataSource = hastaTable;

            string randevuQuery = "SELECT * FROM randevu";
            DataTable randevuTable = con.GetTable(randevuQuery);
            RandevucomboBox.DisplayMember = "durum";
            RandevucomboBox.ValueMember = "randevu_id";
            RandevucomboBox.DataSource = randevuTable;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MainFrm.Show();
            this.Hide();
        }
        private void button7_Click(object sender, EventArgs e)
        {

            MainFrm.getir(dataGridView1, "select * from recete;");
        }
        private void Print()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.PrintPage);
            pd.Print();
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // DataGridView verilerini yazdır
            int yPos = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int height = row.Height;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    e.Graphics.DrawString(cell.Value.ToString(), dataGridView1.Font,
                        Brushes.Black, new RectangleF(cell.ContentBounds.Left + 10, 
                        yPos + 10, cell.ContentBounds.Width - 10, cell.ContentBounds.Height - 10));
                }
                yPos += height;
            }
        }
        private void PrintDataGridView(DataGridView dataGridView)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) =>
            {
                Bitmap bitmap = new Bitmap(dataGridView.Width, dataGridView.Height);
                dataGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView.Width, dataGridView.Height));
                e.Graphics.DrawImage(bitmap, 0, 0);
            };

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void buttonYazdir_Click(object sender, EventArgs e)
        {
            PrintDataGridView(dataGridView1);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                MainFrm.getir(dataGridView1, "select * from recete_view Where ilac_ad like '%" + textBoxAra.Text + "%'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reçete kaydı yapılamadı: " + ex.Message);
            }
        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int recete_id = int.Parse(ReceteIdTxt.Text);

                con.ExecuteProc("recete_sil",
                 new NpgsqlParameter("p_recete_id", NpgsqlDbType.Integer) { Value = recete_id }
                 );
                MessageBox.Show("Recete kaydını silmeyi onaylıyor musunuz", "Bilgi", MessageBoxButtons.YesNo);
                MainFrm.getir(dataGridView1, "select * from recete_view;");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Recete silinemedi: " + ex.Message);
            }
            MainFrm.getir(dataGridView1, "select * from recete;");

        }
    }
}
