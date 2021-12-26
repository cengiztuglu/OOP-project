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
    public partial class frmUrunSil : Form
    {
        public frmUrunSil()
        {
            InitializeComponent();
        }

        private void frmUrunSil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'odevDataSet.tblUrun' table. You can move, or remove it, as needed.
            this.tblUrunTableAdapter.Fill(this.odevDataSet.tblUrun);
           
          

        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HSOIO2VO\\SQLEXPRESS;Initial Catalog=Odev;Integrated Security=True");

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtTür.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtÜrünAdi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtAdeti.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
           
            txtAgirlik.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            
            txtFiyat.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            
            SqlCommand sil = new SqlCommand("Delete from tblUrun Where UrunAdi=@k1 ", conn);

            sil.Parameters.AddWithValue("@k1", txtÜrünAdi.Text);
            sil.ExecuteNonQuery();
            this.tblUrunTableAdapter.Fill(this.odevDataSet.tblUrun);
            MessageBox.Show("Secilen Ürün Silindi");

            conn.Close();
           


            

            MessageBox.Show("personel Silindi");
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTür.Text = "";
            txtÜrünAdi.Text = "";
            txtFiyat.Text = "";
            txtAgirlik.Text = "";
            txtAdeti.Text = "";


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
