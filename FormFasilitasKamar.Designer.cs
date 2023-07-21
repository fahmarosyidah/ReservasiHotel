
namespace ReservasiHotel
{
    partial class FasilitasKamar
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
            this.dataGridViewFasilitasKamar = new System.Windows.Forms.DataGridView();
            this.idfasilitasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fasilitasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fasilitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet9 = new ReservasiHotel.HotelDataSet9();
            this.fasilitasTableAdapter = new ReservasiHotel.HotelDataSet9TableAdapters.FasilitasTableAdapter();
            this.btnDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFasilitasKamar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasilitasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFasilitasKamar
            // 
            this.dataGridViewFasilitasKamar.AutoGenerateColumns = false;
            this.dataGridViewFasilitasKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFasilitasKamar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfasilitasDataGridViewTextBoxColumn,
            this.fasilitasDataGridViewTextBoxColumn});
            this.dataGridViewFasilitasKamar.DataSource = this.fasilitasBindingSource;
            this.dataGridViewFasilitasKamar.Location = new System.Drawing.Point(67, 54);
            this.dataGridViewFasilitasKamar.Name = "dataGridViewFasilitasKamar";
            this.dataGridViewFasilitasKamar.RowHeadersWidth = 51;
            this.dataGridViewFasilitasKamar.RowTemplate.Height = 24;
            this.dataGridViewFasilitasKamar.Size = new System.Drawing.Size(663, 150);
            this.dataGridViewFasilitasKamar.TabIndex = 0;
            // 
            // idfasilitasDataGridViewTextBoxColumn
            // 
            this.idfasilitasDataGridViewTextBoxColumn.DataPropertyName = "id_fasilitas";
            this.idfasilitasDataGridViewTextBoxColumn.HeaderText = "id_fasilitas";
            this.idfasilitasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idfasilitasDataGridViewTextBoxColumn.Name = "idfasilitasDataGridViewTextBoxColumn";
            this.idfasilitasDataGridViewTextBoxColumn.Width = 115;
            // 
            // fasilitasDataGridViewTextBoxColumn
            // 
            this.fasilitasDataGridViewTextBoxColumn.DataPropertyName = "fasilitas";
            this.fasilitasDataGridViewTextBoxColumn.HeaderText = "fasilitas";
            this.fasilitasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fasilitasDataGridViewTextBoxColumn.Name = "fasilitasDataGridViewTextBoxColumn";
            this.fasilitasDataGridViewTextBoxColumn.Width = 500;
            // 
            // fasilitasBindingSource
            // 
            this.fasilitasBindingSource.DataMember = "Fasilitas";
            this.fasilitasBindingSource.DataSource = this.hotelDataSet9;
            // 
            // hotelDataSet9
            // 
            this.hotelDataSet9.DataSetName = "HotelDataSet9";
            this.hotelDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fasilitasTableAdapter
            // 
            this.fasilitasTableAdapter.ClearBeforeFill = true;
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(655, 229);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 41);
            this.btnDetail.TabIndex = 1;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // FasilitasKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.dataGridViewFasilitasKamar);
            this.Name = "FasilitasKamar";
            this.Text = "FasilitasKamar";
            this.Load += new System.EventHandler(this.FasilitasKamar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFasilitasKamar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasilitasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFasilitasKamar;
        private HotelDataSet9 hotelDataSet9;
        private System.Windows.Forms.BindingSource fasilitasBindingSource;
        private HotelDataSet9TableAdapters.FasilitasTableAdapter fasilitasTableAdapter;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfasilitasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fasilitasDataGridViewTextBoxColumn;
    }
}