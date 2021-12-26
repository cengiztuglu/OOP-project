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
    public partial class frmNakit : Form
    {
        public frmNakit()
        {
            InitializeComponent();
        }
        public decimal ucret1;
        public decimal MusteriId;
        public decimal goster;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HSOIO2VO\\SQLEXPRESS;Initial Catalog=Odev;Integrated Security=True");

        private void frmNakit_Load(object sender, EventArgs e)
        {
            txtbakiye.Text = "0";
            label8.Text = MusteriId.ToString();
            txtucret.Text = ucret1.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
           
           
            conn.Open();
            decimal kalantutar = Convert.ToDecimal(txtkalan.Text);
            SqlCommand cmd4 = new SqlCommand("Update tblCuzdan set Bakiye=@k1 where MusteriId=@k2",conn);
            cmd4.Parameters.AddWithValue("@k2", Convert.ToInt32(label8.Text));

            cmd4.Parameters.AddWithValue("@k1", kalantutar);
            SqlDataReader dr3 = cmd4.ExecuteReader();
            
            
          
                
            
            
            dr3.Close();
            

            conn.Close();
                
        }
        int deger;
        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select KartNo,ExpDate,CVC,Tür,Bakiye from tblKredi where KartNo=@p1 and ExpDate=@p2 and CVC=@p3 and Tür=@p4 ", conn);
            
           
            Credit cr = new Credit();
            cmd.Parameters.AddWithValue("@p1", txtKartNo.Text);
            cmd.Parameters.AddWithValue("@p2", txtsgt.Text);
            cmd.Parameters.AddWithValue("@p3", txtcvc.Text);
            cmd.Parameters.AddWithValue("@p4", cbxtür.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
           
            SqlDataReader dr1 = cmd.ExecuteReader();
            decimal tutar= Convert.ToDecimal(txttutar.Text);
            
            if (dr1.Read())
            {
                decimal bakiye = Convert.ToDecimal(dr1["Bakiye"].ToString());
              
                cr.Amount = bakiye;
                goster = cr.Pay(tutar);
                deger = 1;
                

            }
            else
            {
                MessageBox.Show("Bakiye yükleme başarısız tekrar deneyin");
                goto a;

            }
            dr1.Close();
            if (deger==1)
            {
                SqlCommand cmd1 = new SqlCommand("Insert into tblCuzdan(MusteriId,Bakiye)values(@k1,@k2)", conn);

                cmd1.Parameters.AddWithValue("@k1", Convert.ToInt32(label8.Text));
                cmd1.Parameters.AddWithValue("@k2", Convert.ToDecimal(txttutar.Text));
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Bakiye Yükleme Başarılı");
            }
       
            SqlCommand cmd2 = new SqlCommand("Update tblKredi set Bakiye=@k1 where KartNo=@k2", conn);
            cmd2.Parameters.AddWithValue("@k2", txtKartNo.Text);
            cmd2.Parameters.AddWithValue("@k1", goster);

            cmd2.ExecuteNonQuery();
        a:

            Cash ca = new Cash();

            SqlCommand cmd3 = new SqlCommand("select Bakiye from tblCuzdan where MusteriId=@c1", conn);
            cmd3.Parameters.AddWithValue("@c1", Convert.ToInt32(label8.Text));
            SqlDataReader dr2 = cmd3.ExecuteReader();
            decimal hesapla = 0;
            if (dr2.Read())
            {
                ca.CashTendered = Convert.ToDecimal(dr2["Bakiye"].ToString());
                txtbakiye.Text = ca.CashTendered.ToString();
                hesapla = ca.Pay(ucret1);



            }
            txtkalan.Text = hesapla.ToString();


            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
