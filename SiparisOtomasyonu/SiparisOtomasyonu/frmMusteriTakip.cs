using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyonu
{
    public partial class frmMusteriTakip : Form
    {
        public frmMusteriTakip()
        {
            InitializeComponent();
        }

        private void frmMusteriTakip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'odevDataSet6.tblSepet' table. You can move, or remove it, as needed.
            this.tblSepetTableAdapter.Fill(this.odevDataSet6.tblSepet);

        }
    }
}
