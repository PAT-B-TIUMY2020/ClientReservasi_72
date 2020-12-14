
namespace ClientReservasi_072
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
            this.IdReservasi = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.Label();
            this.NoTelfon = new System.Windows.Forms.Label();
            this.JumlahPemesanan = new System.Windows.Forms.Label();
            this.IDLokasi = new System.Windows.Forms.Label();
            this.btSimpan = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxNoTlf = new System.Windows.Forms.TextBox();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.textBoxIDLokasi = new System.Windows.Forms.TextBox();
            this.btHapus = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btCleare = new System.Windows.Forms.Button();
            this.dtPemesanan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // IdReservasi
            // 
            this.IdReservasi.AutoSize = true;
            this.IdReservasi.Location = new System.Drawing.Point(41, 51);
            this.IdReservasi.Name = "IdReservasi";
            this.IdReservasi.Size = new System.Drawing.Size(86, 17);
            this.IdReservasi.TabIndex = 0;
            this.IdReservasi.Text = "Id Reservasi";
            this.IdReservasi.Click += new System.EventHandler(this.IdReservasi_Click);
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(41, 97);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(45, 17);
            this.Nama.TabIndex = 1;
            this.Nama.Text = "Nama";
            // 
            // NoTelfon
            // 
            this.NoTelfon.AutoSize = true;
            this.NoTelfon.Location = new System.Drawing.Point(41, 155);
            this.NoTelfon.Name = "NoTelfon";
            this.NoTelfon.Size = new System.Drawing.Size(70, 17);
            this.NoTelfon.TabIndex = 2;
            this.NoTelfon.Text = "No Telfon";
            // 
            // JumlahPemesanan
            // 
            this.JumlahPemesanan.AutoSize = true;
            this.JumlahPemesanan.Location = new System.Drawing.Point(41, 221);
            this.JumlahPemesanan.Name = "JumlahPemesanan";
            this.JumlahPemesanan.Size = new System.Drawing.Size(132, 17);
            this.JumlahPemesanan.TabIndex = 3;
            this.JumlahPemesanan.Text = "Jumlah Pemesanan";
            // 
            // IDLokasi
            // 
            this.IDLokasi.AutoSize = true;
            this.IDLokasi.Location = new System.Drawing.Point(41, 276);
            this.IDLokasi.Name = "IDLokasi";
            this.IDLokasi.Size = new System.Drawing.Size(66, 17);
            this.IDLokasi.TabIndex = 4;
            this.IDLokasi.Text = "ID Lokasi";
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(676, 51);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(75, 23);
            this.btSimpan.TabIndex = 5;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(260, 51);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(255, 22);
            this.textBoxID.TabIndex = 6;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(260, 97);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(255, 22);
            this.textBoxNama.TabIndex = 7;
            // 
            // textBoxNoTlf
            // 
            this.textBoxNoTlf.Location = new System.Drawing.Point(260, 150);
            this.textBoxNoTlf.Name = "textBoxNoTlf";
            this.textBoxNoTlf.Size = new System.Drawing.Size(255, 22);
            this.textBoxNoTlf.TabIndex = 8;
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Location = new System.Drawing.Point(260, 216);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(255, 22);
            this.textBoxJumlah.TabIndex = 9;
            // 
            // textBoxIDLokasi
            // 
            this.textBoxIDLokasi.Location = new System.Drawing.Point(260, 273);
            this.textBoxIDLokasi.Name = "textBoxIDLokasi";
            this.textBoxIDLokasi.Size = new System.Drawing.Size(255, 22);
            this.textBoxIDLokasi.TabIndex = 10;
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(676, 120);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(75, 23);
            this.btHapus.TabIndex = 11;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(676, 193);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 12;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            // 
            // btCleare
            // 
            this.btCleare.Location = new System.Drawing.Point(676, 276);
            this.btCleare.Name = "btCleare";
            this.btCleare.Size = new System.Drawing.Size(75, 23);
            this.btCleare.TabIndex = 13;
            this.btCleare.Text = "Cleare";
            this.btCleare.UseVisualStyleBackColor = true;
            // 
            // dtPemesanan
            // 
            this.dtPemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPemesanan.Location = new System.Drawing.Point(100, 338);
            this.dtPemesanan.Name = "dtPemesanan";
            this.dtPemesanan.RowHeadersWidth = 51;
            this.dtPemesanan.RowTemplate.Height = 24;
            this.dtPemesanan.Size = new System.Drawing.Size(623, 216);
            this.dtPemesanan.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.dtPemesanan);
            this.Controls.Add(this.btCleare);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.textBoxIDLokasi);
            this.Controls.Add(this.textBoxJumlah);
            this.Controls.Add(this.textBoxNoTlf);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.IDLokasi);
            this.Controls.Add(this.JumlahPemesanan);
            this.Controls.Add(this.NoTelfon);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.IdReservasi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdReservasi;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label NoTelfon;
        private System.Windows.Forms.Label JumlahPemesanan;
        private System.Windows.Forms.Label IDLokasi;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNoTlf;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.TextBox textBoxIDLokasi;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btCleare;
        private System.Windows.Forms.DataGridView dtPemesanan;
    }
}

