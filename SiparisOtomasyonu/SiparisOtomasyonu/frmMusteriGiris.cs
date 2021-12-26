using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SiparisOtomasyonu
{
    public partial class frmMusteriGiris : Form
    {
        public frmMusteriGiris()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HSOIO2VO\\SQLEXPRESS;Initial Catalog=Odev;Integrated Security=True");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            conn.Open();
            Customer c = new Customer();
            c.Ckadi = txtKadi.Text;
            c.Cpassword = txtSifre.Text;
            SqlCommand cmd1 = new SqlCommand("Select MusterıId,Ad,Soyad,KAdi,Sifre from tblMusteri where KAdi=@k1 and Sifre=@k2", conn);
            cmd1.Parameters.AddWithValue("@k1", c.Ckadi);
            cmd1.Parameters.AddWithValue("@k2", c.Cpassword);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                frmMusteriPanel frm = new frmMusteriPanel();
                label3.Text = dr1["Ad"].ToString() + " " + dr1["soyad"].ToString();
         
                frm.ad = label3.Text;
                frm.musteriId = dr1["MusterıId"].ToString(); 
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış giriş yaptınız");
            }
            conn.Close();
        }

       

        private void frmMusteriGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            frmKayit frm1 = new frmKayit();
            frm1.Show();
            this.Hide();


        }
    }
}
