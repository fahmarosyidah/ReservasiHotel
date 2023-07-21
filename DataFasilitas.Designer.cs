
namespace ReservasiHotel
{
    partial class DataFasilitas
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
            this.dataGridViewFasilitas = new System.Windows.Forms.DataGridView();
            this.idfasilitasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nokamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fasilitasKamarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet5 = new ReservasiHotel.HotelDataSet5();
            this.btnback = new System.Windows.Forms.Button();
            this.fasilitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet6 = new ReservasiHotel.HotelDataSet6();
            this.fasilitas_KamarTableAdapter = new ReservasiHotel.HotelDataSet5TableAdapters.Fasilitas_KamarTableAdapter();
            this.fasilitasTableAdapter = new ReservasiHotel.HotelDataSet6TableAdapters.FasilitasTableAdapter();
            this.hotelDataSet16 = new ReservasiHotel.HotelDataSet16();
            this.fasilitasKamarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fasilitas_KamarTableAdapter1 = new ReservasiHotel.HotelDataSet16TableAdapters.Fasilitas_KamarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFasilitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasilitasKamarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasilitasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasilitasKamarBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFasilitas
            // 
            this.dataGridViewFasilitas.AutoGenerateColumns = false;
            this.dataGridViewFasilitas.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewFasilitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFasilitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfasilitasDataGridViewTextBoxColumn,
            this.nokamarDataGridViewTextBoxColumn});
            this.dataGridViewFasilitas.DataSource = this.fasilitasKamarBindingSource1;
            this.dataGridViewFasilitas.Location = new System.Drawing.Point(92, 37);
            this.dataGridViewFasilitas.Name = "dataGridViewFasilitas";
            this.dataGridViewFasilitas.RowHeadersWidth = 51;
            this.dataGridViewFasilitas.RowTemplate.Height = 24;
            this.dataGridViewFasilitas.Size = new System.Drawing.Size(403, 197);
            this.dataGridViewFasilitas.TabIndex = 0;
            // 
            // idfasilitasDataGridViewTextBoxColumn
            // 
            this.idfasilitasDataGridViewTextBoxColumn.DataPropertyName = "id_fasilitas";
            this.idfasilitasDataGridViewTextBoxColumn.HeaderText = "id_fasilitas";
            this.idfasilitasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idfasilitasDataGridViewTextBoxColumn.Name = "idfasilitasDataGridViewTextBoxColumn";
            this.idfasilitasDataGridViewTextBoxColumn.Width = 125;
            // 
            // nokamarDataGridViewTextBoxColumn
            // 
            this.nokamarDataGridViewTextBoxColumn.DataPropertyName = "no_kamar";
            this.nokamarDataGridViewTextBoxColumn.HeaderText = "no_kamar";
            this.nokamarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nokamarDataGridViewTextBoxColumn.Name = "nokamarDataGridViewTextBoxColumn";
            this.nokamarDataGridViewTextBoxColumn.Width = 125;
            // 
            // fasilitasKamarBindingSource
            // 
            this.fasilitasKamarBindingSource.DataMember = "Fasilitas_Kamar";
            this.fasilitasKamarBindingSource.DataSource = this.hotelDataSet5;
            // 
            // hotelDataSet5
            // 
            this.hotelDataSet5.DataSetName = "HotelDataSet5";
            this.hotelDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.White;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.Black;
            this.btnback.Location = new System.Drawing.Point(524, 37);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(81, 44);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // fasilitasBindingSource
            // 
            this.fasilitasBindingSource.DataMember = "Fasilitas";
            this.fasilitasBindingSource.DataSource = this.hotelDataSet6;
            // 
            // hotelDataSet6
            // 
            this.hotelDataSet6.DataSetName = "HotelDataSet6";
            this.hotelDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fasilitas_KamarTableAdapter
            // 
            this.fasilitas_KamarTableAdapter.ClearBeforeFill = true;
            // 
            // fasilitasTableAdapter
            // 
            this.fasilitasTableAdapter.ClearBeforeFill = true;
            // 
            // hotelDataSet16
            // 
            this.hotelDataSet16.DataSetName = "HotelDataSet16";
            this.hotelDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fasilitasKamarBindingSource1
            // 
            this.fasilitasKamarBindingSource1.DataMember = "Fasilitas_Kamar";
            this.fasilitasKamarBindingSource1.DataSource = this.hotelDataSet16;
            // 
            // fasilitas_KamarTableAdapter1
            // 
            this.fasilitas_KamarTableAdapter1.ClearBeforeFill = true;
            // 
            // DataFasilitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(636, 396);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dataGridViewFasilitas);
            this.Name = "DataFasilitas";
            this.Text = "Data Fasilitas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFasilitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasilitasKamarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasilitasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasilitasKamarBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFasilitas;
        private System.Windows.Forms.Button btnback;
        private HotelDataSet5 hotelDataSet5;
        private System.Windows.Forms.BindingSource fasilitasKamarBindingSource;
        private HotelDataSet5TableAdapters.Fasilitas_KamarTableAdapter fasilitas_KamarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfasilitasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nokamarDataGridViewTextBoxColumn;
        private HotelDataSet6 hotelDataSet6;
        private System.Windows.Forms.BindingSource fasilitasBindingSource;
        private HotelDataSet6TableAdapters.FasilitasTableAdapter fasilitasTableAdapter;
        private HotelDataSet16 hotelDataSet16;
        private System.Windows.Forms.BindingSource fasilitasKamarBindingSource1;
        private HotelDataSet16TableAdapters.Fasilitas_KamarTableAdapter fasilitas_KamarTableAdapter1;
    }
}