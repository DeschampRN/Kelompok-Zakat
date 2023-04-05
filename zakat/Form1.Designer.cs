namespace zakat
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button_ubah = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_batal = new System.Windows.Forms.Button();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_cek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textbox_id = new System.Windows.Forms.TextBox();
            this.textbox_nik = new System.Windows.Forms.TextBox();
            this.textbox_nama = new System.Windows.Forms.TextBox();
            this.textbox_jiwa = new System.Windows.Forms.TextBox();
            this.textbox_jenis = new System.Windows.Forms.TextBox();
            this.textbox_total = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ubah
            // 
            this.button_ubah.Location = new System.Drawing.Point(12, 375);
            this.button_ubah.Name = "button_ubah";
            this.button_ubah.Size = new System.Drawing.Size(127, 28);
            this.button_ubah.TabIndex = 0;
            this.button_ubah.Text = "Ubah";
            this.button_ubah.UseVisualStyleBackColor = true;
            this.button_ubah.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.Location = new System.Drawing.Point(12, 422);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(127, 28);
            this.button_simpan.TabIndex = 1;
            this.button_simpan.Text = "SImpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // button_batal
            // 
            this.button_batal.Location = new System.Drawing.Point(154, 375);
            this.button_batal.Name = "button_batal";
            this.button_batal.Size = new System.Drawing.Size(127, 28);
            this.button_batal.TabIndex = 2;
            this.button_batal.Text = "Batal";
            this.button_batal.UseVisualStyleBackColor = true;
            this.button_batal.Click += new System.EventHandler(this.button_batal_Click);
            // 
            // button_hapus
            // 
            this.button_hapus.Location = new System.Drawing.Point(154, 422);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(127, 28);
            this.button_hapus.TabIndex = 3;
            this.button_hapus.Text = "Hapus";
            this.button_hapus.UseVisualStyleBackColor = true;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
            // 
            // button_cek
            // 
            this.button_cek.Location = new System.Drawing.Point(309, 375);
            this.button_cek.Name = "button_cek";
            this.button_cek.Size = new System.Drawing.Size(85, 75);
            this.button_cek.TabIndex = 4;
            this.button_cek.Text = "Cek Total";
            this.button_cek.UseVisualStyleBackColor = true;
            this.button_cek.Click += new System.EventHandler(this.button_cek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "NIK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jumlah Jiwa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jenis Beras";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(739, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(722, 397);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textbox_id
            // 
            this.textbox_id.Location = new System.Drawing.Point(209, 80);
            this.textbox_id.Name = "textbox_id";
            this.textbox_id.ReadOnly = true;
            this.textbox_id.Size = new System.Drawing.Size(136, 22);
            this.textbox_id.TabIndex = 14;
            // 
            // textbox_nik
            // 
            this.textbox_nik.Location = new System.Drawing.Point(209, 113);
            this.textbox_nik.Name = "textbox_nik";
            this.textbox_nik.Size = new System.Drawing.Size(136, 22);
            this.textbox_nik.TabIndex = 15;
            // 
            // textbox_nama
            // 
            this.textbox_nama.Location = new System.Drawing.Point(209, 145);
            this.textbox_nama.Name = "textbox_nama";
            this.textbox_nama.Size = new System.Drawing.Size(136, 22);
            this.textbox_nama.TabIndex = 16;
            // 
            // textbox_jiwa
            // 
            this.textbox_jiwa.Location = new System.Drawing.Point(209, 177);
            this.textbox_jiwa.Name = "textbox_jiwa";
            this.textbox_jiwa.Size = new System.Drawing.Size(136, 22);
            this.textbox_jiwa.TabIndex = 17;
            // 
            // textbox_jenis
            // 
            this.textbox_jenis.Location = new System.Drawing.Point(209, 213);
            this.textbox_jenis.Name = "textbox_jenis";
            this.textbox_jenis.Size = new System.Drawing.Size(136, 22);
            this.textbox_jenis.TabIndex = 18;
            // 
            // textbox_total
            // 
            this.textbox_total.Location = new System.Drawing.Point(209, 252);
            this.textbox_total.Name = "textbox_total";
            this.textbox_total.Size = new System.Drawing.Size(136, 22);
            this.textbox_total.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 334);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 462);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_cek);
            this.Controls.Add(this.textbox_total);
            this.Controls.Add(this.textbox_jenis);
            this.Controls.Add(this.textbox_jiwa);
            this.Controls.Add(this.textbox_nama);
            this.Controls.Add(this.textbox_nik);
            this.Controls.Add(this.textbox_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_hapus);
            this.Controls.Add(this.button_batal);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.button_ubah);
            this.Name = "Form1";
            this.Text = "za";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ubah;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_batal;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_cek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textbox_id;
        private System.Windows.Forms.TextBox textbox_nik;
        private System.Windows.Forms.TextBox textbox_nama;
        private System.Windows.Forms.TextBox textbox_jiwa;
        private System.Windows.Forms.TextBox textbox_jenis;
        private System.Windows.Forms.TextBox textbox_total;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

