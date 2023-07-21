
namespace ReservasiHotel
{
    partial class FormDataHotel
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
            this.dataGridViewHotel = new System.Windows.Forms.DataGridView();
            this.namahotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet18 = new ReservasiHotel.HotelDataSet18();
            this.hotelDataSet10 = new ReservasiHotel.HotelDataSet10();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelTableAdapter = new ReservasiHotel.HotelDataSet10TableAdapters.HotelTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hotelTableAdapter1 = new ReservasiHotel.HotelDataSet18TableAdapters.HotelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHotel
            // 
            this.dataGridViewHotel.AutoGenerateColumns = false;
            this.dataGridViewHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namahotelDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.notelpDataGridViewTextBoxColumn});
            this.dataGridViewHotel.DataSource = this.hotelBindingSource1;
            this.dataGridViewHotel.Location = new System.Drawing.Point(53, 54);
            this.dataGridViewHotel.Name = "dataGridViewHotel";
            this.dataGridViewHotel.RowHeadersWidth = 51;
            this.dataGridViewHotel.RowTemplate.Height = 24;
            this.dataGridViewHotel.Size = new System.Drawing.Size(756, 150);
            this.dataGridViewHotel.TabIndex = 0;
            // 
            // namahotelDataGridViewTextBoxColumn
            // 
            this.namahotelDataGridViewTextBoxColumn.DataPropertyName = "nama_hotel";
            this.namahotelDataGridViewTextBoxColumn.HeaderText = "nama_hotel";
            this.namahotelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namahotelDataGridViewTextBoxColumn.Name = "namahotelDataGridViewTextBoxColumn";
            this.namahotelDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 125;
            // 
            // notelpDataGridViewTextBoxColumn
            // 
            this.notelpDataGridViewTextBoxColumn.DataPropertyName = "no_telp";
            this.notelpDataGridViewTextBoxColumn.HeaderText = "no_telp";
            this.notelpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notelpDataGridViewTextBoxColumn.Name = "notelpDataGridViewTextBoxColumn";
            this.notelpDataGridViewTextBoxColumn.Width = 125;
            // 
            // hotelBindingSource1
            // 
            this.hotelBindingSource1.DataMember = "Hotel";
            this.hotelBindingSource1.DataSource = this.hotelDataSet18;
            // 
            // hotelDataSet18
            // 
            this.hotelDataSet18.DataSetName = "HotelDataSet18";
            this.hotelDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelDataSet10
            // 
            this.hotelDataSet10.DataSetName = "HotelDataSet10";
            this.hotelDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataMember = "Hotel";
            this.hotelBindingSource.DataSource = this.hotelDataSet10;
            // 
            // hotelTableAdapter
            // 
            this.hotelTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // hotelTableAdapter1
            // 
            this.hotelTableAdapter1.ClearBeforeFill = true;
            // 
            // FormDataHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.dataGridViewHotel);
            this.Name = "FormDataHotel";
            this.Text = "Data Hotel";
            this.Load += new System.EventHandler(this.FormDataHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHotel;
        private HotelDataSet10 hotelDataSet10;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private HotelDataSet10TableAdapters.HotelTableAdapter hotelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn namahotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notelpDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private HotelDataSet18 hotelDataSet18;
        private System.Windows.Forms.BindingSource hotelBindingSource1;
        private HotelDataSet18TableAdapters.HotelTableAdapter hotelTableAdapter1;
    }
}