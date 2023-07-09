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
    public partial class FormDataMaster : Form
    {
        public FormDataMaster()
        {
            InitializeComponent();
        }

        private void formReservasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReservasi fr = new FormReservasi();
            fr.Show();
            this.Hide();
        }

        private void dataKamarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataKamar dk = new FormDataKamar();
            dk.Show();
            this.Hide();
        }

        private void dataResepsionisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataResepsionis dr = new FormDataResepsionis();
            dr.Show();
            this.Hide();
        }

        private void dataTamuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataTamu dt = new FormDataTamu();
            dt.Show();
            this.Hide();
        }
    }
}
