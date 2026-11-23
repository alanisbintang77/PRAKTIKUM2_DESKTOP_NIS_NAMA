namespace PRAKTIKUM2_DESKTOP_NIS_NAMA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label7 = new Label();
            kode = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            kategori = new DataGridViewTextBoxColumn();
            stok = new DataGridViewTextBoxColumn();
            satuan = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Batas = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Location = new Point(478, 308);
            button1.Name = "button1";
            button1.Size = new Size(123, 51);
            button1.TabIndex = 0;
            button1.Text = "Tambah";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Location = new Point(676, 308);
            button2.Name = "button2";
            button2.Size = new Size(123, 51);
            button2.TabIndex = 1;
            button2.Text = "Hapus";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 224, 192);
            button3.Location = new Point(863, 308);
            button3.Name = "button3";
            button3.Size = new Size(123, 51);
            button3.TabIndex = 2;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(44, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 23);
            textBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Stok Aman", "Kritis / Perlu Restock", "Kritis / Perlu Restock", "Stok Aman", "Stok Aman" });
            comboBox1.Location = new Point(44, 135);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 23);
            comboBox1.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(44, 179);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(255, 23);
            numericUpDown1.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(44, 311);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(255, 23);
            numericUpDown2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { kode, Nama, kategori, stok, satuan, Harga, Batas, Status });
            dataGridView1.Location = new Point(372, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(846, 240);
            dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 29);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 11;
            label1.Text = "Kode Produk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 73);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 12;
            label2.Text = "Nama Produk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 117);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 13;
            label3.Text = "Kategori";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 161);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 14;
            label4.Text = "Stok";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 205);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 15;
            label5.Text = "Satuan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 249);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 16;
            label6.Text = "Harga Satuan";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(42, 267);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(255, 23);
            textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(44, 223);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(255, 23);
            textBox4.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 293);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 19;
            label7.Text = "Batas Minimum";
            // 
            // kode
            // 
            kode.HeaderText = "Kode";
            kode.Name = "kode";
            kode.ReadOnly = true;
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama Produk";
            Nama.Name = "Nama";
            Nama.ReadOnly = true;
            // 
            // kategori
            // 
            kategori.HeaderText = "Kategori";
            kategori.Name = "kategori";
            kategori.ReadOnly = true;
            // 
            // stok
            // 
            stok.HeaderText = "Stok";
            stok.Name = "stok";
            stok.ReadOnly = true;
            // 
            // satuan
            // 
            satuan.HeaderText = "Satuan";
            satuan.Name = "satuan";
            satuan.ReadOnly = true;
            // 
            // Harga
            // 
            Harga.HeaderText = "Harga Satuan";
            Harga.Name = "Harga";
            Harga.ReadOnly = true;
            // 
            // Batas
            // 
            Batas.HeaderText = "Batas Minimum";
            Batas.Name = "Batas";
            Batas.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status yang Diharapkan";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 450);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Kategori";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label7;
        private DataGridViewTextBoxColumn kode;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn kategori;
        private DataGridViewTextBoxColumn stok;
        private DataGridViewTextBoxColumn satuan;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Batas;
        private DataGridViewTextBoxColumn Status;
    }
}
