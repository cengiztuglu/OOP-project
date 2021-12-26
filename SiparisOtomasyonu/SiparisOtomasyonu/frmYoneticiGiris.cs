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
    public partial class frmYoneticiGiris : Form
    {
        public frmYoneticiGiris()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HSOIO2VO\\SQLEXPRESS;Initial Catalog=Odev;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select Ad,Soyad,Kadi,Sifre from tbl_Yonetici where kadi=@k1 and Sifre=@k2", conn);
            cmd1.Parameters.AddWithValue("@k1", txtKadi.Text);
            cmd1.Parameters.AddWithValue("@k2", txtSifre.Text);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                frmYoneticiKontrol frm1 = new frmYoneticiKontrol();
                frm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış giriş yaptınız");
            }
            conn.Close();

        }
    }
}
