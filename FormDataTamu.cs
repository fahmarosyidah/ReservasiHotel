using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReservasiHotel
{
    public partial class FormDataTamu : Form
    {
        private string stringConnection = "data source = DESKTOP-TV0IMN6\\FAHMA_ROSYI; database = Hotel; User ID = sa; password = 123";
        private SqlConnection koneksi;

        public FormDataTamu()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            dataGridViewTamu.Visible = false;
            refreshform();
        }

        private void refreshform()
        {
            tbIdTamu.Text = "";
            tbNamaTamu.Text = "";
            tbNoTelp.Text = "";
            rbAlamat.Text = "";
            tbIdTamu.Enabled = false;
            tbNamaTamu.Enabled = false;
            tbNoTelp.Enabled = false;
            rbAlamat.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        private void FormDataTamu_Load(object sender, EventArgs e)
        {
            dataGridViewTamu.DataSource = GetTamuData();
        }

        private DataTable GetTamuData()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string query = "SELECT id_tamu, nama_tamu, no_telp, alamat FROM Tamu";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridViewTamu.Visible = true;
            dataGridViewTamu.DataSource = GetTamuData();
            btnAdd.Enabled = true;
            btnOpen.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbIdTamu.Enabled = true;
            tbIdTamu.Text = "";
            tbNamaTamu.Enabled = true;
            tbNamaTamu.Text = "";
            tbNoTelp.Enabled = true;
            tbNoTelp.Text = "";
            rbAlamat.Enabled = true;
            rbAlamat.Text = "";
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idTamu = tbIdTamu.Text;
            string nmTamu = tbNamaTamu.Text;
            string noTelp = tbNoTelp.Text;
            string alamat = rbAlamat.Text;

            if (string.IsNullOrEmpty(idTamu) || string.IsNullOrEmpty(nmTamu) || string.IsNullOrEmpty(noTelp) || string.IsNullOrEmpty(alamat))
            {
                MessageBox.Show("Data tidak lengkap", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    koneksi.Open();
                    string query = "INSERT INTO Tamu (id_tamu, nama_tamu, no_telp, alamat) VALUES (@id, @nm, @tlp, @al)";
                    SqlCommand cmd = new SqlCommand(query, koneksi);
                    cmd.Parameters.AddWithValue("@id", idTamu);
                    cmd.Parameters.AddWithValue("@nm", nmTamu);
                    cmd.Parameters.AddWithValue("@tlp", noTelp);
                    cmd.Parameters.AddWithValue("@al", alamat);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewTamu.DataSource = GetTamuData();
                    refreshform();
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

        private void dataGridViewTamu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewTamu.Rows[e.RowIndex];
                tbIdTamu.Text = row.Cells["id_tamu"].Value.ToString();
                tbNamaTamu.Text = row.Cells["nama_tamu"].Value.ToString();
                tbNoTelp.Text = row.Cells["no_telp"].Value.ToString();
                rbAlamat.Text = row.Cells["alamat"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string idTamu = tbIdTamu.Text;
            string nmTamu = tbNamaTamu.Text;
            string noTelp = tbNoTelp.Text;
            string alamat = rbAlamat.Text;

            if (string.IsNullOrEmpty(idTamu) || string.IsNullOrEmpty(nmTamu) || string.IsNullOrEmpty(noTelp) || string.IsNullOrEmpty(alamat))
            {
                MessageBox.Show("Data tidak lengkap", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    koneksi.Open();
                    string query = "UPDATE Tamu SET nama_tamu = @nm, no_telp = @tlp, alamat = @al WHERE id_tamu = @id";
                    SqlCommand cmd = new SqlCommand(query, koneksi);
                    cmd.Parameters.AddWithValue("@nm", nmTamu);
                    cmd.Parameters.AddWithValue("@tlp", noTelp);
                    cmd.Parameters.AddWithValue("@al", alamat);
                    cmd.Parameters.AddWithValue("@id", idTamu);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil diupdate", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewTamu.DataSource = GetTamuData();
                    refreshform();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string idTamu = tbIdTamu.Text;

            if (string.IsNullOrEmpty(idTamu))
            {
                MessageBox.Show("Isi ID Tamu yang akan dihapus", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        koneksi.Open();
                        string query = "DELETE FROM Tamu WHERE id_tamu = @id";
                        SqlCommand cmd = new SqlCommand(query, koneksi);
                        cmd.Parameters.AddWithValue("@id", idTamu);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewTamu.DataSource = GetTamuData();
                        refreshform();
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
        }
    }
}
