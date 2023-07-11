using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReservasiHotel
{
    public partial class FormDataKamar : Form
    {
        private string stringConnection = "data source = DESKTOP-TV0IMN6\\FAHMA_ROSYI; database = Hotel; User ID = sa; password = 123";
        private SqlConnection koneksi;

        private void refreshform()
        {
            tbNoKamar.Text = null;
            cbTipeKamar.Text = null;
            tbHarga.Text = null;
            btnOpen.Enabled = true;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }

        public FormDataKamar()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            dataGridViewKamar.Visible = false;
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select no_kamar, tipe_kamar, harga_sewa from dbo.Kamar";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewKamar.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void FormDataKamar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.Kamar' table. You can move, or remove it, as needed.
            this.kamarTableAdapter.Fill(this.hotelDataSet.Kamar);
            FormDataMaster dm = new FormDataMaster();
            dm.Show();
            this.Hide();

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            dataGridViewKamar.Visible = true;
            btnAdd.Enabled = true;
            btnOpen.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbNoKamar.Enabled = true;
            tbNoKamar.Text = "";
            cbTipeKamar.Enabled = true;
            cbTipeKamar.Text = "";
            tbHarga.Enabled = true;
            tbHarga.Text = "";
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
            string noKamar = tbNoKamar.Text;
            string tipeKamar = cbTipeKamar.Text;
            string harga = tbHarga.Text;

            if (noKamar == "")
            {
                MessageBox.Show("Masukkan No Kamar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tipeKamar == "")
            {
                MessageBox.Show("Masukkan Tipe Kamar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (harga == "")
            {
                MessageBox.Show("Masukkan Harga Sewa", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Kamar (no_kamar, tipe_kamar, harga_sewa)" + "values(@no, @tp, @hrg)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("no", noKamar));
                cmd.Parameters.Add(new SqlParameter("tp", tipeKamar));
                cmd.Parameters.Add(new SqlParameter("hrg", harga));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void cbTipeKamar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipeKamar = cbTipeKamar.Text;
            decimal hargaSewa = 0;

            switch (tipeKamar)
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

        private void btnview_Click(object sender, EventArgs e)
        {
            DataFasilitas df = new DataFasilitas();
            df.Show();
            this.Hide();
        }
    }
}
