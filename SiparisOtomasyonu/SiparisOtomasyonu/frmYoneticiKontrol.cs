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
    public partial class frmYoneticiKontrol : Form
    {
        public frmYoneticiKontrol()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmUrunEkle frm = new frmUrunEkle();
            panel2.Controls.Clear();
            frm.MdiParent = this;
            panel2.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
           

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            frmUrunSil frm1 = new frmUrunSil();
            panel2.Controls.Clear();
            frm1.MdiParent = this;
            panel2.Controls.Add(frm1);
            frm1.FormBorderStyle = FormBorderStyle.None;

            frm1.Show();
           
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmUrunGuncelle frm2 = new frmUrunGuncelle();
            panel2.Controls.Clear();
            frm2.MdiParent = this;
            panel2.Controls.Add(frm2);
            frm2.FormBorderStyle = FormBorderStyle.None;
            frm2.Show();
           


        }

        private void btnTakip_Click(object sender, EventArgs e)
        {
            frmMusteriTakip frm3 = new frmMusteriTakip();
            panel2.Controls.Clear();
            frm3.MdiParent = this;
            panel2.Controls.Add(frm3);
            frm3.FormBorderStyle = FormBorderStyle.None;
            frm3.Show();
           


        }

        private void frmYoneticiKontrol_Load(object sender, EventArgs e)
        {

        }

    }
}
