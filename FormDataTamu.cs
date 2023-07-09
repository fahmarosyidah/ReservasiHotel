using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReservasiHotel
{
    public partial class FormDataTamu : Form
    {
        private string stringConnection = "data source = DESKTOP-TV0IMN6\\FAHMA_ROSYI; database = Hotel; User ID = sa; password = 123";
        private SqlConnection koneksi;

        private void refreshform()
        {
            tbIdTamu.Text = null;
            tbNamaTamu.Text = null;
            tbNoTelp.Text = null;
            rbAlamat.Text = null;
            btnAdd.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        public FormDataTamu()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            dataGridViewTamu.Visible = false;
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_tamu, nama_tamu, no_telp, alamat from dbo.Tamu";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewTamu.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void FormDataTamu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet1.Tamu' table. You can move, or remove it, as needed.
            this.tamuTableAdapter.Fill(this.hotelDataSet1.Tamu);

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            dataGridViewTamu.Visible = true;
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

            if (idTamu == "")
            {
                MessageBox.Show("Masukkan Id Tamu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nmTamu == "")
            {
                MessageBox.Show("Masukkan Nama Tamu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (noTelp == "")
            {
                MessageBox.Show("Masukkan No Telpon", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (alamat == "")
            {
                MessageBox.Show("Masukkan Alamat", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Tamu (id_tamu, nama_tamu, no_telp, alamat)" + "values(@id, @nm, @tlp, @al)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id", idTamu));
                cmd.Parameters.Add(new SqlParameter("nm", nmTamu));
                cmd.Parameters.Add(new SqlParameter("tlp", noTelp));
                cmd.Parameters.Add(new SqlParameter("al", alamat));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }
    }
}
