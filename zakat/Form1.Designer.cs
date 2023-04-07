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
            this.textbox_id = new System.Windows.Forms.TextBox();
            this.textbox_nik = new System.Windows.Forms.TextBox();
            this.textbox_nama = new System.Windows.Forms.TextBox();
            this.textbox_jiwa = new System.Windows.Forms.TextBox();
            this.textbox_jenis = new System.Windows.Forms.TextBox();
            this.textbox_total = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textbox_cariid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ubah
            // 
            this.button_ubah.BackColor = System.Drawing.Color.Chartreuse;
            this.button_ubah.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ubah.Location = new System.Drawing.Point(12, 375);
            this.button_ubah.Name = "button_ubah";
            this.button_ubah.Size = new System.Drawing.Size(127, 28);
            this.button_ubah.TabIndex = 0;
            this.button_ubah.Text = "Ubah";
            this.button_ubah.UseVisualStyleBackColor = false;
            this.button_ubah.Click += new System.EventHandler(this.button_ubah_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.BackColor = System.Drawing.Color.Chartreuse;
            this.button_simpan.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.button_simpan.Location = new System.Drawing.Point(12, 422);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(127, 28);
            this.button_simpan.TabIndex = 1;
            this.button_simpan.Text = "SImpan";
            this.button_simpan.UseVisualStyleBackColor = false;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // button_batal
            // 
            this.button_batal.BackColor = System.Drawing.Color.Chartreuse;
            this.button_batal.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.button_batal.Location = new System.Drawing.Point(154, 375);
            this.button_batal.Name = "button_batal";
            this.button_batal.Size = new System.Drawing.Size(127, 28);
            this.button_batal.TabIndex = 2;
            this.button_batal.Text = "Batal";
            this.button_batal.UseVisualStyleBackColor = false;
            this.button_batal.Click += new System.EventHandler(this.button_batal_Click);
            // 
            // button_hapus
            // 
            this.button_hapus.BackColor = System.Drawing.Color.Chartreuse;
            this.button_hapus.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.button_hapus.Location = new System.Drawing.Point(154, 422);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(127, 28);
            this.button_hapus.TabIndex = 3;
            this.button_hapus.Text = "Hapus";
            this.button_hapus.UseVisualStyleBackColor = false;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
            // 
            // button_cek
            // 
            this.button_cek.BackColor = System.Drawing.Color.Chartreuse;
            this.button_cek.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.button_cek.Location = new System.Drawing.Point(309, 375);
            this.button_cek.Name = "button_cek";
            this.button_cek.Size = new System.Drawing.Size(85, 75);
            this.button_cek.TabIndex = 4;
            this.button_cek.Text = "Cek Total";
            this.button_cek.UseVisualStyleBackColor = false;
            this.button_cek.Click += new System.EventHandler(this.button_cek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(40, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(40, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "NIK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(40, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jumlah Jiwa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(40, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jenis Beras";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(40, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
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
            this.textbox_id.Location = new System.Drawing.Point(182, 80);
            this.textbox_id.Name = "textbox_id";
            this.textbox_id.ReadOnly = true;
            this.textbox_id.Size = new System.Drawing.Size(200, 22);
            this.textbox_id.TabIndex = 14;
            // 
            // textbox_nik
            // 
            this.textbox_nik.Location = new System.Drawing.Point(182, 113);
            this.textbox_nik.Name = "textbox_nik";
            this.textbox_nik.Size = new System.Drawing.Size(200, 22);
            this.textbox_nik.TabIndex = 15;
            // 
            // textbox_nama
            // 
            this.textbox_nama.Location = new System.Drawing.Point(182, 145);
            this.textbox_nama.Name = "textbox_nama";
            this.textbox_nama.Size = new System.Drawing.Size(200, 22);
            this.textbox_nama.TabIndex = 16;
            // 
            // textbox_jiwa
            // 
            this.textbox_jiwa.Location = new System.Drawing.Point(182, 177);
            this.textbox_jiwa.Name = "textbox_jiwa";
            this.textbox_jiwa.Size = new System.Drawing.Size(200, 22);
            this.textbox_jiwa.TabIndex = 17;
            // 
            // textbox_jenis
            // 
            this.textbox_jenis.Location = new System.Drawing.Point(182, 213);
            this.textbox_jenis.Name = "textbox_jenis";
            this.textbox_jenis.Size = new System.Drawing.Size(200, 22);
            this.textbox_jenis.TabIndex = 18;
            // 
            // textbox_total
            // 
            this.textbox_total.Location = new System.Drawing.Point(182, 252);
            this.textbox_total.Name = "textbox_total";
            this.textbox_total.Size = new System.Drawing.Size(200, 22);
            this.textbox_total.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(182, 300);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(40, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tanggal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbox_cariid
            // 
            this.textbox_cariid.Location = new System.Drawing.Point(416, 503);
            this.textbox_cariid.Name = "textbox_cariid";
            this.textbox_cariid.Size = new System.Drawing.Size(100, 22);
            this.textbox_cariid.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1487, 538);
            this.Controls.Add(this.textbox_cariid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.TextBox textbox_id;
        private System.Windows.Forms.TextBox textbox_nik;
        private System.Windows.Forms.TextBox textbox_nama;
        private System.Windows.Forms.TextBox textbox_jiwa;
        private System.Windows.Forms.TextBox textbox_jenis;
        private System.Windows.Forms.TextBox textbox_total;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textbox_cariid;
    }
}

