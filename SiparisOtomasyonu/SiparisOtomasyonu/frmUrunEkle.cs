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
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }

        
        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'odevDataSet3.tblUrun' table. You can move, or remove it, as needed.
            this.tblUrunTableAdapter.Fill(this.odevDataSet3.tblUrun);

        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HSOIO2VO\\SQLEXPRESS;Initial Catalog=Odev;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            Item urun = new Item();
            urun.Description = txtTür.Text;
            urun.ItemName = txtUrunAdi.Text;
            urun.ItemNumber = Convert.ToDecimal(txtAdet.Text);
            urun.ShippingWeight = Convert.ToDecimal(txtAgırlık.Text);
            urun.ItemPrice = Convert.ToDecimal(txtFiyat.Text);

            SqlCommand cmd = new SqlCommand("insert into tblUrun(UrunTuru,UrunAdi,UrunAdet,UrunAgirlik,UrunFiyat)values(@p1,@p2,@p3,@p4,@p5) ", conn);
            cmd.Parameters.AddWithValue("@p1", urun.Description);
            cmd.Parameters.AddWithValue("@p2", urun.ItemName);
            cmd.Parameters.AddWithValue("@p3", urun.ItemNumber);
            cmd.Parameters.AddWithValue("@p4", urun.ShippingWeight);
            cmd.Parameters.AddWithValue("@p5", urun.ItemPrice);
            cmd.ExecuteNonQuery();
           
            MessageBox.Show("Ürün Eklendi");
            this.tblUrunTableAdapter.Fill(this.odevDataSet3.tblUrun);

            conn.Close();

        }
    }
}
