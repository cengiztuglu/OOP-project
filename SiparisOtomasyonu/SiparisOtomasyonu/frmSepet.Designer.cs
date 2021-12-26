
namespace SiparisOtomasyonu
{
    partial class frmSepet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFiyat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkdvsiz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkdvli = new System.Windows.Forms.TextBox();
            this.btnode = new System.Windows.Forms.Button();
            this.txtagirlik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttoplam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiyat
            // 
            this.btnFiyat.BackColor = System.Drawing.Color.Cyan;
            this.btnFiyat.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiyat.Location = new System.Drawing.Point(669, 383);
            this.btnFiyat.Name = "btnFiyat";
            this.btnFiyat.Size = new System.Drawing.Size(120, 27);
            this.btnFiyat.TabIndex = 1;
            this.btnFiyat.Text = "Hesapla";
            this.btnFiyat.UseVisualStyleBackColor = false;
            this.btnFiyat.Click += new System.EventHandler(this.btnFiyat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1019, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(172, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(654, 243);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "KDV\'SİZ FİYAT:";
            // 
            // txtkdvsiz
            // 
            this.txtkdvsiz.Enabled = false;
            this.txtkdvsiz.Location = new System.Drawing.Point(502, 322);
            this.txtkdvsiz.Name = "txtkdvsiz";
            this.txtkdvsiz.Size = new System.Drawing.Size(100, 22);
            this.txtkdvsiz.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "KDV DEĞERİ:";
            // 
            // txtkdvli
            // 
            this.txtkdvli.Enabled = false;
            this.txtkdvli.Location = new System.Drawing.Point(502, 406);
            this.txtkdvli.Name = "txtkdvli";
            this.txtkdvli.Size = new System.Drawing.Size(100, 22);
            this.txtkdvli.TabIndex = 5;
            // 
            // btnode
            // 
            this.btnode.BackColor = System.Drawing.Color.Cyan;
            this.btnode.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnode.Location = new System.Drawing.Point(669, 425);
            this.btnode.Name = "btnode";
            this.btnode.Size = new System.Drawing.Size(120, 28);
            this.btnode.TabIndex = 8;
            this.btnode.Text = "Öde";
            this.btnode.UseVisualStyleBackColor = false;
            this.btnode.Click += new System.EventHandler(this.btnode_Click);
            // 
            // txtagirlik
            // 
            this.txtagirlik.Enabled = false;
            this.txtagirlik.Location = new System.Drawing.Point(502, 444);
            this.txtagirlik.Name = "txtagirlik";
            this.txtagirlik.Size = new System.Drawing.Size(100, 22);
            this.txtagirlik.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "KDV\'Lİ FİYAT:";
            // 
            // txttoplam
            // 
            this.txttoplam.Enabled = false;
            this.txttoplam.Location = new System.Drawing.Point(502, 485);
            this.txttoplam.Name = "txttoplam";
            this.txttoplam.Size = new System.Drawing.Size(100, 22);
            this.txttoplam.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(282, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "KARGO VE KDV\'Lİ FİYAT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "TOPLAM KARGO AĞIRLIĞI:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(498, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "%0.18";
            // 
            // frmSepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1077, 628);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnode);
            this.Controls.Add(this.txttoplam);
            this.Controls.Add(this.txtagirlik);
            this.Controls.Add(this.txtkdvli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtkdvsiz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiyat);
            this.Name = "frmSepet";
            this.Text = "frmSepet";
            this.Load += new System.EventHandler(this.frmSepet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkdvsiz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkdvli;
        private System.Windows.Forms.Button btnode;
        private System.Windows.Forms.TextBox txtagirlik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttoplam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}