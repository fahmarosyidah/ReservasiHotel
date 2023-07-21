using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReservasiHotel
{
    public partial class FormReservasi : Form
    {
        private string stringConnection = "data source = DESKTOP-TV0IMN6\\FAHMA_ROSYI; database = Hotel; User ID = sa; password = 123";
        private SqlConnection koneksi;
        private BindingSource TransaksiBindingSource;

        private void refreshform()
        {
            tbNamaHotel.Enabled = true;
            tbNamaHotel.Text = "Hotel Angker";
            tbIdRsv.Enabled = false;
            tbIdRsv.Text = "";
            cbIdRsp.Enabled = false;
            cbIdRsp.Text = "";
            cbIdTamu.Enabled = false;
            cbIdTamu.Text = "";
            dtBooking.Enabled = false;
            dtBooking.Text = "";
            cbJenisKamar.Enabled = false;
            cbJenisKamar.Text = "";
            tbHarga.Enabled = false;
            tbHarga.Text = "";
            cbNoKamar.Enabled = false;
            cbNoKamar.Text = "";
            tbLamaInap.Enabled = false;
            tbLamaInap.Text = "";
            tbBiaya.Enabled = false;
            tbBiaya.Text = "";
            btnNew.Enabled = true;
            btnClose.Enabled = true;
            clearBinding();
        }

        private void clearBinding()
        {
            this.tbIdRsv.DataBindings.Clear();
            this.cbIdRsp.DataBindings.Clear();
            this.cbIdTamu.DataBindings.Clear();
            this.dtBooking.DataBindings.Clear();
            this.cbJenisKamar.DataBindings.Clear();
            this.tbHarga.DataBindings.Clear();
            this.cbNoKamar.DataBindings.Clear();
            this.tbLamaInap.DataBindings.Clear();
            this.tbBiaya.DataBindings.Clear();
        }

        public FormReservasi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            TransaksiBindingSource = new BindingSource();
            refreshform();
        }

        private void FormReservasi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet26.Reservasi' table. You can move, or remove it, as needed.
            this.reservasiTableAdapter2.Fill(this.hotelDataSet26.Reservasi);
            // TODO: This line of code loads data into the 'hotelDataSet4.Reservasi' table. You can move, or remove it, as needed.
            //this.reservasiTableAdapter.Fill(this.hotelDataSet4.Reservasi);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FormDataMaster dm = new FormDataMaster();
            dm.Show();
            this.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string nmHotel = tbNamaHotel.Text;
            string idRsv = tbIdRsv.Text;
            string idRsp = cbIdRsp.Text;
            string idTamu = cbIdTamu.Text;
            DateTime tanggal = dtBooking.Value;
            string jenisKamar = cbJenisKamar.Text;
            decimal hargaSewa = 0;
            string noKmr = cbNoKamar.Text;
            string lamaInap = tbLamaInap.Text;
            decimal totalBiaya = 0;

            if (idRsv == "")
            {
                MessageBox.Show("Masukkan ID Reservasi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (idRsp == "")
            {
                MessageBox.Show("Masukkan ID Resepsionis", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (idTamu == "")
            {
                MessageBox.Show("Masukkan ID Tamu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (jenisKamar == "")
            {
                MessageBox.Show("Masukkan Jenis Kamar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbHarga.Text == "")
            {
                MessageBox.Show("Masukkan Harga Sewa", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (noKmr == "")
            {
                MessageBox.Show("Masukkan No Kamar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (lamaInap == "")
            {
                MessageBox.Show("Masukkan Lama Menginap", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbBiaya.Text == "")
            {
                MessageBox.Show("Masukkan Total Biaya Sewa", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (decimal.TryParse(tbHarga.Text, out hargaSewa) && decimal.TryParse(tbBiaya.Text, out totalBiaya))
                {
                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        //koneksi.Open();
                        //string str = "insert into dbo.Reservasi (id_reservasi, id_petugas, id_tamu, tanggal_booking, tipe_kamar, harga_sewa, no_kamar, lama_menginap, total_harga)" + "values(@idRsv, @idRsp, @idTamu, @tgl, @tpKmr, @hrg, @noKmr, @inp, @biaya)";
                        //SqlCommand cmd = new SqlCommand(str, koneksi);
                        //cmd.CommandType = CommandType.Text;
                        connection.Open();
                        string query = "INSERT INTO Reservasi (nama_hotel, id_reservasi, id_petugas, id_tamu, tanggal_booking, tipe_kamar, harga_sewa, no_kamar, lama_menginap, total_harga) VALUES (@nmHotel, @idRsv, @idRsp, @idTamu, @tgl, @tpKmr, @hrg, @noKmr, @inp, @biaya)";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.Add(new SqlParameter("nmHotel", nmHotel));
                            cmd.Parameters.Add(new SqlParameter("idRsv", idRsv));
                            cmd.Parameters.Add(new SqlParameter("idRsp", idRsp));
                            cmd.Parameters.Add(new SqlParameter("IdTamu", idTamu));
                            cmd.Parameters.Add(new SqlParameter("tgl", tanggal));
                            cmd.Parameters.Add(new SqlParameter("tpKmr", jenisKamar));
                            cmd.Parameters.Add(new SqlParameter("hrg", hargaSewa));
                            cmd.Parameters.Add(new SqlParameter("noKmr", noKmr));
                            cmd.Parameters.Add(new SqlParameter("inp", lamaInap));
                            cmd.Parameters.Add(new SqlParameter("biaya", totalBiaya));
                            cmd.ExecuteNonQuery();
                        }

                        //koneksi.Close();
                        MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshform();
                    }
                }
            }
        }

        private void cbJenisKamar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string jenisKamar = cbJenisKamar.Text;
            decimal hargaSewa = 0;

            switch (jenisKamar)
            {
                case "VIP":
                    hargaSewa = 1000000;
                    break;
                case "Kelas I":
                    hargaSewa = 750000;
                    break;
                case "Kelas II":
                    hargaSewa = 500000;
                    break;
                case "Kelas III":
                    hargaSewa = 250000;
                    break;
                default:
                    break;
            }

            tbHarga.Text = hargaSewa.ToString("N2");
        }

        private void tbLamaInap_TextChanged(object sender, EventArgs e)
        {
            string lamaInapText = tbLamaInap.Text;

            if (int.TryParse(lamaInapText, out int lamaInap))
            {
                string hargaSewaText = tbHarga.Text;

                if (decimal.TryParse(hargaSewaText, out decimal hargaSewa))
                {
                    decimal totalBiaya = lamaInap * hargaSewa;

                    tbBiaya.Text = totalBiaya.ToString();
                }
            }
        }

        private void tbJmlBayar_TextChanged(object sender, EventArgs e)
        {
            decimal biaya = 0;
            decimal jmlBayar = 0;
            decimal kembalian = 0;

            if (decimal.TryParse(tbBiaya.Text, out biaya) && decimal.TryParse(tbJmlBayar.Text, out jmlBayar))
            {
                kembalian = jmlBayar - biaya;
            }

            tbKembalian.Text = kembalian.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DataReservasi dtRsv = new DataReservasi();
            dtRsv.Show();
            this.Hide();
        }

        private void tbNamaHotel_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdResepsionis()
        {
            koneksi.Open();
            string stringConnection = "select id_petugas, id_petugas from dbo.Resepsionis";
            SqlCommand cmd = new SqlCommand(stringConnection, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            koneksi.Close();
            cbIdRsp.DisplayMember = "id_petugas";
            cbIdRsp.ValueMember = "id_petugas";
            cbIdRsp.DataSource = dt;
        }

        private void IdTamu()
        {
            koneksi.Open();
            string stringConnection = "select id_tamu, id_tamu from dbo.Tamu";
            SqlCommand cmd = new SqlCommand(stringConnection, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            koneksi.Close();
            cbIdTamu.DisplayMember = "id_tamu";
            cbIdTamu.ValueMember = "id_tamu";
            cbIdTamu.DataSource = dt;
        }

        private void NoKamar()
        {
            koneksi.Open();
            string stringConnection = "select no_kamar, no_kamar from dbo.Kamar";
            SqlCommand cmd = new SqlCommand(stringConnection, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            koneksi.Close();
            cbNoKamar.DisplayMember = "no_kamar";
            cbNoKamar.ValueMember = "no_kamar";
            cbNoKamar.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbNamaHotel.Enabled = true;
            tbIdRsv.Enabled = true;
            cbIdRsp.Enabled = true;
            IdResepsionis();
            cbIdTamu.Enabled = true;
            IdTamu();
            dtBooking.Enabled = true;
            dtBooking.Value = DateTime.Today;
            cbJenisKamar.Enabled = true;
            tbHarga.Enabled = true;
            cbNoKamar.Enabled = true;
            NoKamar();
            tbLamaInap.Enabled = true;
            tbBiaya.Enabled = true;
            btnNew.Enabled = true;
            btnAdd.Enabled = true;
            btnClear.Enabled = true;

        }
    }
}
