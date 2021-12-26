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
    public partial class frmKayit : Form
    {
        public frmKayit()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HSOIO2VO\\SQLEXPRESS;Initial Catalog=Odev;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            Customer c = new Customer();
            c.Ckadi = txtKadi.Text;
            c.CustomerName = txtAd.Text;
            c.CustomerSurName = txtSoyad.Text;
            c.Cpassword = txtSifre.Text;
            c.Address= txtAdres.Text;
            if(c.Ckadi != "" && c.CustomerName != "" && c.CustomerSurName != "" && c.Cpassword != "" && c.Address != "")
            {
                SqlCommand cmd1 = new SqlCommand("select *from tblMusteri where Kadi=@k1", conn);
                cmd1.Parameters.AddWithValue("@k1", c.Ckadi);
                object kontrol = cmd1.ExecuteScalar();
                cmd1.Parameters.Clear();
                if (kontrol != null)
                {
                    MessageBox.Show("Böyle bir kullanici adi zaten var");
                }
                else
                {

                  SqlCommand cmd = new SqlCommand("insert into tblMusteri(KAdi,Ad,Soyad,Sifre,Adres)values(@p1,@p2,@p3,@p4,@p5) ", conn);

                    cmd.Parameters.AddWithValue("@p1", c.Ckadi);
                    cmd.Parameters.AddWithValue("@p2", c.CustomerName);
                    cmd.Parameters.AddWithValue("@p3", c.CustomerSurName);
                    cmd.Parameters.AddWithValue("@p4", c.Cpassword);
                    cmd.Parameters.AddWithValue("@p5", c.Address);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla Üye Oldunuz");
                }
            }
            else 
            {
                MessageBox.Show("Boş alan bırakmayınız");
            }

           
            
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMusteriGiris frm = new frmMusteriGiris();
            frm.Show();
            this.Hide();
        }
    }
}
