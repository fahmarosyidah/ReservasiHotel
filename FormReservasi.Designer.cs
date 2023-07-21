
namespace ReservasiHotel
{
    partial class FormReservasi
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reservasiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet8 = new ReservasiHotel.HotelDataSet8();
            this.reservasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet4 = new ReservasiHotel.HotelDataSet4();
            this.reservasiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dtBooking = new System.Windows.Forms.DateTimePicker();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNamaHotel = new System.Windows.Forms.TextBox();
            this.reservasiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet26 = new ReservasiHotel.HotelDataSet26();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbJenisKamar = new System.Windows.Forms.ComboBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbLamaInap = new System.Windows.Forms.TextBox();
            this.tbBiaya = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbJmlBayar = new System.Windows.Forms.TextBox();
            this.tbKembalian = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.reservasiTableAdapter = new ReservasiHotel.HotelDataSet4TableAdapters.ReservasiTableAdapter();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.reservasiTableAdapter1 = new ReservasiHotel.HotelDataSet8TableAdapters.ReservasiTableAdapter();
            this.reservasiTableAdapter2 = new ReservasiHotel.HotelDataSet26TableAdapters.ReservasiTableAdapter();
            this.cbIdRsp = new System.Windows.Forms.ComboBox();
            this.cbIdTamu = new System.Windows.Forms.ComboBox();
            this.cbNoKamar = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbIdRsv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.reservasiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasiBindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservasiBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet26)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOTEL ANGKER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "[ DATA PEMESAN ]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Reservasi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id Petugas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Id Tamu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tanggal Booking";
            // 
            // reservasiBindingSource1
            // 
            this.reservasiBindingSource1.DataMember = "Reservasi";
            this.reservasiBindingSource1.DataSource = this.hotelDataSet8;
            // 
            // hotelDataSet8
            // 
            this.hotelDataSet8.DataSetName = "HotelDataSet8";
            this.hotelDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // reservasiBindingSource2
            // 
            this.reservasiBindingSource2.DataMember = "Reservasi";
            this.reservasiBindingSource2.DataSource = this.hotelDataSet8;
            // 
            // dtBooking
            // 
            this.dtBooking.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservasiBindingSource1, "tanggal_booking", true));
            this.dtBooking.Location = new System.Drawing.Point(242, 259);
            this.dtBooking.Name = "dtBooking";
            this.dtBooking.Size = new System.Drawing.Size(247, 22);
            this.dtBooking.TabIndex = 9;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(599, 459);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(106, 48);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "SAVE";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(52, 609);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 48);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.tbIdRsv);
            this.groupBox1.Controls.Add(this.cbIdTamu);
            this.groupBox1.Controls.Add(this.cbIdRsp);
            this.groupBox1.Controls.Add(this.tbNamaHotel);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.dtBooking);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(131, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 340);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // tbNamaHotel
            // 
            this.tbNamaHotel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservasiBindingSource3, "nama_hotel", true));
            this.tbNamaHotel.Location = new System.Drawing.Point(242, 82);
            this.tbNamaHotel.Name = "tbNamaHotel";
            this.tbNamaHotel.Size = new System.Drawing.Size(217, 22);
            this.tbNamaHotel.TabIndex = 11;
            this.tbNamaHotel.TextChanged += new System.EventHandler(this.tbNamaHotel_TextChanged);
            // 
            // reservasiBindingSource3
            // 
            this.reservasiBindingSource3.DataMember = "Reservasi";
            this.reservasiBindingSource3.DataSource = this.hotelDataSet26;
            // 
            // hotelDataSet26
            // 
            this.hotelDataSet26.DataSetName = "HotelDataSet26";
            this.hotelDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(87, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 17);
            this.label16.TabIndex = 10;
            this.label16.Text = "Nama Hotel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "[ BOOKING PRICE ]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Jenis Kamar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Harga Sewa Perhari";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Lama Menginap";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Total Biaya Sewa";
            // 
            // cbJenisKamar
            // 
            this.cbJenisKamar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservasiBindingSource2, "tipe_kamar", true));
            this.cbJenisKamar.FormattingEnabled = true;
            this.cbJenisKamar.Items.AddRange(new object[] {
            "VIP",
            "Kelas I",
            "Kelas II",
            "Kelas III"});
            this.cbJenisKamar.Location = new System.Drawing.Point(250, 80);
            this.cbJenisKamar.Name = "cbJenisKamar";
            this.cbJenisKamar.Size = new System.Drawing.Size(220, 24);
            this.cbJenisKamar.TabIndex = 18;
            this.cbJenisKamar.SelectedIndexChanged += new System.EventHandler(this.cbJenisKamar_SelectedIndexChanged);
            // 
            // tbHarga
            // 
            this.tbHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHarga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservasiBindingSource1, "harga_sewa", true));
            this.tbHarga.Location = new System.Drawing.Point(250, 122);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(220, 22);
            this.tbHarga.TabIndex = 19;
            // 
            // tbLamaInap
            // 
            this.tbLamaInap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLamaInap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservasiBindingSource2, "lama_menginap", true));
            this.tbLamaInap.Location = new System.Drawing.Point(250, 210);
            this.tbLamaInap.Name = "tbLamaInap";
            this.tbLamaInap.Size = new System.Drawing.Size(220, 22);
            this.tbLamaInap.TabIndex = 20;
            this.tbLamaInap.TextChanged += new System.EventHandler(this.tbLamaInap_TextChanged);
            // 
            // tbBiaya
            // 
            this.tbBiaya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBiaya.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservasiBindingSource1, "total_harga", true));
            this.tbBiaya.Location = new System.Drawing.Point(250, 257);
            this.tbBiaya.Name = "tbBiaya";
            this.tbBiaya.Size = new System.Drawing.Size(220, 22);
            this.tbBiaya.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.cbNoKamar);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tbBiaya);
            this.groupBox2.Controls.Add(this.tbLamaInap);
            this.groupBox2.Controls.Add(this.tbHarga);
            this.groupBox2.Controls.Add(this.cbJenisKamar);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(763, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 340);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(76, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "No Kamar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 24);
            this.label12.TabIndex = 23;
            this.label12.Text = "[ PEMBAYARAN ]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(76, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Jumlah Bayar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(76, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "Kembalian";
            // 
            // tbJmlBayar
            // 
            this.tbJmlBayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbJmlBayar.Location = new System.Drawing.Point(250, 78);
            this.tbJmlBayar.Name = "tbJmlBayar";
            this.tbJmlBayar.Size = new System.Drawing.Size(220, 22);
            this.tbJmlBayar.TabIndex = 26;
            this.tbJmlBayar.TextChanged += new System.EventHandler(this.tbJmlBayar_TextChanged);
            // 
            // tbKembalian
            // 
            this.tbKembalian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKembalian.Location = new System.Drawing.Point(250, 133);
            this.tbKembalian.Name = "tbKembalian";
            this.tbKembalian.Size = new System.Drawing.Size(220, 22);
            this.tbKembalian.TabIndex = 27;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.tbKembalian);
            this.groupBox3.Controls.Add(this.tbJmlBayar);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(763, 461);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 196);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // reservasiTableAdapter
            // 
            this.reservasiTableAdapter.ClearBeforeFill = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(442, 459);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 47);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(1342, 90);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(89, 48);
            this.btnView.TabIndex = 30;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // reservasiTableAdapter1
            // 
            this.reservasiTableAdapter1.ClearBeforeFill = true;
            // 
            // reservasiTableAdapter2
            // 
            this.reservasiTableAdapter2.ClearBeforeFill = true;
            // 
            // cbIdRsp
            // 
            this.cbIdRsp.FormattingEnabled = true;
            this.cbIdRsp.Location = new System.Drawing.Point(242, 165);
            this.cbIdRsp.Name = "cbIdRsp";
            this.cbIdRsp.Size = new System.Drawing.Size(217, 24);
            this.cbIdRsp.TabIndex = 13;
            // 
            // cbIdTamu
            // 
            this.cbIdTamu.FormattingEnabled = true;
            this.cbIdTamu.Location = new System.Drawing.Point(242, 209);
            this.cbIdTamu.Name = "cbIdTamu";
            this.cbIdTamu.Size = new System.Drawing.Size(217, 24);
            this.cbIdTamu.TabIndex = 14;
            // 
            // cbNoKamar
            // 
            this.cbNoKamar.FormattingEnabled = true;
            this.cbNoKamar.Location = new System.Drawing.Point(250, 165);
            this.cbNoKamar.Name = "cbNoKamar";
            this.cbNoKamar.Size = new System.Drawing.Size(220, 24);
            this.cbNoKamar.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(131, 460);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 47);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbIdRsv
            // 
            this.tbIdRsv.Location = new System.Drawing.Point(242, 124);
            this.tbIdRsv.Name = "tbIdRsv";
            this.tbIdRsv.Size = new System.Drawing.Size(217, 22);
            this.tbIdRsv.TabIndex = 15;
            // 
            // FormReservasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 708);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Name = "FormReservasi";
            this.Text = "Form Reservasi";
            this.Load += new System.EventHandler(this.FormReservasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservasiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasiBindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservasiBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet26)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtBooking;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbJenisKamar;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbLamaInap;
        private System.Windows.Forms.TextBox tbBiaya;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbJmlBayar;
        private System.Windows.Forms.TextBox tbKembalian;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private HotelDataSet4 hotelDataSet4;
        private System.Windows.Forms.BindingSource reservasiBindingSource;
        private HotelDataSet4TableAdapters.ReservasiTableAdapter reservasiTableAdapter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnView;
        private HotelDataSet8 hotelDataSet8;
        private System.Windows.Forms.BindingSource reservasiBindingSource1;
        private HotelDataSet8TableAdapters.ReservasiTableAdapter reservasiTableAdapter1;
        private System.Windows.Forms.BindingSource reservasiBindingSource2;
        private System.Windows.Forms.TextBox tbNamaHotel;
        private System.Windows.Forms.Label label16;
        private HotelDataSet26 hotelDataSet26;
        private System.Windows.Forms.BindingSource reservasiBindingSource3;
        private HotelDataSet26TableAdapters.ReservasiTableAdapter reservasiTableAdapter2;
        private System.Windows.Forms.ComboBox cbIdTamu;
        private System.Windows.Forms.ComboBox cbIdRsp;
        private System.Windows.Forms.ComboBox cbNoKamar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbIdRsv;
    }
}