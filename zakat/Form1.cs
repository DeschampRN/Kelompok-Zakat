using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Globalization;

namespace zakat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lihatData();
        }

        MySqlConnection koneksi = new MySqlConnection("server=localhost;database=zakat;uid=root;pwd=;");

        public void lihatData()
        {
            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "select * from identitas";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

       

        private void button1_Click(object sender, EventArgs e)
        { 
           try
                {
                    koneksi.Open();

                    MySqlCommand cmd;
                    cmd = koneksi.CreateCommand();
                    cmd.CommandText = "UPDATE identitas SET NIK=@NIK, NAMA=@NAMA, JUMLAH_JIWA=@JUMLAH_JIWA, KUALITAS=@KUALITAS, TOTAL=@TOTAL, where ID=@ID";
                    cmd.Parameters.AddWithValue("@ID", textbox_id.Text);
                    cmd.Parameters.AddWithValue("@NIK", textbox_nik.Text);
                    cmd.Parameters.AddWithValue("@NAMA", textbox_nama.Text);
               //TANGGAL=@TANGGAL
                    //cmd.Parameters.AddWithValue("@TANGGAL", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@JUMLAH_JIWA", textbox_jiwa.Text);
                    cmd.Parameters.AddWithValue("@KUALITAS", textbox_jenis.Text);
                    cmd.Parameters.AddWithValue("@TOTAL", textbox_total.Text);
                   
                    MessageBox.Show("Data dengan NIK " + textbox_nik.Text + " berhasil diperbaharui");
                    cmd.ExecuteNonQuery();
                    textbox_id.Text = "";
                    textbox_nik.Text = "";
                    textbox_nama.Text = "";
                    //textbox_uang.Text = "";
                    textbox_total.Text = "0";
                    //textbox_kembalian.Text = "0";
                    lihatData();
                    koneksi.Close();
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.Message, "Pesan Error");
                }
                finally
                {
                    koneksi.Close();
                }
            
            
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            textbox_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textbox_nik.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textbox_nama.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textbox_jiwa.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textbox_jenis.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textbox_total.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                MySqlCommand cmd;
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "insert into identitas (ID,NIK,NAMA,TANGGAL,JUMLAH_JIWA,KUALITAS,TOTAL) values (@ID,@NIK,@NAMA,@TANGGAL,@JUMLAH_JIWA,@KUALITAS,@TOTAL)";
                cmd.Parameters.AddWithValue("@ID", textbox_id.Text);
                cmd.Parameters.AddWithValue("@NIK", textbox_nik.Text);
                cmd.Parameters.AddWithValue("@NAMA", textbox_nama.Text);
                cmd.Parameters.AddWithValue("@TANGGAL", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@JUMLAH_JIWA", textbox_jiwa.Text);
                cmd.Parameters.AddWithValue("@KUALITAS", textbox_jenis.Text);
                cmd.Parameters.AddWithValue("@TOTAL", textbox_total.Text);
                MessageBox.Show("Data berhasil ditambahkan");
                cmd.ExecuteNonQuery();
                textbox_id.Text = "";
                textbox_nik.Text = "";
                textbox_nama.Text = "";
                textbox_jiwa.Text = "";
                textbox_jenis.Text = "";
                textbox_total.Text = "";
                lihatData();
                koneksi.Close();
            }
            catch (Exception c)
            {
                MessageBox.Show("Upss, coba cek kembali. Ini errornya: " + c.Message, "Pesan Error");
               
            }
            finally
            {
                koneksi.Close();
            }
        }

        private void button_batal_Click(object sender, EventArgs e)
        {
            textbox_id.Text = "";
            textbox_nik.Text = "";
            textbox_nama.Text = "";
            textbox_jiwa.Text = "";
            textbox_jenis.Text = "";
            textbox_total.Text = "";
           
        }

        private void button_cek_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textbox_jenis.Text);
            int num2 = int.Parse(textbox_jiwa.Text);
            double total_bayar = num * num2 * 4.3;
            textbox_total.Text = total_bayar.ToString();
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "delete from identitas where ID=@ID";
            cmd.Parameters.AddWithValue("@ID", textbox_id.Text);
            cmd.Parameters.AddWithValue("@NIK", textbox_nik.Text);
            cmd.Parameters.AddWithValue("@NAMA", textbox_nama.Text);
            cmd.Parameters.AddWithValue("@TANGGAL", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@JUMLAH_JIWA", textbox_jiwa.Text);
            cmd.Parameters.AddWithValue("@KUALITAS", textbox_jenis.Text);
            cmd.Parameters.AddWithValue("@TOTAL", textbox_total.Text);
            MessageBox.Show(" Data berhasil dihapus");
            cmd.ExecuteNonQuery();
            textbox_id.Text = "";
            textbox_nik.Text = "";
            textbox_nama.Text = "";
            textbox_jiwa.Text = "";
            textbox_jenis.Text = "";
            textbox_total.Text = "";
            lihatData();
            koneksi.Close();
        }

       
    }
}
