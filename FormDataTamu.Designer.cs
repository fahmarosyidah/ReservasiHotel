
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
            this.tbNamaTamu = new System.Windows.Forms.TextBox();
            this.tbNoTelp = new System.Windows.Forms.TextBox();
            this.rbAlamat = new System.Windows.Forms.RichTextBox();
            this.dataGridViewTamu = new System.Windows.Forms.DataGridView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.hotelDataSet1 = new ReservasiHotel.HotelDataSet1();
            this.tamuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tamuTableAdapter = new ReservasiHotel.HotelDataSet1TableAdapters.TamuTableAdapter();
            this.idtamuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namatamuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTamu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Tamu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "No Telpon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // tbIdTamu
            // 
            this.tbIdTamu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tamuBindingSource, "id_tamu", true));
            this.tbIdTamu.Location = new System.Drawing.Point(286, 209);
            this.tbIdTamu.Name = "tbIdTamu";
            this.tbIdTamu.Size = new System.Drawing.Size(210, 22);
            this.tbIdTamu.TabIndex = 4;
            // 
            // tbNamaTamu
            // 
            this.tbNamaTamu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tamuBindingSource, "nama_tamu", true));
            this.tbNamaTamu.Location = new System.Drawing.Point(286, 264);
            this.tbNamaTamu.Name = "tbNamaTamu";
            this.tbNamaTamu.Size = new System.Drawing.Size(210, 22);
            this.tbNamaTamu.TabIndex = 5;
            // 
            // tbNoTelp
            // 
            this.tbNoTelp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tamuBindingSource, "no_telp", true));
            this.tbNoTelp.Location = new System.Drawing.Point(286, 315);
            this.tbNoTelp.Name = "tbNoTelp";
            this.tbNoTelp.Size = new System.Drawing.Size(210, 22);
            this.tbNoTelp.TabIndex = 6;
            // 
            // rbAlamat
            // 
            this.rbAlamat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tamuBindingSource, "alamat", true));
            this.rbAlamat.Location = new System.Drawing.Point(286, 368);
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
            this.dataGridViewTamu.DataSource = this.tamuBindingSource;
            this.dataGridViewTamu.Location = new System.Drawing.Point(117, 40);
            this.dataGridViewTamu.Name = "dataGridViewTamu";
            this.dataGridViewTamu.RowHeadersWidth = 51;
            this.dataGridViewTamu.RowTemplate.Height = 24;
            this.dataGridViewTamu.Size = new System.Drawing.Size(550, 150);
            this.dataGridViewTamu.TabIndex = 8;
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
            this.btnAdd.Location = new System.Drawing.Point(530, 209);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(421, 458);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(286, 458);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 35);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // hotelDataSet1
            // 
            this.hotelDataSet1.DataSetName = "HotelDataSet1";
            this.hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tamuBindingSource
            // 
            this.tamuBindingSource.DataMember = "Tamu";
            this.tamuBindingSource.DataSource = this.hotelDataSet1;
            // 
            // tamuTableAdapter
            // 
            this.tamuTableAdapter.ClearBeforeFill = true;
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
            this.notelpDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormDataTamu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTamu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamuBindingSource)).EndInit();
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
    }
}