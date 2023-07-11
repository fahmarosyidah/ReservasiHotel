
namespace ReservasiHotel
{
    partial class FormDataResepsionis
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
            this.dataGridViewRsp = new System.Windows.Forms.DataGridView();
            this.resepsionisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet2 = new ReservasiHotel.HotelDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIdRsp = new System.Windows.Forms.TextBox();
            this.tbNamaRsp = new System.Windows.Forms.TextBox();
            this.tbNoTelp = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rbAlamat = new System.Windows.Forms.RichTextBox();
            this.resepsionisTableAdapter = new ReservasiHotel.HotelDataSet2TableAdapters.ResepsionisTableAdapter();
            this.idpetugasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapetugasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resepsionisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRsp
            // 
            this.dataGridViewRsp.AutoGenerateColumns = false;
            this.dataGridViewRsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpetugasDataGridViewTextBoxColumn,
            this.namapetugasDataGridViewTextBoxColumn,
            this.notelpDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn});
            this.dataGridViewRsp.DataSource = this.resepsionisBindingSource;
            this.dataGridViewRsp.Location = new System.Drawing.Point(118, 39);
            this.dataGridViewRsp.Name = "dataGridViewRsp";
            this.dataGridViewRsp.RowHeadersWidth = 51;
            this.dataGridViewRsp.RowTemplate.Height = 24;
            this.dataGridViewRsp.Size = new System.Drawing.Size(546, 145);
            this.dataGridViewRsp.TabIndex = 0;
            // 
            // resepsionisBindingSource
            // 
            this.resepsionisBindingSource.DataMember = "Resepsionis";
            this.resepsionisBindingSource.DataSource = this.hotelDataSet2;
            // 
            // hotelDataSet2
            // 
            this.hotelDataSet2.DataSetName = "HotelDataSet2";
            this.hotelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Resepsionis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "No Telpon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alamat";
            // 
            // tbIdRsp
            // 
            this.tbIdRsp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resepsionisBindingSource, "id_petugas", true));
            this.tbIdRsp.Location = new System.Drawing.Point(286, 213);
            this.tbIdRsp.Name = "tbIdRsp";
            this.tbIdRsp.Size = new System.Drawing.Size(241, 22);
            this.tbIdRsp.TabIndex = 5;
            // 
            // tbNamaRsp
            // 
            this.tbNamaRsp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resepsionisBindingSource, "nama_petugas", true));
            this.tbNamaRsp.Location = new System.Drawing.Point(286, 259);
            this.tbNamaRsp.Name = "tbNamaRsp";
            this.tbNamaRsp.Size = new System.Drawing.Size(241, 22);
            this.tbNamaRsp.TabIndex = 6;
            // 
            // tbNoTelp
            // 
            this.tbNoTelp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resepsionisBindingSource, "no_telp", true));
            this.tbNoTelp.Location = new System.Drawing.Point(286, 305);
            this.tbNoTelp.Name = "tbNoTelp";
            this.tbNoTelp.Size = new System.Drawing.Size(241, 22);
            this.tbNoTelp.TabIndex = 7;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(695, 39);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 36);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(553, 213);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(452, 468);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(286, 468);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rbAlamat
            // 
            this.rbAlamat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resepsionisBindingSource, "alamat", true));
            this.rbAlamat.Location = new System.Drawing.Point(286, 354);
            this.rbAlamat.Name = "rbAlamat";
            this.rbAlamat.Size = new System.Drawing.Size(241, 96);
            this.rbAlamat.TabIndex = 13;
            this.rbAlamat.Text = "";
            // 
            // resepsionisTableAdapter
            // 
            this.resepsionisTableAdapter.ClearBeforeFill = true;
            // 
            // idpetugasDataGridViewTextBoxColumn
            // 
            this.idpetugasDataGridViewTextBoxColumn.DataPropertyName = "id_petugas";
            this.idpetugasDataGridViewTextBoxColumn.HeaderText = "id_petugas";
            this.idpetugasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpetugasDataGridViewTextBoxColumn.Name = "idpetugasDataGridViewTextBoxColumn";
            // 
            // namapetugasDataGridViewTextBoxColumn
            // 
            this.namapetugasDataGridViewTextBoxColumn.DataPropertyName = "nama_petugas";
            this.namapetugasDataGridViewTextBoxColumn.HeaderText = "nama_petugas";
            this.namapetugasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namapetugasDataGridViewTextBoxColumn.Name = "namapetugasDataGridViewTextBoxColumn";
            this.namapetugasDataGridViewTextBoxColumn.Width = 125;
            // 
            // notelpDataGridViewTextBoxColumn
            // 
            this.notelpDataGridViewTextBoxColumn.DataPropertyName = "no_telp";
            this.notelpDataGridViewTextBoxColumn.HeaderText = "no_telp";
            this.notelpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notelpDataGridViewTextBoxColumn.Name = "notelpDataGridViewTextBoxColumn";
            this.notelpDataGridViewTextBoxColumn.Width = 115;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 160;
            // 
            // FormDataResepsionis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.rbAlamat);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.tbNoTelp);
            this.Controls.Add(this.tbNamaRsp);
            this.Controls.Add(this.tbIdRsp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewRsp);
            this.Name = "FormDataResepsionis";
            this.Text = "Data Resepsionis";
            this.Load += new System.EventHandler(this.FormDataResepsionis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resepsionisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRsp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIdRsp;
        private System.Windows.Forms.TextBox tbNamaRsp;
        private System.Windows.Forms.TextBox tbNoTelp;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rbAlamat;
        private HotelDataSet2 hotelDataSet2;
        private System.Windows.Forms.BindingSource resepsionisBindingSource;
        private HotelDataSet2TableAdapters.ResepsionisTableAdapter resepsionisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpetugasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapetugasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notelpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
    }
}