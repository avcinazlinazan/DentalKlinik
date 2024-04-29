
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

namespace DisKlinikYS.Forms
{
    public partial class FrmMain : Form
    {
        SqlHelper con = new SqlHelper();
        public FrmMain()
        {
            InitializeComponent();
        }
     
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hekim h = new Hekim();
            h.Show();
            this.Hide();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HastaFrm h = new HastaFrm();
            h.Show();
            this.Hide();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TedaviFrm h = new TedaviFrm();
            h.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            RandevuFrm h = new RandevuFrm();
            h.Show();
            this.Hide();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            RecetelerFrm h = new RecetelerFrm();
            h.Show();
            this.Hide();
        }
        public void getir(DataGridView dg, string query)
        {
            DataTable dt = new DataTable();
            dt = con.GetTable(query);
            dg.DataSource = dt;
        }

    
    }
}
