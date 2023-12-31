﻿
namespace ReservasiHotel
{
    partial class FormDataTamu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIdTamu = new System.Windows.Forms.TextBox();
            this.tamuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet15 = new ReservasiHotel.HotelDataSet15();
            this.tamuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet1 = new ReservasiHotel.HotelDataSet1();
            this.tbNamaTamu = new System.Windows.Forms.TextBox();
            this.tbNoTelp = new System.Windows.Forms.TextBox();
            this.rbAlamat = new System.Windows.Forms.RichTextBox();
            this.dataGridViewTamu = new System.Windows.Forms.DataGridView();
            this.idtamuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namatamuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tamuTableAdapter = new ReservasiHotel.HotelDataSet1TableAdapters.TamuTableAdapter();
            this.tamuTableAdapter1 = new ReservasiHotel.HotelDataSet15TableAdapters.TamuTableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tamuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTamu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Tamu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "No Telpon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // tbIdTamu
            // 
            this.tbIdTamu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tamuBindingSource1, "id_tamu", true));
            this.tbIdTamu.Location = new System.Drawing.Point(286, 218);
            this.tbIdTamu.Name = "tbIdTamu";
            this.tbIdTamu.Size = new System.Drawing.Size(210, 22);
            this.tbIdTamu.TabIndex = 4;
            // 
            // tamuBindingSource1
            // 
            this.tamuBindingSource1.DataMember = "Tamu";
            this.tamuBindingSource1.DataSource = this.hotelDataSet15;
            // 
            // hotelDataSet15
            // 
            this.hotelDataSet15.DataSetName = "HotelDataSet15";
            this.hotelDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tamuBindingSource
            // 
            this.tamuBindingSource.DataMember = "Tamu";
            this.tamuBindingSource.DataSource = this.hotelDataSet1;
            // 
            // hotelDataSet1
            // 
            this.hotelDataSet1.DataSetName = "HotelDataSet1";
            this.hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbNamaTamu
            // 
            this.tbNamaTamu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tamuBindingSource1, "nama_tamu", true));
            this.tbNamaTamu.Location = new System.Drawing.Point(286, 273);
            this.tbNamaTamu.Name = "tbNamaTamu";
            this.tbNamaTamu.Size = new System.Drawing.Size(210, 22);
            this.tbNamaTamu.TabIndex = 5;
            // 
            // tbNoTelp
            // 
            this.tbNoTelp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tamuBindingSource1, "no_telp", true));
            this.tbNoTelp.Location = new System.Drawing.Point(286, 324);
            this.tbNoTelp.Name = "tbNoTelp";
            this.tbNoTelp.Size = new System.Drawing.Size(210, 22);
            this.tbNoTelp.TabIndex = 6;
            // 
            // rbAlamat
            // 
            this.rbAlamat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tamuBindingSource1, "alamat", true));
            this.rbAlamat.Location = new System.Drawing.Point(286, 377);
            this.rbAlamat.Name = "rbAlamat";
            this.rbAlamat.Size = new System.Drawing.Size(210, 62);
            this.rbAlamat.TabIndex = 7;
            this.rbAlamat.Text = "";
            // 
            // dataGridViewTamu
            // 
            this.dataGridViewTamu.AutoGenerateColumns = false;
            this.dataGridViewTamu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTamu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtamuDataGridViewTextBoxColumn,
            this.namatamuDataGridViewTextBoxColumn,
            this.notelpDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn});
            this.dataGridViewTamu.DataSource = this.tamuBindingSource1;
            this.dataGridViewTamu.Location = new System.Drawing.Point(113, 40);
            this.dataGridViewTamu.Name = "dataGridViewTamu";
            this.dataGridViewTamu.RowHeadersWidth = 51;
            this.dataGridViewTamu.RowTemplate.Height = 24;
            this.dataGridViewTamu.Size = new System.Drawing.Size(556, 150);
            this.dataGridViewTamu.TabIndex = 8;
            this.dataGridViewTamu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTamu_CellContentClick);
            // 
            // idtamuDataGridViewTextBoxColumn
            // 
            this.idtamuDataGridViewTextBoxColumn.DataPropertyName = "id_tamu";
            this.idtamuDataGridViewTextBoxColumn.HeaderText = "id_tamu";
            this.idtamuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtamuDataGridViewTextBoxColumn.Name = "idtamuDataGridViewTextBoxColumn";
            this.idtamuDataGridViewTextBoxColumn.Width = 125;
            // 
            // namatamuDataGridViewTextBoxColumn
            // 
            this.namatamuDataGridViewTextBoxColumn.DataPropertyName = "nama_tamu";
            this.namatamuDataGridViewTextBoxColumn.HeaderText = "nama_tamu";
            this.namatamuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namatamuDataGridViewTextBoxColumn.Name = "namatamuDataGridViewTextBoxColumn";
            this.namatamuDataGridViewTextBoxColumn.Width = 125;
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
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(694, 40);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 35);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(530, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(421, 467);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(286, 467);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 35);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tamuTableAdapter
            // 
            this.tamuTableAdapter.ClearBeforeFill = true;
            // 
            // tamuTableAdapter1
            // 
            this.tamuTableAdapter1.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(530, 270);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(530, 324);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 35);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormDataTamu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(799, 541);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.dataGridViewTamu);
            this.Controls.Add(this.rbAlamat);
            this.Controls.Add(this.tbNoTelp);
            this.Controls.Add(this.tbNamaTamu);
            this.Controls.Add(this.tbIdTamu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDataTamu";
            this.Text = "Data Tamu";
            this.Load += new System.EventHandler(this.FormDataTamu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tamuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTamu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIdTamu;
        private System.Windows.Forms.TextBox tbNamaTamu;
        private System.Windows.Forms.TextBox tbNoTelp;
        private System.Windows.Forms.RichTextBox rbAlamat;
        private System.Windows.Forms.DataGridView dataGridViewTamu;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private HotelDataSet1 hotelDataSet1;
        private System.Windows.Forms.BindingSource tamuBindingSource;
        private HotelDataSet1TableAdapters.TamuTableAdapter tamuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtamuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namatamuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notelpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private HotelDataSet15 hotelDataSet15;
        private System.Windows.Forms.BindingSource tamuBindingSource1;
        private HotelDataSet15TableAdapters.TamuTableAdapter tamuTableAdapter1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}