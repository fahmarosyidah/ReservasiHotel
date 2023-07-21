using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReservasiHotel
{
    public partial class FormDataHotel : Form
    {
        private string stringConnection = "data source = DESKTOP-TV0IMN6\\FAHMA_ROSYI; database = Hotel; User ID = sa; password = 123";
        private SqlConnection koneksi;

        public FormDataHotel()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            dataGridViewHotel.Visible = true;
        }

        private void FormDataHotel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet18.Hotel' table. You can move, or remove it, as needed.
            this.hotelTableAdapter1.Fill(this.hotelDataSet18.Hotel);
            // TODO: This line of code loads data into the 'hotelDataSet10.Hotel' table. You can move, or remove it, as needed.
            //this.hotelTableAdapter.Fill(this.hotelDataSet10.Hotel);
            FormDataMaster dm = new FormDataMaster();
            dm.Show();
            this.Hide();
        }
    }
}
