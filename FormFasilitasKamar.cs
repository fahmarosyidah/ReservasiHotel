using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReservasiHotel
{
    public partial class FasilitasKamar : Form
    {
        private string stringConnection = "data source = DESKTOP-TV0IMN6\\FAHMA_ROSYI; database = Hotel; User ID = sa; password = 123";
        private SqlConnection koneksi;

        public FasilitasKamar()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            dataGridViewFasilitasKamar.Visible = true;
        }

        private void FasilitasKamar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet9.Fasilitas' table. You can move, or remove it, as needed.
            this.fasilitasTableAdapter.Fill(this.hotelDataSet9.Fasilitas);

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            DataFasilitas df = new DataFasilitas();
            df.Show();
            this.Hide();
        }
    }
}
