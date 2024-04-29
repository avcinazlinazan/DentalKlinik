namespace DisKlinikYS.Forms
{
    partial class HastaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaFrm));
            label1 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            label2 = new Label();
            Idtxt = new Label();
            label3 = new Label();
            label4 = new Label();
            hasIdTxt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            CinsiyetcomboBox = new ComboBox();
            label8 = new Label();
            AdTxt = new TextBox();
            SoyadTxt = new TextBox();
            label9 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBoxAra = new TextBox();
            button6 = new Button();
            button7 = new Button();
            TelTxt = new TextBox();
            EpostaTxt = new TextBox();
            label10 = new Label();
            DogTPicker = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1044, 100);
            panel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.AliceBlue;
            label7.Location = new Point(1002, 28);
            label7.Name = "label7";
            label7.Size = new Size(40, 45);
            label7.TabIndex = 36;
            label7.Text = "X";
            label7.Click += label7_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(920, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 95);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Orange;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = Color.OrangeRed;
            button4.Location = new Point(12, 36);
            button4.Name = "button4";
            button4.Size = new Size(95, 39);
            button4.TabIndex = 24;
            button4.Text = "Anasayfa";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(72, 109);
            label2.Name = "label2";
            label2.Size = new Size(243, 45);
            label2.TabIndex = 3;
            label2.Text = "HASTA LİSTESİ";
            // 
            // Idtxt
            // 
            Idtxt.AutoSize = true;
            Idtxt.BackColor = Color.Transparent;
            Idtxt.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Idtxt.ForeColor = Color.LemonChiffon;
            Idtxt.Location = new Point(447, 238);
            Idtxt.Name = "Idtxt";
            Idtxt.Size = new Size(151, 30);
            Idtxt.TabIndex = 5;
            Idtxt.Text = "Diş Hekimi Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(12, 173);
            label3.Name = "label3";
            label3.Size = new Size(100, 30);
            label3.TabIndex = 6;
            label3.Text = "Hasta Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Orange;
            label4.Location = new Point(12, 207);
            label4.Name = "label4";
            label4.Size = new Size(48, 30);
            label4.TabIndex = 7;
            label4.Text = "Adı";
            // 
            // hasIdTxt
            // 
            hasIdTxt.BackColor = Color.LemonChiffon;
            hasIdTxt.BorderStyle = BorderStyle.FixedSingle;
            hasIdTxt.Location = new Point(184, 173);
            hasIdTxt.Name = "hasIdTxt";
            hasIdTxt.Size = new Size(202, 23);
            hasIdTxt.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Orange;
            label5.Location = new Point(12, 296);
            label5.Name = "label5";
            label5.Size = new Size(152, 30);
            label5.TabIndex = 9;
            label5.Text = "Doğum Tarihi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Orange;
            label6.Location = new Point(12, 248);
            label6.Name = "label6";
            label6.Size = new Size(82, 30);
            label6.TabIndex = 10;
            label6.Text = "Soyadı";
            // 
            // CinsiyetcomboBox
            // 
            CinsiyetcomboBox.BackColor = Color.LemonChiffon;
            CinsiyetcomboBox.FormattingEnabled = true;
            CinsiyetcomboBox.Items.AddRange(new object[] { "k", "e" });
            CinsiyetcomboBox.Location = new Point(184, 346);
            CinsiyetcomboBox.Name = "CinsiyetcomboBox";
            CinsiyetcomboBox.Size = new Size(202, 23);
            CinsiyetcomboBox.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.Orange;
            label8.Location = new Point(17, 346);
            label8.Name = "label8";
            label8.Size = new Size(101, 30);
            label8.TabIndex = 13;
            label8.Text = "Cinsiyeti";
            // 
            // AdTxt
            // 
            AdTxt.BackColor = Color.LemonChiffon;
            AdTxt.BorderStyle = BorderStyle.FixedSingle;
            AdTxt.Location = new Point(184, 214);
            AdTxt.Name = "AdTxt";
            AdTxt.Size = new Size(202, 23);
            AdTxt.TabIndex = 14;
            // 
            // SoyadTxt
            // 
            SoyadTxt.BackColor = Color.LemonChiffon;
            SoyadTxt.BorderStyle = BorderStyle.FixedSingle;
            SoyadTxt.Location = new Point(184, 255);
            SoyadTxt.Name = "SoyadTxt";
            SoyadTxt.Size = new Size(202, 23);
            SoyadTxt.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.Orange;
            label9.Location = new Point(12, 394);
            label9.Name = "label9";
            label9.Size = new Size(88, 30);
            label9.TabIndex = 19;
            label9.Text = "Telefon";
            // 
            // button3
            // 
            button3.BackColor = Color.LemonChiffon;
            button3.FlatAppearance.MouseOverBackColor = Color.Orange;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.DarkOrange;
            button3.Location = new Point(327, 501);
            button3.Name = "button3";
            button3.Size = new Size(45, 39);
            button3.TabIndex = 23;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LemonChiffon;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.DarkOrange;
            button2.Location = new Point(226, 501);
            button2.Name = "button2";
            button2.Size = new Size(95, 39);
            button2.TabIndex = 22;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LemonChiffon;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.DarkOrange;
            button1.Location = new Point(138, 501);
            button1.Name = "button1";
            button1.Size = new Size(82, 39);
            button1.TabIndex = 21;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.LemonChiffon;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(392, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(640, 367);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBoxAra
            // 
            textBoxAra.BackColor = Color.LemonChiffon;
            textBoxAra.BorderStyle = BorderStyle.FixedSingle;
            textBoxAra.Location = new Point(736, 121);
            textBoxAra.Name = "textBoxAra";
            textBoxAra.Size = new Size(141, 23);
            textBoxAra.TabIndex = 28;
            // 
            // button6
            // 
            button6.BackColor = Color.Orange;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button6.ForeColor = Color.OrangeRed;
            button6.Location = new Point(883, 109);
            button6.Name = "button6";
            button6.Size = new Size(48, 39);
            button6.TabIndex = 29;
            button6.Text = "Ara";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Orange;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button7.ForeColor = Color.OrangeRed;
            button7.Location = new Point(937, 109);
            button7.Name = "button7";
            button7.Size = new Size(95, 39);
            button7.TabIndex = 30;
            button7.Text = "Yenile";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // TelTxt
            // 
            TelTxt.BackColor = Color.LemonChiffon;
            TelTxt.BorderStyle = BorderStyle.FixedSingle;
            TelTxt.Location = new Point(184, 394);
            TelTxt.Name = "TelTxt";
            TelTxt.Size = new Size(202, 23);
            TelTxt.TabIndex = 31;
            // 
            // EpostaTxt
            // 
            EpostaTxt.BackColor = Color.LemonChiffon;
            EpostaTxt.BorderStyle = BorderStyle.FixedSingle;
            EpostaTxt.Location = new Point(184, 447);
            EpostaTxt.Name = "EpostaTxt";
            EpostaTxt.Size = new Size(202, 23);
            EpostaTxt.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.Orange;
            label10.Location = new Point(12, 437);
            label10.Name = "label10";
            label10.Size = new Size(83, 30);
            label10.TabIndex = 33;
            label10.Text = "Eposta";
            // 
            // DogTPicker
            // 
            DogTPicker.CalendarForeColor = Color.LemonChiffon;
            DogTPicker.CalendarMonthBackground = SystemColors.Info;
            DogTPicker.CalendarTitleBackColor = Color.Firebrick;
            DogTPicker.CalendarTrailingForeColor = Color.Blue;
            DogTPicker.Location = new Point(186, 303);
            DogTPicker.Name = "DogTPicker";
            DogTPicker.Size = new Size(200, 23);
            DogTPicker.TabIndex = 34;
            // 
            // HastaFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1044, 563);
            Controls.Add(DogTPicker);
            Controls.Add(label10);
            Controls.Add(EpostaTxt);
            Controls.Add(TelTxt);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(textBoxAra);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(SoyadTxt);
            Controls.Add(AdTxt);
            Controls.Add(label8);
            Controls.Add(CinsiyetcomboBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(hasIdTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Idtxt);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HastaFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaFrm";
            Load += HastaFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label Idtxt;
        private Label label3;
        private Label label4;
        private TextBox hasIdTxt;
        private Label label5;
        private Label label6;
        private ComboBox CinsiyetcomboBox;
        private Label label8;
        private TextBox AdTxt;
        private TextBox SoyadTxt;
        private Label label9;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBoxAra;
        private Button button6;
        private Button button7;
        private TextBox TelTxt;
        private TextBox EpostaTxt;
        private Label label10;
        private DateTimePicker DogTPicker;
        private Label label7;
        private PictureBox pictureBox2;
    }
}