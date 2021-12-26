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
    public partial class frmUrunGuncelle : Form
    {
        public frmUrunGuncelle()
        {
            InitializeComponent();
        }

        private void frmUrunGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'odevDataSet1.tblUrun' table. You can move, or remove it, as needed.
            this.tblUrunTableAdapter.Fill(this.odevDataSet1.tblUrun);

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand upd = new SqlCommand("Update tblUrun set UrunTuru=@a1,UrunAdi=@a2,UrunAdet=@a3,UrunAgirlik=@a4,UrunFiyat=@a5 where id=@a6", conn);
            upd.Parameters.AddWithValue("@a1", txtTur.Text);
            upd.Parameters.AddWithValue("@a2", txtAdi.Text);
            upd.Parameters.AddWithValue("@a3", Convert.ToDecimal(txtAdet.Text));
            upd.Parameters.AddWithValue("@a4", Convert.ToDecimal(txtAgirlik.Text));
            upd.Parameters.AddWithValue("@a5", Convert.ToDecimal(txtFiyat.Text) );
            upd.Parameters.AddWithValue("@a6", lblid.Text);
            
            upd.ExecuteNonQuery();
            this.tblUrunTableAdapter.Fill(this.odevDataSet1.tblUrun);
            conn.Close();
            
            MessageBox.Show("Ürün bilgileri güncellendi");
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HSOIO2VO\\SQLEXPRESS;Initial Catalog=Odev;Integrated Security=True");

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtTur.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAdi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtAdet.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtAgirlik.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            lblid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
