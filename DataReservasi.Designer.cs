
namespace ReservasiHotel
{
    partial class DataReservasi
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
            this.dataGridViewReservasi = new System.Windows.Forms.DataGridView();
            this.hotelDataSet4 = new ReservasiHotel.HotelDataSet4();
            this.reservasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservasiTableAdapter = new ReservasiHotel.HotelDataSet4TableAdapters.ReservasiTableAdapter();
            this.idreservasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpetugasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtamuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalbookingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipekamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargasewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nokamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lamamenginapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalhargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReservasi
            // 
            this.dataGridViewReservasi.AutoGenerateColumns = false;
            this.dataGridViewReservasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservasi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idreservasiDataGridViewTextBoxColumn,
            this.idpetugasDataGridViewTextBoxColumn,
            this.idtamuDataGridViewTextBoxColumn,
            this.tanggalbookingDataGridViewTextBoxColumn,
            this.tipekamarDataGridViewTextBoxColumn,
            this.hargasewaDataGridViewTextBoxColumn,
            this.nokamarDataGridViewTextBoxColumn,
            this.lamamenginapDataGridViewTextBoxColumn,
            this.totalhargaDataGridViewTextBoxColumn});
            this.dataGridViewReservasi.DataSource = this.reservasiBindingSource;
            this.dataGridViewReservasi.Location = new System.Drawing.Point(35, 39);
            this.dataGridViewReservasi.Name = "dataGridViewReservasi";
            this.dataGridViewReservasi.RowHeadersWidth = 51;
            this.dataGridViewReservasi.RowTemplate.Height = 24;
            this.dataGridViewReservasi.Size = new System.Drawing.Size(1179, 150);
            this.dataGridViewReservasi.TabIndex = 0;
            // 
            // hotelDataSet4
            // 
            this.hotelDataSet4.DataSetName = "HotelDataSet4";
            this.hotelDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservasiBindingSource
            // 
            this.reservasiBindingSource.DataMember = "Reservasi";
            this.reservasiBindingSource.DataSource = this.hotelDataSet4;
            // 
            // reservasiTableAdapter
            // 
            this.reservasiTableAdapter.ClearBeforeFill = true;
            // 
            // idreservasiDataGridViewTextBoxColumn
            // 
            this.idreservasiDataGridViewTextBoxColumn.DataPropertyName = "id_reservasi";
            this.idreservasiDataGridViewTextBoxColumn.HeaderText = "id_reservasi";
            this.idreservasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idreservasiDataGridViewTextBoxColumn.Name = "idreservasiDataGridViewTextBoxColumn";
            this.idreservasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // idpetugasDataGridViewTextBoxColumn
            // 
            this.idpetugasDataGridViewTextBoxColumn.DataPropertyName = "id_petugas";
            this.idpetugasDataGridViewTextBoxColumn.HeaderText = "id_petugas";
            this.idpetugasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpetugasDataGridViewTextBoxColumn.Name = "idpetugasDataGridViewTextBoxColumn";
            this.idpetugasDataGridViewTextBoxColumn.Width = 125;
            // 
            // idtamuDataGridViewTextBoxColumn
            // 
            this.idtamuDataGridViewTextBoxColumn.DataPropertyName = "id_tamu";
            this.idtamuDataGridViewTextBoxColumn.HeaderText = "id_tamu";
            this.idtamuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtamuDataGridViewTextBoxColumn.Name = "idtamuDataGridViewTextBoxColumn";
            this.idtamuDataGridViewTextBoxColumn.Width = 125;
            // 
            // tanggalbookingDataGridViewTextBoxColumn
            // 
            this.tanggalbookingDataGridViewTextBoxColumn.DataPropertyName = "tanggal_booking";
            this.tanggalbookingDataGridViewTextBoxColumn.HeaderText = "tanggal_booking";
            this.tanggalbookingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalbookingDataGridViewTextBoxColumn.Name = "tanggalbookingDataGridViewTextBoxColumn";
            this.tanggalbookingDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipekamarDataGridViewTextBoxColumn
            // 
            this.tipekamarDataGridViewTextBoxColumn.DataPropertyName = "tipe_kamar";
            this.tipekamarDataGridViewTextBoxColumn.HeaderText = "tipe_kamar";
            this.tipekamarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipekamarDataGridViewTextBoxColumn.Name = "tipekamarDataGridViewTextBoxColumn";
            this.tipekamarDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargasewaDataGridViewTextBoxColumn
            // 
            this.hargasewaDataGridViewTextBoxColumn.DataPropertyName = "harga_sewa";
            this.hargasewaDataGridViewTextBoxColumn.HeaderText = "harga_sewa";
            this.hargasewaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargasewaDataGridViewTextBoxColumn.Name = "hargasewaDataGridViewTextBoxColumn";
            this.hargasewaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nokamarDataGridViewTextBoxColumn
            // 
            this.nokamarDataGridViewTextBoxColumn.DataPropertyName = "no_kamar";
            this.nokamarDataGridViewTextBoxColumn.HeaderText = "no_kamar";
            this.nokamarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nokamarDataGridViewTextBoxColumn.Name = "nokamarDataGridViewTextBoxColumn";
            this.nokamarDataGridViewTextBoxColumn.Width = 125;
            // 
            // lamamenginapDataGridViewTextBoxColumn
            // 
            this.lamamenginapDataGridViewTextBoxColumn.DataPropertyName = "lama_menginap";
            this.lamamenginapDataGridViewTextBoxColumn.HeaderText = "lama_menginap";
            this.lamamenginapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lamamenginapDataGridViewTextBoxColumn.Name = "lamamenginapDataGridViewTextBoxColumn";
            this.lamamenginapDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalhargaDataGridViewTextBoxColumn
            // 
            this.totalhargaDataGridViewTextBoxColumn.DataPropertyName = "total_harga";
            this.totalhargaDataGridViewTextBoxColumn.HeaderText = "total_harga";
            this.totalhargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalhargaDataGridViewTextBoxColumn.Name = "totalhargaDataGridViewTextBoxColumn";
            this.totalhargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1139, 210);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DataReservasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewReservasi);
            this.Name = "DataReservasi";
            this.Text = "Data Reservasi";
            this.Load += new System.EventHandler(this.DataReservasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReservasi;
        private HotelDataSet4 hotelDataSet4;
        private System.Windows.Forms.BindingSource reservasiBindingSource;
        private HotelDataSet4TableAdapters.ReservasiTableAdapter reservasiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreservasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpetugasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtamuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalbookingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipekamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargasewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nokamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lamamenginapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalhargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBack;
    }
}