
namespace ReservasiHotel
{
    partial class FormDataKamar
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
            this.dataGridViewKamar = new System.Windows.Forms.DataGridView();
            this.nokamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipekamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargasewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kamarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new ReservasiHotel.HotelDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNoKamar = new System.Windows.Forms.TextBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.cbTipeKamar = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.kamarTableAdapter = new ReservasiHotel.HotelDataSetTableAdapters.KamarTableAdapter();
            this.btnview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKamar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKamar
            // 
            this.dataGridViewKamar.AutoGenerateColumns = false;
            this.dataGridViewKamar.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKamar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nokamarDataGridViewTextBoxColumn,
            this.tipekamarDataGridViewTextBoxColumn,
            this.hargasewaDataGridViewTextBoxColumn});
            this.dataGridViewKamar.DataSource = this.kamarBindingSource;
            this.dataGridViewKamar.Location = new System.Drawing.Point(127, 39);
            this.dataGridViewKamar.Name = "dataGridViewKamar";
            this.dataGridViewKamar.RowHeadersWidth = 51;
            this.dataGridViewKamar.RowTemplate.Height = 24;
            this.dataGridViewKamar.Size = new System.Drawing.Size(526, 150);
            this.dataGridViewKamar.TabIndex = 0;
            // 
            // nokamarDataGridViewTextBoxColumn
            // 
            this.nokamarDataGridViewTextBoxColumn.DataPropertyName = "no_kamar";
            this.nokamarDataGridViewTextBoxColumn.HeaderText = "no_kamar";
            this.nokamarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nokamarDataGridViewTextBoxColumn.Name = "nokamarDataGridViewTextBoxColumn";
            this.nokamarDataGridViewTextBoxColumn.Width = 125;
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
            // kamarBindingSource
            // 
            this.kamarBindingSource.DataMember = "Kamar";
            this.kamarBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "No Kamar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipe kamar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Harga Sewa";
            // 
            // tbNoKamar
            // 
            this.tbNoKamar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNoKamar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kamarBindingSource, "no_kamar", true));
            this.tbNoKamar.Location = new System.Drawing.Point(300, 219);
            this.tbNoKamar.Name = "tbNoKamar";
            this.tbNoKamar.Size = new System.Drawing.Size(177, 22);
            this.tbNoKamar.TabIndex = 4;
            // 
            // tbHarga
            // 
            this.tbHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHarga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kamarBindingSource, "harga_sewa", true));
            this.tbHarga.Location = new System.Drawing.Point(300, 316);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(177, 22);
            this.tbHarga.TabIndex = 5;
            // 
            // cbTipeKamar
            // 
            this.cbTipeKamar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kamarBindingSource, "tipe_kamar", true));
            this.cbTipeKamar.FormattingEnabled = true;
            this.cbTipeKamar.Items.AddRange(new object[] {
            "VIP",
            "Kelas I",
            "Kelas II",
            "Kelas III"});
            this.cbTipeKamar.Location = new System.Drawing.Point(300, 268);
            this.cbTipeKamar.Name = "cbTipeKamar";
            this.cbTipeKamar.Size = new System.Drawing.Size(177, 24);
            this.cbTipeKamar.TabIndex = 6;
            this.cbTipeKamar.SelectedIndexChanged += new System.EventHandler(this.cbTipeKamar_SelectedIndexChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(688, 39);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 35);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(500, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(402, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(300, 365);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 35);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // kamarTableAdapter
            // 
            this.kamarTableAdapter.ClearBeforeFill = true;
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.White;
            this.btnview.Location = new System.Drawing.Point(688, 100);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(75, 39);
            this.btnview.TabIndex = 11;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // FormDataKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cbTipeKamar);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.tbNoKamar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewKamar);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kamarBindingSource, "no_kamar", true));
            this.Name = "FormDataKamar";
            this.Text = "Data Kamar";
            this.Load += new System.EventHandler(this.FormDataKamar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKamar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kamarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKamar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNoKamar;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.ComboBox cbTipeKamar;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource kamarBindingSource;
        private HotelDataSetTableAdapters.KamarTableAdapter kamarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nokamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipekamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargasewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnview;
    }
}