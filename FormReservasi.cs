using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasiHotel
{
    public partial class FormReservasi : Form
    {
        public FormReservasi()
        {
            InitializeComponent();
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
    }
}
