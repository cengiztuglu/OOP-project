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
    public partial class frmSepet : Form
    {
        public frmSepet()
        {
            InitializeComponent();
        }


        public string mID;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HSOIO2VO\\SQLEXPRESS;Initial Catalog=Odev;Integrated Security=True");
        private void frmSepet_Load(object sender, EventArgs e)
        {


            conn.Open();
            label1.Text = mID;


            SqlCommand cmd = new SqlCommand("select * from tblSepet where MusteriId=@p1 ", conn);
            cmd.Parameters.AddWithValue("@p1", Convert.ToInt32(label1.Text));

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();





        }

        private void btnFiyat_Click(object sender, EventArgs e)
        {
            
            decimal saftoplam= 0;
            decimal kdvlitoplam =0;
            
            conn.Open();
            Item ıt = new Item();
          
            SqlCommand cmd1 = new SqlCommand("Select UrunAdet,UrunFiyat,UrunAgirlik from tblSepet where MusteriId=@k1 ", conn);
            cmd1.Parameters.AddWithValue("@k1", Convert.ToInt32(label1.Text));
            OrderDetail dt = new OrderDetail();
            Order or = new Order();
            SqlDataReader dr1 = cmd1.ExecuteReader();

            decimal toplamagirlik = 0;
            decimal toplamFiyat =0;

            while (dr1.Read())
            {


                dt.Item.ItemNumber = Convert.ToDecimal(dr1["UrunAdet"].ToString());
                dt.Item.ItemPrice = Convert.ToDecimal(dr1["UrunFiyat"].ToString()) ;
               
                ıt.ShippingWeight= Convert.ToDecimal(dr1["UrunAgirlik"].ToString());
                ıt.GetWeight(ıt.ShippingWeight);
                toplamagirlik +=dt.CalcWeight(ıt.ShippingWeight,dt.Item.ItemNumber);


                saftoplam += dt.Item.GetPriceForQuantity();
                
              kdvlitoplam +=dt.CalcSubTotal();

                toplamFiyat += dt.CalcSubTotal() +or.CalcTotal();



            }
            txtkdvsiz.Text = saftoplam.ToString();
            
            txtagirlik.Text = toplamagirlik.ToString();
            txtkdvli.Text = kdvlitoplam.ToString();
            txttoplam.Text = toplamFiyat.ToString();





            dr1.Close();
           
            conn.Close();
            
        }

        private void btnode_Click(object sender, EventArgs e)
        {
            frmÖdeme frm = new frmÖdeme();
            frm.ucret = Convert.ToDecimal(txttoplam.Text);
            frm.Mid = Convert.ToDecimal(label1.Text);
            
            frm.Show();          
            this.Hide();
        }
    }
}
