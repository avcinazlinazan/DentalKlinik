namespace DisKlinikYS.Forms
{
    partial class TedaviFrm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TedaviFrm));
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            AciklamaTxt = new TextBox();
            label3 = new Label();
            fiyatTxt = new TextBox();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            label2 = new Label();
            button4 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            pictureBox6 = new PictureBox();
            textBoxAra = new TextBox();
            buttonAra = new Button();
            button7 = new Button();
            label5 = new Label();
            randevucomboBox = new ComboBox();
            label6 = new Label();
            TedaviPicker = new DateTimePicker();
            label8 = new Label();
            islemcomboBox = new ComboBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Orange;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.LemonChiffon;
            button3.Location = new Point(252, 486);
            button3.Name = "button3";
            button3.Size = new Size(82, 39);
            button3.TabIndex = 29;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.LemonChiffon;
            button2.Location = new Point(143, 486);
            button2.Name = "button2";
            button2.Size = new Size(95, 39);
            button2.TabIndex = 28;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.LemonChiffon;
            button1.Location = new Point(47, 486);
            button1.Name = "button1";
            button1.Size = new Size(82, 39);
            button1.TabIndex = 27;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.LemonChiffon;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(461, 161);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(734, 361);
            dataGridView1.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(54, 322);
            label4.Name = "label4";
            label4.Size = new Size(107, 30);
            label4.TabIndex = 23;
            label4.Text = "Açıklama";
            // 
            // AciklamaTxt
            // 
            AciklamaTxt.BackColor = Color.LemonChiffon;
            AciklamaTxt.BorderStyle = BorderStyle.FixedSingle;
            AciklamaTxt.ForeColor = Color.DimGray;
            AciklamaTxt.Location = new Point(235, 332);
            AciklamaTxt.Name = "AciklamaTxt";
            AciklamaTxt.Size = new Size(202, 23);
            AciklamaTxt.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(54, 227);
            label3.Name = "label3";
            label3.Size = new Size(166, 30);
            label3.TabIndex = 21;
            label3.Text = "Randevu Tarihi";
            // 
            // fiyatTxt
            // 
            fiyatTxt.BackColor = Color.LemonChiffon;
            fiyatTxt.BorderStyle = BorderStyle.FixedSingle;
            fiyatTxt.ForeColor = Color.DimGray;
            fiyatTxt.Location = new Point(235, 365);
            fiyatTxt.Name = "fiyatTxt";
            fiyatTxt.Size = new Size(202, 23);
            fiyatTxt.TabIndex = 18;
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
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(473, 113);
            label2.Name = "label2";
            label2.Size = new Size(132, 45);
            label2.TabIndex = 17;
            label2.Text = "TEDAVİ";
            // 
            // button4
            // 
            button4.BackColor = Color.DarkOrange;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = Color.LemonChiffon;
            button4.Location = new Point(21, 36);
            button4.Name = "button4";
            button4.Size = new Size(95, 39);
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
            label1.Location = new Point(252, 24);
            label1.Name = "label1";
            label1.Size = new Size(565, 51);
            label1.TabIndex = 1;
            label1.Text = "DİŞ KLİNİĞİ YÖNETİM SİSTEMİ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.DarkOrange;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1207, 100);
            panel1.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.AliceBlue;
            label7.Location = new Point(1165, 29);
            label7.Name = "label7";
            label7.Size = new Size(40, 45);
            label7.TabIndex = 17;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1083, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(76, 95);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // textBoxAra
            // 
            textBoxAra.BackColor = Color.LemonChiffon;
            textBoxAra.BorderStyle = BorderStyle.FixedSingle;
            textBoxAra.ForeColor = Color.DimGray;
            textBoxAra.Location = new Point(808, 122);
            textBoxAra.Name = "textBoxAra";
            textBoxAra.Size = new Size(202, 23);
            textBoxAra.TabIndex = 31;
            // 
            // buttonAra
            // 
            buttonAra.BackColor = Color.Orange;
            buttonAra.FlatStyle = FlatStyle.Flat;
            buttonAra.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonAra.ForeColor = Color.OrangeRed;
            buttonAra.Location = new Point(1036, 110);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(48, 39);
            buttonAra.TabIndex = 33;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = false;
            buttonAra.Click += buttonAra_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Orange;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button7.ForeColor = Color.OrangeRed;
            button7.Location = new Point(1099, 110);
            button7.Name = "button7";
            button7.Size = new Size(95, 39);
            button7.TabIndex = 34;
            button7.Text = "Yenile";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(54, 365);
            label5.Name = "label5";
            label5.Size = new Size(63, 30);
            label5.TabIndex = 35;
            label5.Text = "Fiyat";
            // 
            // randevucomboBox
            // 
            randevucomboBox.BackColor = Color.LemonChiffon;
            randevucomboBox.ForeColor = Color.DimGray;
            randevucomboBox.FormattingEnabled = true;
            randevucomboBox.Location = new Point(235, 227);
            randevucomboBox.Name = "randevucomboBox";
            randevucomboBox.Size = new Size(202, 23);
            randevucomboBox.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.DarkOrange;
            label6.Location = new Point(54, 404);
            label6.Name = "label6";
            label6.Size = new Size(95, 30);
            label6.TabIndex = 52;
            label6.Text = "İşlemler";
            // 
            // TedaviPicker
            // 
            TedaviPicker.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Strikeout);
            TedaviPicker.CalendarForeColor = Color.OldLace;
            TedaviPicker.CalendarMonthBackground = Color.PowderBlue;
            TedaviPicker.CalendarTitleBackColor = Color.PowderBlue;
            TedaviPicker.Format = DateTimePickerFormat.Short;
            TedaviPicker.Location = new Point(237, 285);
            TedaviPicker.Name = "TedaviPicker";
            TedaviPicker.Size = new Size(200, 23);
            TedaviPicker.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.DarkOrange;
            label8.Location = new Point(54, 278);
            label8.Name = "label8";
            label8.Size = new Size(143, 30);
            label8.TabIndex = 50;
            label8.Text = "Tedavi Tarihi";
            // 
            // islemcomboBox
            // 
            islemcomboBox.BackColor = Color.LemonChiffon;
            islemcomboBox.ForeColor = Color.DimGray;
            islemcomboBox.FormattingEnabled = true;
            islemcomboBox.Items.AddRange(new object[] { "implant", "çekim", "kanal", "dolgu", "geçici dolgu", "kaplama", "takma diş" });
            islemcomboBox.Location = new Point(237, 411);
            islemcomboBox.Name = "islemcomboBox";
            islemcomboBox.Size = new Size(202, 23);
            islemcomboBox.TabIndex = 54;
            // 
            // button5
            // 
            button5.BackColor = Color.Orange;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.ForeColor = Color.LemonChiffon;
            button5.Location = new Point(340, 486);
            button5.Name = "button5";
            button5.Size = new Size(82, 39);
            button5.TabIndex = 55;
            button5.Text = "Listele";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // TedaviFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1207, 537);
            Controls.Add(button5);
            Controls.Add(islemcomboBox);
            Controls.Add(randevucomboBox);
            Controls.Add(label6);
            Controls.Add(TedaviPicker);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(button7);
            Controls.Add(buttonAra);
            Controls.Add(textBoxAra);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(AciklamaTxt);
            Controls.Add(label3);
            Controls.Add(fiyatTxt);
            Controls.Add(label2);
            Controls.Add(panel1);
            ForeColor = Color.Gold;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TedaviFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TedaviFrm";
            Load += TedaviFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox AciklamaTxt;
        private Label label3;
        private TextBox fiyatTxt;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Label label2;
        private Button button4;
        private Label label1;
        private Panel panel1;
        private TextBox textBoxAra;
        private Button buttonAra;
        private Button button7;
        private Label label7;
        private PictureBox pictureBox6;
        private Label label5;
        private TextBox textBoxRandevu;
        private ComboBox randevucomboBox;
        private Label label6;
        private DateTimePicker TedaviPicker;
        private Label label8;
        private ComboBox islemcomboBox;
        private Button button5;
    }
}