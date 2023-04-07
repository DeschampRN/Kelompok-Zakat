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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        MySqlConnection koneksi = new MySqlConnection("server=localhost;database=test;uid=root;pwd=;");


        private void Form2_Load(object sender, EventArgs e)
        {
            textbox_user.Text = "";
            textbox_pass.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

                MySqlCommand cmd;
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "select * from admin where username=@username and password=@password";
                cmd.Parameters.AddWithValue("@username", textbox_user.Text);
                cmd.Parameters.AddWithValue("@password", textbox_pass.Text);
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                adapter.Fill(ds);
                if (ds.Rows.Count > 0)
                    {
                    MessageBox.Show("Login berhasil");
                    Form1 f =  new Form1();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                    }
                else
                    {
                    MessageBox.Show("Password atau Username salah. Silahkan di coba kembali.","peringatan");
                    }
            cmd.Parameters.Clear();
            koneksi.Close();
                }
                catch (Exception c)
                {
                    MessageBox.Show("Password atau Username salah. Silahkan di coba kembali.", "Pesan Error");
                }
                finally
                {
                    koneksi.Close();
                }
        }
    }
}

