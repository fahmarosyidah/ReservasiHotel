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
            // TODO: This line of code loads data into the 'hotelDataSet4.Reservasi' table. You can move, or remove it, as needed.
            this.reservasiTableAdapter.Fill(this.hotelDataSet4.Reservasi);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormReservasi fr = new FormReservasi();
            fr.Show();
            this.Hide();
        }
    }
}
