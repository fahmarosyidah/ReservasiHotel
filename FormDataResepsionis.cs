using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReservasiHotel
{
    public partial class FormDataResepsionis : Form
    {
        private string stringConnection = "data source = DESKTOP-TV0IMN6\\FAHMA_ROSYI; database = Hotel; User ID = sa; password = 123";
        private SqlConnection koneksi;

        private void refreshform()
        {
            tbIdRsp.Text = null;
            tbNamaRsp.Text = null;
            tbNoTelp.Text = null;
            rbAlamat.Text = null;
            btnAdd.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        public FormDataResepsionis()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            dataGridViewRsp.Visible = false;
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_petugas, nama_petugas, no_telp, alamat from dbo.Resepsionis";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewRsp.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void FormDataResepsionis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet2.Resepsionis' table. You can move, or remove it, as needed.
            this.resepsionisTableAdapter.Fill(this.hotelDataSet2.Resepsionis);

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            dataGridViewRsp.Visible = true;
            btnAdd.Enabled = true;
            btnOpen.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbIdRsp.Enabled = true;
            tbIdRsp.Text = "";
            tbNamaRsp.Enabled = true;
            tbNamaRsp.Text = "";
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
            string idRsp = tbIdRsp.Text;
            string nmRsp = tbNamaRsp.Text;
            string noTelp = tbNoTelp.Text;
            string alamat = rbAlamat.Text;

            if (idRsp == "")
            {
                MessageBox.Show("Masukkan Id Resepsionis", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nmRsp == "")
            {
                MessageBox.Show("Masukkan Nama Resepsionis", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string str = "insert into dbo.Resepsionis (id_petugas, nama_petugas, no_telp, alamat)" + "values(@id, @nm, @tlp, @al)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id", idRsp));
                cmd.Parameters.Add(new SqlParameter("nm", nmRsp));
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
