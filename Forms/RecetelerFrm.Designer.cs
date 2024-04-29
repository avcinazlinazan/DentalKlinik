namespace DisKlinikYS.Forms
{
    partial class RecetelerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecetelerFrm));
            button7 = new Button();
            textBoxAra = new TextBox();
            button4 = new Button();
            label1 = new Label();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            button6 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            DozajTxt = new TextBox();
            label3 = new Label();
            IlacAdiTxt = new TextBox();
            ReceteIdTxt = new TextBox();
            label2 = new Label();
            IlacAdi = new Label();
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            label10 = new Label();
            HastacomboBox = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            AciklamaTxt = new TextBox();
            TarihPicker = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            numericUpDown1 = new NumericUpDown();
            RandevucomboBox = new ComboBox();
            label9 = new Label();
            buttonYazdir = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackColor = Color.IndianRed;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button7.ForeColor = Color.Snow;
            button7.Location = new Point(1006, 172);
            button7.Name = "button7";
            button7.Size = new Size(95, 39);
            button7.TabIndex = 50;
            button7.Text = "Yenile";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // textBoxAra
            // 
            textBoxAra.BackColor = Color.MistyRose;
            textBoxAra.BorderStyle = BorderStyle.FixedSingle;
            textBoxAra.Location = new Point(715, 184);
            textBoxAra.Name = "textBoxAra";
            textBoxAra.Size = new Size(202, 23);
            textBoxAra.TabIndex = 48;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonHighlight;
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
            label1.ForeColor = Color.FloralWhite;
            label1.Location = new Point(252, 24);
            label1.Name = "label1";
            label1.Size = new Size(565, 51);
            label1.TabIndex = 1;
            label1.Text = "DİŞ KLİNİĞİ YÖNETİM SİSTEMİ";
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // button6
            // 
            button6.BackColor = Color.IndianRed;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button6.ForeColor = Color.Snow;
            button6.Location = new Point(943, 172);
            button6.Name = "button6";
            button6.Size = new Size(48, 39);
            button6.TabIndex = 49;
            button6.Text = "Ara";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(252, 523);
            button1.Name = "button1";
            button1.Size = new Size(82, 39);
            button1.TabIndex = 44;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(461, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(640, 361);
            dataGridView1.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(47, 387);
            label4.Name = "label4";
            label4.Size = new Size(171, 30);
            label4.TabIndex = 42;
            label4.Text = "Kullanım Sıklığı";
            // 
            // DozajTxt
            // 
            DozajTxt.BackColor = Color.MistyRose;
            DozajTxt.BorderStyle = BorderStyle.FixedSingle;
            DozajTxt.Location = new Point(233, 344);
            DozajTxt.Name = "DozajTxt";
            DozajTxt.Size = new Size(200, 23);
            DozajTxt.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(49, 344);
            label3.Name = "label3";
            label3.Size = new Size(71, 30);
            label3.TabIndex = 40;
            label3.Text = "Dozaj";
            // 
            // IlacAdiTxt
            // 
            IlacAdiTxt.BackColor = Color.MistyRose;
            IlacAdiTxt.BorderStyle = BorderStyle.FixedSingle;
            IlacAdiTxt.Location = new Point(231, 301);
            IlacAdiTxt.Name = "IlacAdiTxt";
            IlacAdiTxt.Size = new Size(202, 23);
            IlacAdiTxt.TabIndex = 39;
            // 
            // ReceteIdTxt
            // 
            ReceteIdTxt.BackColor = Color.MistyRose;
            ReceteIdTxt.BorderStyle = BorderStyle.FixedSingle;
            ReceteIdTxt.Location = new Point(231, 172);
            ReceteIdTxt.Name = "ReceteIdTxt";
            ReceteIdTxt.Size = new Size(202, 23);
            ReceteIdTxt.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(461, 172);
            label2.Name = "label2";
            label2.Size = new Size(131, 45);
            label2.TabIndex = 36;
            label2.Text = "REÇETE";
            // 
            // IlacAdi
            // 
            IlacAdi.AutoSize = true;
            IlacAdi.BackColor = Color.Transparent;
            IlacAdi.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            IlacAdi.ForeColor = Color.Firebrick;
            IlacAdi.Location = new Point(49, 301);
            IlacAdi.Name = "IlacAdi";
            IlacAdi.Size = new Size(90, 30);
            IlacAdi.TabIndex = 38;
            IlacAdi.Text = "İlaç Adı";
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 100);
            panel1.TabIndex = 35;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(988, 5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(76, 95);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.AliceBlue;
            label10.Location = new Point(1061, 28);
            label10.Name = "label10";
            label10.Size = new Size(40, 45);
            label10.TabIndex = 18;
            label10.Text = "X";
            label10.Click += label10_Click;
            // 
            // HastacomboBox
            // 
            HastacomboBox.BackColor = Color.MistyRose;
            HastacomboBox.FormattingEnabled = true;
            HastacomboBox.Location = new Point(231, 215);
            HastacomboBox.Name = "HastacomboBox";
            HastacomboBox.Size = new Size(202, 23);
            HastacomboBox.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(49, 215);
            label5.Name = "label5";
            label5.Size = new Size(123, 30);
            label5.TabIndex = 51;
            label5.Text = "Adı Soyadı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Firebrick;
            label6.Location = new Point(47, 172);
            label6.Name = "label6";
            label6.Size = new Size(109, 30);
            label6.TabIndex = 53;
            label6.Text = "Reçete Id";
            // 
            // AciklamaTxt
            // 
            AciklamaTxt.BackColor = Color.MistyRose;
            AciklamaTxt.BorderStyle = BorderStyle.FixedSingle;
            AciklamaTxt.Location = new Point(231, 430);
            AciklamaTxt.Name = "AciklamaTxt";
            AciklamaTxt.Size = new Size(202, 23);
            AciklamaTxt.TabIndex = 54;
            // 
            // TarihPicker
            // 
            TarihPicker.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Strikeout);
            TarihPicker.CalendarForeColor = Color.PaleTurquoise;
            TarihPicker.CalendarMonthBackground = Color.PowderBlue;
            TarihPicker.CalendarTitleBackColor = Color.PowderBlue;
            TarihPicker.Location = new Point(233, 258);
            TarihPicker.Name = "TarihPicker";
            TarihPicker.Size = new Size(200, 23);
            TarihPicker.TabIndex = 63;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label7.ForeColor = Color.Brown;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(49, 258);
            label7.Name = "label7";
            label7.Size = new Size(70, 30);
            label7.TabIndex = 62;
            label7.Text = "Tarihi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(49, 430);
            label8.Name = "label8";
            label8.Size = new Size(107, 30);
            label8.TabIndex = 64;
            label8.Text = "Açıklama";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.MistyRose;
            numericUpDown1.Location = new Point(231, 387);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(202, 23);
            numericUpDown1.TabIndex = 65;
            // 
            // RandevucomboBox
            // 
            RandevucomboBox.BackColor = Color.MistyRose;
            RandevucomboBox.FormattingEnabled = true;
            RandevucomboBox.Items.AddRange(new object[] { "onaylandı", "iptal edildi", "ertelendi" });
            RandevucomboBox.Location = new Point(231, 473);
            RandevucomboBox.Name = "RandevucomboBox";
            RandevucomboBox.Size = new Size(202, 23);
            RandevucomboBox.TabIndex = 66;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label9.ForeColor = Color.Brown;
            label9.ImeMode = ImeMode.NoControl;
            label9.Location = new Point(49, 473);
            label9.Name = "label9";
            label9.Size = new Size(84, 30);
            label9.TabIndex = 67;
            label9.Text = "Durum";
            // 
            // buttonYazdir
            // 
            buttonYazdir.BackColor = Color.IndianRed;
            buttonYazdir.FlatStyle = FlatStyle.Flat;
            buttonYazdir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonYazdir.ForeColor = SystemColors.ButtonHighlight;
            buttonYazdir.Location = new Point(768, 590);
            buttonYazdir.Name = "buttonYazdir";
            buttonYazdir.Size = new Size(95, 39);
            buttonYazdir.TabIndex = 20;
            buttonYazdir.Text = "Yazdir";
            buttonYazdir.UseVisualStyleBackColor = false;
            buttonYazdir.Click += buttonYazdir_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(351, 523);
            button2.Name = "button2";
            button2.Size = new Size(82, 39);
            button2.TabIndex = 68;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // RecetelerFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1110, 641);
            Controls.Add(button2);
            Controls.Add(buttonYazdir);
            Controls.Add(label9);
            Controls.Add(RandevucomboBox);
            Controls.Add(numericUpDown1);
            Controls.Add(label8);
            Controls.Add(TarihPicker);
            Controls.Add(label7);
            Controls.Add(AciklamaTxt);
            Controls.Add(label6);
            Controls.Add(HastacomboBox);
            Controls.Add(label5);
            Controls.Add(button7);
            Controls.Add(textBoxAra);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(DozajTxt);
            Controls.Add(label3);
            Controls.Add(IlacAdiTxt);
            Controls.Add(ReceteIdTxt);
            Controls.Add(label2);
            Controls.Add(IlacAdi);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RecetelerFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecetelerFrm";
            Load += RecetelerFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private TextBox textBoxAra;
        private Button button4;
        private Label label1;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Button button6;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox DozajTxt;
        private Label label3;
        private TextBox IlacAdiTxt;
        private TextBox ReceteIdTxt;
        private Label label2;
        private Label IlacAdi;
        private Panel panel1;
        private ComboBox HastacomboBox;
        private Label label5;
        private Label label6;
        private TextBox AciklamaTxt;
        private DateTimePicker TarihPicker;
        private Label label7;
        private Label label8;
        private NumericUpDown numericUpDown1;
        private ComboBox RandevucomboBox;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox6;
        private Button buttonYazdir;
        private Button button2;
    }
}