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
    public partial class frmMusteriPanel : Form
    {
        public frmMusteriPanel()
        {
            InitializeComponent();
        }

        public string ad;
        public string musteriId;
        private void frmMusteriPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'odevDataSet5.tblUrun' table. You can move, or remove it, as needed.
            this.tblUrunTableAdapter1.Fill(this.odevDataSet5.tblUrun);
            // TODO: This line of code loads data into the 'odevDataSet4.tblUrun' table. You can move, or remove it, as needed.
            this.tblUrunTableAdapter.Fill(this.odevDataSet4.tblUrun);
            label1.Text = "Hos Geldin " + ad;
            label8.Text = musteriId;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtTur.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAdi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            numericUpDown1.Maximum= Convert.ToDecimal(dataGridView1.Rows[secilen].Cells[3].Value.ToString());
            numericUpDown1.Minimum = 1;
            txtAgirlik.Text =dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            
           
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            frmSepet frm1 = new frmSepet();
            frm1.mID = musteriId;
            frm1.Show();
           
          
           
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HSOIO2VO\\SQLEXPRESS;Initial Catalog=Odev;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            Item urun = new Item();
            Order or = new Order();

            
            urun.ItemId =Convert.ToInt32(txtid.Text);
            or.OrderDate = dateTimePicker1.Value;
            
           
            urun.ItemName = txtAdi.Text;
            urun.ItemNumber = numericUpDown1.Value;

           
            urun.ItemPrice = Convert.ToDecimal(txtFiyat.Text);
            urun.ShippingWeight = Convert.ToDecimal(txtAgirlik.Text);
    
            SqlCommand cmd = new SqlCommand("insert into tblSepet(MusteriId,UrunId,UrunAd,UrunAdet,UrunFiyat,UrunAgirlik,SiparisTarih)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7) ", conn);
            cmd.Parameters.AddWithValue("@p1", label8.Text);
            cmd.Parameters.AddWithValue("@p2", urun.ItemId);
            cmd.Parameters.AddWithValue("@p3", urun.ItemName);
            cmd.Parameters.AddWithValue("@p4", urun.ItemNumber);
            cmd.Parameters.AddWithValue("@p5", urun.ItemPrice);
            cmd.Parameters.AddWithValue("@p6", urun.ShippingWeight);
            cmd.Parameters.AddWithValue("@p7", or.OrderDate);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ürün Sepete Eklendi");
            decimal toplam=0;
            decimal sonuc;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            toplam = Convert.ToDecimal(dataGridView1.Rows[secilen].Cells[3].Value.ToString());
          
            sonuc = toplam -urun.ItemNumber;


            SqlCommand cmd1 = new SqlCommand("Update tblUrun set UrunAdet=@k1 where id=@k2", conn);
            cmd1.Parameters.AddWithValue("@k2",Convert.ToInt32(txtid.Text));
            cmd1.Parameters.AddWithValue("@k1",sonuc);
            cmd1.ExecuteNonQuery();
           



            conn.Close();



        }

        private void button3_Click(object sender, EventArgs e)
        {
        
         /*   conn.Open();
            SqlCommand cmd2 = new SqlCommand("select UrunAdet from tblUrun where id=@k1", conn);
            cmd2.Parameters.AddWithValue("@k1", Convert.ToInt32( txtid.Text));

            SqlDataReader dr2 = cmd2.ExecuteReader();

            label9.Text = dr2["UrunAdet"].ToString();
           
            conn.Close();*/
        }
    }
}
