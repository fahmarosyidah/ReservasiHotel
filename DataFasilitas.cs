using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReservasiHotel
{
    public partial class DataFasilitas : Form
    {
        private string stringConnection = "data source = DESKTOP-TV0IMN6\\FAHMA_ROSYI; database = Hotel; User ID = sa; password = 123";
        private SqlConnection koneksi;

        public DataFasilitas()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            dataGridViewFasilitas.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet16.Fasilitas_Kamar' table. You can move, or remove it, as needed.
            this.fasilitas_KamarTableAdapter1.Fill(this.hotelDataSet16.Fasilitas_Kamar);
            // TODO: This line of code loads data into the 'hotelDataSet6.Fasilitas' table. You can move, or remove it, as needed.
            this.fasilitasTableAdapter.Fill(this.hotelDataSet6.Fasilitas);
            // TODO: This line of code loads data into the 'hotelDataSet5.Fasilitas_Kamar' table. You can move, or remove it, as needed.
            this.fasilitas_KamarTableAdapter.Fill(this.hotelDataSet5.Fasilitas_Kamar);
            FormDataMaster dm = new FormDataMaster();
            dm.Show();
            this.Hide();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FasilitasKamar fk = new FasilitasKamar();
            fk.Show();
            this.Hide();
        }
    }
}
