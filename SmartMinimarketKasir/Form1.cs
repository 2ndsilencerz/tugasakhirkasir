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
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd;
        MySqlDataReader myread;
        String[] barang,id;
        int[] jumlah, harga, total;
        int totalbiaya;

        public Form1()
        {
            InitializeComponent();
            barang = new String[4];
            id = new String[4];
            jumlah = new int[4];
            harga = new int[4];
            total = new int[4];
            totalbiaya = 0;
            //Connect();
            //Getdata();
            //MessageBox.Show("Keranjang x sudah selesai", "Perhatian");
        }

        protected void execute(object sender, EventArgs e)
        {
            totalbiaya = 0;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            textBox2.Clear();
            textBox2.Refresh();
            textBox3.Clear();
            textBox4.Clear();
            textBox3.Refresh();
            textBox4.Refresh();
            Connect();
            Getdata();
            textBox2.Text = id[0];
            textBox1.Text = Convert.ToString(totalbiaya);
        }

        protected void kembali(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) - totalbiaya);
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
            int number = Convert.ToInt32(textBox5.Text);
            int i = 0;
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select pesanan.id_user, barang.nama_barang, pesanan.jumlah_pesanan, barang.harga from pelanggan left join pesanan on pelanggan.id_user = pesanan.id_user left join barang on pesanan.id_barang = barang.id_barang where no_keranjang = ";
            cmd.CommandText += number;
            myread = cmd.ExecuteReader();
            while (myread.Read())
            {
                id[i] = Convert.ToString(myread[0]);
                barang[i] = Convert.ToString(myread[1]);
                jumlah[i] = Convert.ToInt32(myread[2]);
                harga[i] = Convert.ToInt32(myread[3]);
                total[i] = harga[i] * jumlah[i];
                totalbiaya += harga[i] * jumlah[i];

                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = id[i];
                dataGridView1.Rows[i].Cells[1].Value = barang[i];
                dataGridView1.Rows[i].Cells[2].Value = jumlah[i];
                dataGridView1.Rows[i].Cells[3].Value = harga[i];
                dataGridView1.Rows[i].Cells[4].Value = total[i];
                i++;
            }
            conn.Close();
        }

        protected void laporanharian(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
