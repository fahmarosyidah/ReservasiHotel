using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReservasiHotel
{
    public partial class DataReservasi : Form
    {
        private string stringConnection = "data source = DESKTOP-TV0IMN6\\FAHMA_ROSYI; database = Hotel; User ID = sa; password = 123";
        private SqlConnection koneksi;

        public DataReservasi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            dataGridViewReservasi.Visible = true;
        }

        private void DataReservasi_Load(object sender, EventArgs e)
        {
            dataGridViewReservasi.DataSource = GetReservasiData();
        }

        private DataTable GetReservasiData()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string query = "SELECT * FROM Reservasi";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormReservasi fr = new FormReservasi();
            fr.Show();
            this.Hide();
        }

        private void DeleteData()
        {
            if (dataGridViewReservasi.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data terpilih?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string idRsv = dataGridViewReservasi.SelectedRows[0].Cells["id_reservasi"].Value.ToString();

                    try
                    {
                        koneksi.Open();
                        string query = "DELETE FROM Reservasi WHERE id_reservasi = @idRsv";
                        SqlCommand command = new SqlCommand(query, koneksi);
                        command.Parameters.AddWithValue("@idRsv", idRsv);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewReservasi.Rows.RemoveAt(dataGridViewReservasi.SelectedRows[0].Index);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        koneksi.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih baris data yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void dataGridViewReservasi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewReservasi.Rows[e.RowIndex];

            if (e.ColumnIndex == 10)
            {
                using (SqlCommand cmd =new SqlCommand("delete from dbo.Reservasi where id_reservasi = @idRsv", koneksi))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idRsv", row.Cells[0].Value);

                    koneksi.Open();
                    cmd.ExecuteNonQuery();
                    koneksi.Close();
                }
            }
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Reservasi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewReservasi.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
            btnDelete.Enabled = true;
        }
    }
}
