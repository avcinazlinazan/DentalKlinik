namespace DisKlinikYS.Forms
{
    partial class Hekim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hekim));
            uzmancomboBox = new ComboBox();
            label5 = new Label();
            dhsoyadTxt = new TextBox();
            dhAdTxt = new TextBox();
            dhIdTxt = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            Idtxt = new Label();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            label1 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            button7 = new Button();
            buttonAra = new Button();
            textBoxAra = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // uzmancomboBox
            // 
            uzmancomboBox.BackColor = Color.OliveDrab;
            uzmancomboBox.ForeColor = Color.DimGray;
            uzmancomboBox.FormattingEnabled = true;
            uzmancomboBox.Items.AddRange(new object[] { "implant", "çekim", "kanal", "dolgu", "geçici dolgu", "kaplama", "takma diş" });
            uzmancomboBox.Location = new Point(171, 397);
            uzmancomboBox.Name = "uzmancomboBox";
            uzmancomboBox.Size = new Size(202, 23);
            uzmancomboBox.TabIndex = 70;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.LemonChiffon;
            label5.Location = new Point(14, 328);
            label5.Name = "label5";
            label5.Size = new Size(149, 30);
            label5.TabIndex = 69;
            label5.Text = "Hekimi Soydı";
            // 
            // dhsoyadTxt
            // 
            dhsoyadTxt.BackColor = Color.OliveDrab;
            dhsoyadTxt.BorderStyle = BorderStyle.FixedSingle;
            dhsoyadTxt.ForeColor = SystemColors.Info;
            dhsoyadTxt.Location = new Point(171, 339);
            dhsoyadTxt.Name = "dhsoyadTxt";
            dhsoyadTxt.Size = new Size(202, 23);
            dhsoyadTxt.TabIndex = 68;
            // 
            // dhAdTxt
            // 
            dhAdTxt.BackColor = Color.OliveDrab;
            dhAdTxt.BorderStyle = BorderStyle.FixedSingle;
            dhAdTxt.ForeColor = SystemColors.Info;
            dhAdTxt.Location = new Point(171, 286);
            dhAdTxt.Name = "dhAdTxt";
            dhAdTxt.Size = new Size(202, 23);
            dhAdTxt.TabIndex = 67;
            // 
            // dhIdTxt
            // 
            dhIdTxt.BackColor = Color.OliveDrab;
            dhIdTxt.BorderStyle = BorderStyle.FixedSingle;
            dhIdTxt.ForeColor = SystemColors.Info;
            dhIdTxt.Location = new Point(171, 225);
            dhIdTxt.Name = "dhIdTxt";
            dhIdTxt.Size = new Size(202, 23);
            dhIdTxt.TabIndex = 66;
            // 
            // button3
            // 
            button3.BackColor = Color.OliveDrab;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.DarkOrange;
            button3.Location = new Point(240, 475);
            button3.Name = "button3";
            button3.Size = new Size(94, 44);
            button3.TabIndex = 64;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.OliveDrab;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.DarkOrange;
            button2.Location = new Point(125, 475);
            button2.Name = "button2";
            button2.Size = new Size(109, 44);
            button2.TabIndex = 63;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.DarkOrange;
            button1.Location = new Point(24, 475);
            button1.Name = "button1";
            button1.Size = new Size(94, 44);
            button1.TabIndex = 62;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LemonChiffon;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(410, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(576, 358);
            dataGridView1.TabIndex = 61;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.LemonChiffon;
            label3.Location = new Point(11, 283);
            label3.Name = "label3";
            label3.Size = new Size(121, 30);
            label3.TabIndex = 59;
            label3.Text = "Hekim Adı";
            // 
            // Idtxt
            // 
            Idtxt.AutoSize = true;
            Idtxt.BackColor = Color.Transparent;
            Idtxt.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Idtxt.ForeColor = Color.LemonChiffon;
            Idtxt.Location = new Point(11, 214);
            Idtxt.Name = "Idtxt";
            Idtxt.Size = new Size(107, 30);
            Idtxt.TabIndex = 58;
            Idtxt.Text = "Hekim Id";
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(388, 145);
            label2.Name = "label2";
            label2.Size = new Size(195, 45);
            label2.TabIndex = 57;
            label2.Text = "DİŞ HEKİMİ";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(851, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.OliveDrab;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = Color.DarkOrange;
            button4.Location = new Point(24, 41);
            button4.Name = "button4";
            button4.Size = new Size(109, 44);
            button4.TabIndex = 15;
            button4.Text = "Anasayfa";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.ForeColor = Color.LemonChiffon;
            label1.Location = new Point(206, 30);
            label1.Name = "label1";
            label1.Size = new Size(565, 51);
            label1.TabIndex = 1;
            label1.Text = "DİŞ KLİNİĞİ YÖNETİM SİSTEMİ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.LemonChiffon;
            label4.Location = new Point(14, 377);
            label4.Name = "label4";
            label4.Size = new Size(109, 30);
            label4.TabIndex = 60;
            label4.Text = "Uzmanlık";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(996, 113);
            panel1.TabIndex = 56;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.AliceBlue;
            label7.Location = new Point(946, 40);
            label7.Name = "label7";
            label7.Size = new Size(40, 45);
            label7.TabIndex = 37;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Orange;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button7.ForeColor = Color.OrangeRed;
            button7.Location = new Point(891, 151);
            button7.Name = "button7";
            button7.Size = new Size(95, 39);
            button7.TabIndex = 73;
            button7.Text = "Yenile";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // buttonAra
            // 
            buttonAra.BackColor = Color.Orange;
            buttonAra.FlatStyle = FlatStyle.Flat;
            buttonAra.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonAra.ForeColor = Color.OrangeRed;
            buttonAra.Location = new Point(837, 151);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(48, 39);
            buttonAra.TabIndex = 72;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = false;
            buttonAra.Click += buttonAra_Click;
            // 
            // textBoxAra
            // 
            textBoxAra.BackColor = Color.LemonChiffon;
            textBoxAra.BorderStyle = BorderStyle.FixedSingle;
            textBoxAra.Location = new Point(690, 163);
            textBoxAra.Name = "textBoxAra";
            textBoxAra.Size = new Size(141, 23);
            textBoxAra.TabIndex = 71;
            // 
            // Hekim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(996, 576);
            Controls.Add(button7);
            Controls.Add(buttonAra);
            Controls.Add(textBoxAra);
            Controls.Add(uzmancomboBox);
            Controls.Add(label5);
            Controls.Add(dhsoyadTxt);
            Controls.Add(dhAdTxt);
            Controls.Add(dhIdTxt);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(Idtxt);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Hekim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hekim";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox uzmancomboBox;
        private Label label5;
        private TextBox dhsoyadTxt;
        private TextBox dhAdTxt;
        private TextBox dhIdTxt;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label Idtxt;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Label label2;
        private PictureBox pictureBox2;
        private Button button4;
        private Label label1;
        private Label label4;
        private Panel panel1;
        private Label label7;
        private Button button7;
        private Button buttonAra;
        private TextBox textBoxAra;
    }
}