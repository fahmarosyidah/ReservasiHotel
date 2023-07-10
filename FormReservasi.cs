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

        private void refreshform()
        {
            tbIdReservasi.Text = null;
            tbIdRsp.Text = null;
            tbIdTamu.Text = null;
            dtBooking.Text = null;
            cbJenisKamar.Text = null;
            tbHarga.Text = null;
            tbNoKamar.Text = null;
            tbLamaInap.Text = null;
            tbBiaya.Text = null;
            btnNew.Enabled = true;
            btnClose.Enabled = true;
        }

        public FormReservasi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void FormReservasi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet4.Reservasi' table. You can move, or remove it, as needed.
            this.reservasiTableAdapter.Fill(this.hotelDataSet4.Reservasi);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FormDataMaster dm = new FormDataMaster();
            dm.Show();
            this.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string idRsv = tbIdReservasi.Text;
            string idRsp = tbIdRsp.Text;
            string idTamu = tbIdTamu.Text;
            DateTime tanggal = dtBooking.Value;
            string jenisKamar = cbJenisKamar.Text;
            string hargaSewa = tbHarga.Text;
            string noKmr = tbNoKamar.Text;
            string lamaInap = tbLamaInap.Text;
            string totalBiaya = tbBiaya.Text;

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
            else if (hargaSewa == "")
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
            else if (totalBiaya == "")
            {
                MessageBox.Show("Masukkan Total Biaya Sewa", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    //koneksi.Open();
                    //string str = "insert into dbo.Reservasi (id_reservasi, id_petugas, id_tamu, tanggal_booking, tipe_kamar, harga_sewa, no_kamar, lama_menginap, total_harga)" + "values(@idRsv, @idRsp, @idTamu, @tgl, @tpKmr, @hrg, @noKmr, @inp, @biaya)";
                    //SqlCommand cmd = new SqlCommand(str, koneksi);
                    //cmd.CommandType = CommandType.Text;
                    connection.Open();
                    string query = "INSERT INTO Reservasi (id_reservasi, id_petugas, id_tamu, tanggal_booking, tipe_kamar, harga_sewa, no_kamar, lama_menginap, total_harga) VALUES (@idRsv, @idRsp, @idTamu, @tgl, @tpKmr, @hrg, @noKmr, @inp, @biaya)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
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
                }
                    
                //koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshform();
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

            tbHarga.Text = hargaSewa.ToString();
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
    }
}
