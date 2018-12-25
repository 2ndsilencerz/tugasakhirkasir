namespace SmartMinimarketKasir
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jumlah_pesanan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_user,
            this.Nama_barang,
            this.Jumlah_pesanan,
            this.Total_harga});
            this.dataGridView1.Location = new System.Drawing.Point(16, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Laporan Penjualan Tanggal :";
            // 
            // ID_user
            // 
            this.ID_user.HeaderText = "ID_user";
            this.ID_user.Name = "ID_user";
            this.ID_user.ReadOnly = true;
            this.ID_user.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID_user.Width = 80;
            // 
            // Nama_barang
            // 
            this.Nama_barang.HeaderText = "Nama Barang";
            this.Nama_barang.Name = "Nama_barang";
            this.Nama_barang.ReadOnly = true;
            this.Nama_barang.Width = 150;
            // 
            // Jumlah_pesanan
            // 
            this.Jumlah_pesanan.HeaderText = "Jumlah";
            this.Jumlah_pesanan.Name = "Jumlah_pesanan";
            this.Jumlah_pesanan.ReadOnly = true;
            // 
            // Total_harga
            // 
            this.Total_harga.HeaderText = "Total_harga";
            this.Total_harga.Name = "Total_harga";
            this.Total_harga.ReadOnly = true;
            this.Total_harga.Width = 80;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 263);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Laporan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jumlah_pesanan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_harga;
    }
}