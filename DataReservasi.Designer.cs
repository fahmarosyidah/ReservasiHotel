
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewReservasi = new System.Windows.Forms.DataGridView();
            this.idreservasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpetugasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtamuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalbookingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipekamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargasewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nokamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lamamenginapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalhargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet4 = new ReservasiHotel.HotelDataSet4();
            this.reservasiTableAdapter = new ReservasiHotel.HotelDataSet4TableAdapters.ReservasiTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet4)).BeginInit();
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
            this.dataGridViewReservasi.Size = new System.Drawing.Size(1179, 220);
            this.dataGridViewReservasi.TabIndex = 0;
            // 
            // idreservasiDataGridViewTextBoxColumn
            // 
            this.idreservasiDataGridViewTextBoxColumn.DataPropertyName = "id_reservasi";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idreservasiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idreservasiDataGridViewTextBoxColumn.HeaderText = "id_reservasi";
            this.idreservasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idreservasiDataGridViewTextBoxColumn.Name = "idreservasiDataGridViewTextBoxColumn";
            this.idreservasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // idpetugasDataGridViewTextBoxColumn
            // 
            this.idpetugasDataGridViewTextBoxColumn.DataPropertyName = "id_petugas";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idpetugasDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idpetugasDataGridViewTextBoxColumn.HeaderText = "id_petugas";
            this.idpetugasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpetugasDataGridViewTextBoxColumn.Name = "idpetugasDataGridViewTextBoxColumn";
            this.idpetugasDataGridViewTextBoxColumn.Width = 125;
            // 
            // idtamuDataGridViewTextBoxColumn
            // 
            this.idtamuDataGridViewTextBoxColumn.DataPropertyName = "id_tamu";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idtamuDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.idtamuDataGridViewTextBoxColumn.HeaderText = "id_tamu";
            this.idtamuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtamuDataGridViewTextBoxColumn.Name = "idtamuDataGridViewTextBoxColumn";
            this.idtamuDataGridViewTextBoxColumn.Width = 125;
            // 
            // tanggalbookingDataGridViewTextBoxColumn
            // 
            this.tanggalbookingDataGridViewTextBoxColumn.DataPropertyName = "tanggal_booking";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tanggalbookingDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.tanggalbookingDataGridViewTextBoxColumn.HeaderText = "tanggal_booking";
            this.tanggalbookingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalbookingDataGridViewTextBoxColumn.Name = "tanggalbookingDataGridViewTextBoxColumn";
            this.tanggalbookingDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipekamarDataGridViewTextBoxColumn
            // 
            this.tipekamarDataGridViewTextBoxColumn.DataPropertyName = "tipe_kamar";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tipekamarDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.tipekamarDataGridViewTextBoxColumn.HeaderText = "tipe_kamar";
            this.tipekamarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipekamarDataGridViewTextBoxColumn.Name = "tipekamarDataGridViewTextBoxColumn";
            this.tipekamarDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargasewaDataGridViewTextBoxColumn
            // 
            this.hargasewaDataGridViewTextBoxColumn.DataPropertyName = "harga_sewa";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.hargasewaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.hargasewaDataGridViewTextBoxColumn.HeaderText = "harga_sewa";
            this.hargasewaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargasewaDataGridViewTextBoxColumn.Name = "hargasewaDataGridViewTextBoxColumn";
            this.hargasewaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nokamarDataGridViewTextBoxColumn
            // 
            this.nokamarDataGridViewTextBoxColumn.DataPropertyName = "no_kamar";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nokamarDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.nokamarDataGridViewTextBoxColumn.HeaderText = "no_kamar";
            this.nokamarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nokamarDataGridViewTextBoxColumn.Name = "nokamarDataGridViewTextBoxColumn";
            this.nokamarDataGridViewTextBoxColumn.Width = 125;
            // 
            // lamamenginapDataGridViewTextBoxColumn
            // 
            this.lamamenginapDataGridViewTextBoxColumn.DataPropertyName = "lama_menginap";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.lamamenginapDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.lamamenginapDataGridViewTextBoxColumn.HeaderText = "lama_menginap";
            this.lamamenginapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lamamenginapDataGridViewTextBoxColumn.Name = "lamamenginapDataGridViewTextBoxColumn";
            this.lamamenginapDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalhargaDataGridViewTextBoxColumn
            // 
            this.totalhargaDataGridViewTextBoxColumn.DataPropertyName = "total_harga";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.totalhargaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.totalhargaDataGridViewTextBoxColumn.HeaderText = "total_harga";
            this.totalhargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalhargaDataGridViewTextBoxColumn.Name = "totalhargaDataGridViewTextBoxColumn";
            this.totalhargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservasiBindingSource
            // 
            this.reservasiBindingSource.DataMember = "Reservasi";
            this.reservasiBindingSource.DataSource = this.hotelDataSet4;
            // 
            // hotelDataSet4
            // 
            this.hotelDataSet4.DataSetName = "HotelDataSet4";
            this.hotelDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservasiTableAdapter
            // 
            this.reservasiTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1126, 287);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 44);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DataReservasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1257, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewReservasi);
            this.Name = "DataReservasi";
            this.Text = "Data Reservasi";
            this.Load += new System.EventHandler(this.DataReservasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReservasi;
        private HotelDataSet4 hotelDataSet4;
        private System.Windows.Forms.BindingSource reservasiBindingSource;
        private HotelDataSet4TableAdapters.ReservasiTableAdapter reservasiTableAdapter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn idreservasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpetugasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtamuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalbookingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipekamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargasewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nokamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lamamenginapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalhargaDataGridViewTextBoxColumn;
    }
}