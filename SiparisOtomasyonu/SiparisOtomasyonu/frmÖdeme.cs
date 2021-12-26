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
    public partial class frmÖdeme : Form
    {
        public frmÖdeme()
        {
            InitializeComponent();
        }

        public decimal ucret;
        public decimal Mid;
        private void frmÖdeme_Load(object sender, EventArgs e)
        {
            label1.Text = ucret.ToString();
            label2.Text = Mid.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKredi frm1 = new frmKredi();
            frm1.ucret = Convert.ToDecimal(label1.Text);
            panel1.Controls.Clear();
            frm1.MdiParent = this;
            panel1.Controls.Add(frm1);
            frm1.FormBorderStyle = FormBorderStyle.None;

            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNakit frm = new frmNakit();
           
            frm.MusteriId = Convert.ToInt32(label2.Text);
            frm.ucret1 = Convert.ToDecimal(label1.Text);
            
            panel1.Controls.Clear();
            frm.MdiParent = this;
            panel1.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;

            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmcek frm2 = new frmcek();
            frm2.MusteriId = Convert.ToInt32(label2.Text);
            frm2.tutar = Convert.ToDecimal(label1.Text);
            frm2.Show();
            this.Hide();
        }
    }
}
