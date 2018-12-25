using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SmartMinimarketKasir
{
    public partial class Form2 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd;
        MySqlDataReader myread;
        int totalpenjualan;
        String barang;
        int id, jumlah, harga;

        public Form2()
        {
            InitializeComponent();
            totalpenjualan = 0;
            label1.Text = label1.Text + " " + DateTime.Now.ToString("dd/MM/yyyy");
            Connect();
            Getdata();
        }

        protected void Connect()
        {
            string constring = @"server=localhost;userid=root;password=;database=smartmini";

            try
            {
                conn = new MySqlConnection(constring);
                conn.Open();
                conn.Close();
            }
            catch (MySqlException e)
            {
                conn = null;
            }
        }

        protected void Getdata()
        {
            String date = DateTime.Now.ToString("yyyy/MM/dd");
            //MessageBox.Show(date);
            int i = 0;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT pesanan.id_user,pesanan.jumlah_pesanan,barang.nama_barang,barang.harga FROM pelanggan left join pesanan on pelanggan.id_user = pesanan.id_user left join barang on pesanan.id_barang = barang.id_barang WHERE pelanggan.tanggal = \"";
            cmd.CommandText += date;
            cmd.CommandText += "\"";
            myread = cmd.ExecuteReader();
            while (myread.Read())
            {
                id = Convert.ToInt32(myread[0]);
                jumlah = Convert.ToInt32(myread[1]);
                barang = Convert.ToString(myread[2]);
                harga = Convert.ToInt32(myread[3]);
                
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = id;
                dataGridView1.Rows[i].Cells[1].Value = barang;
                dataGridView1.Rows[i].Cells[2].Value = jumlah;
                dataGridView1.Rows[i].Cells[3].Value = harga * jumlah;
                totalpenjualan += harga * jumlah;
                i++;
            }
            dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells[0].Value = "";
            dataGridView1.Rows[i].Cells[1].Value = "";
            dataGridView1.Rows[i].Cells[2].Value = "Total : ";
            dataGridView1.Rows[i].Cells[3].Value = totalpenjualan;

            conn.Close();
        }
    }
}
