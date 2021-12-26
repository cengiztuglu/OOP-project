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
    public partial class frmKredi : Form
    {
        public frmKredi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HSOIO2VO\\SQLEXPRESS;Initial Catalog=Odev;Integrated Security=True");

        public decimal ucret;
        private void button1_Click(object sender, EventArgs e)
        {
            Credit cr = new Credit();
           

            conn.Open();
            SqlCommand cmd = new SqlCommand("Select KartNo,ExpDate,CVC,Tür,Bakiye from tblKredi where KartNo=@p1 and ExpDate=@p2 and CVC=@p3 and Tür=@p4 ",conn);

           

            cmd.Parameters.AddWithValue("@p1", textBox3.Text);
             cmd.Parameters.AddWithValue("@p2", textBox4.Text);
             cmd.Parameters.AddWithValue("@p3", textBox5.Text);
            cmd.Parameters.AddWithValue("@p4", comboBox1.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
            decimal tutar = Convert.ToDecimal(textBox1.Text);
            SqlDataReader dr1 = cmd.ExecuteReader();

            decimal goster = 0;
            if (dr1.Read())
             {
              decimal bakiye = Convert.ToDecimal(dr1["Bakiye"].ToString());

                cr.Amount = bakiye;
                goster=cr.Pay(tutar);
                checkBox1.Checked = cr.Authorized();
                MessageBox.Show("Siparişiniz Onaylandı 😊");


            }
            else
            {

                
                checkBox1.Checked = false;
                MessageBox.Show(" Eksik Veya Hatalı Bilgi Girdiniz 🤦‍");
                goto a;

            }
           
          
            dr1.Close();
            SqlCommand cmd1 = new SqlCommand("Update tblKredi set Bakiye=@k1 where KartNo=@k2", conn);
            cmd1.Parameters.AddWithValue("@k2", textBox3.Text);
            cmd1.Parameters.AddWithValue("@k1", goster);

            cmd1.ExecuteNonQuery();
            a:





            conn.Close();

        }

        private void frmKredi_Load(object sender, EventArgs e)
        {
            textBox1.Text = ucret.ToString();
        }
    }
}
