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
    public partial class frmcek : Form
    {
        public frmcek()
        {
            InitializeComponent();
        }
        public int MusteriId;
        public decimal tutar;
        private void frmcek_Load(object sender, EventArgs e)
        {
            label3.Text = MusteriId.ToString();
            txttutar.Text = tutar.ToString();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HSOIO2VO\\SQLEXPRESS;Initial Catalog=Odev;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            Check ck = new Check();
            ck.BankId = txtbankaNo.Text;
            SqlCommand cmd = new SqlCommand("select * from tblcek where MusteriId=@p1 and BankaId=@p2",conn);

            cmd.Parameters.AddWithValue("@p1", Convert.ToInt32( label3.Text));
            cmd.Parameters.AddWithValue("@p2", ck.BankId);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            decimal goster = 0;
            if (dr.Read())
            {
                decimal bakiye = Convert.ToDecimal(dr["Limit"].ToString());

                ck.Amount = bakiye;
                goster = ck.Pay(tutar);
                checkBox1.Checked = ck.Authorized();
                MessageBox.Show("Senetle Ödeme Başarılı");
            }
            else
            {
                MessageBox.Show("Senetle ödeme Başarısız Tekrar Deneyin");
                goto a;
            }
            dr.Close();
            SqlCommand cmd1 = new SqlCommand("Update tblcek set Limit=@k1 where BankaId=@k2 and MusteriId=@k3", conn);
            cmd1.Parameters.AddWithValue("@k2", ck.BankId);
            cmd1.Parameters.AddWithValue("@k1", goster);
            cmd1.Parameters.AddWithValue("@k3", Convert.ToInt32(label3.Text));

            cmd1.ExecuteNonQuery();
            a:
            conn.Close();
            
        }
    }
}
