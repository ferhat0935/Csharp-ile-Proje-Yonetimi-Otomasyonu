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

namespace LisansTezi
{
    public partial class İspaketi : Form
    {
        public İspaketi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = OEM\\SQLEXPRESS;Initial Catalog = tez; Integrated Security = True");
        private void İspaketi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tezDataSet4.tbl_ispaketi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_ispaketiTableAdapter.Fill(this.tezDataSet4.tbl_ispaketi);
         
            this.tbl_projeTableAdapter.Fill(this.tezDataSet3.tbl_proje);
           
          
          
            

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_ispaketi (İspaketi,projeadı,projekodu) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", comboAd.Text);
            komut.Parameters.AddWithValue("@p3", comboBox1.Text);
            
            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("İş Paketi Eklendi!");
            this.tbl_ispaketiTableAdapter.Fill(this.tezDataSet4.tbl_ispaketi);


        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
           
            if (label2.Text=="1")
            {
                baglanti.Open();
                SqlCommand güncelle = new SqlCommand("update tbl_ispaketi set İspaketi=@a1 where ispaketiıd=@a2", baglanti);
                güncelle.Parameters.AddWithValue("@a1", textBox1.Text);
                güncelle.Parameters.AddWithValue("@a2", label1.Text);

                güncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("İş Paketi Güncellendi!");
                this.tbl_ispaketiTableAdapter.Fill(this.tezDataSet4.tbl_ispaketi);


            }
            else
            {
                baglanti.Open();

                SqlCommand komutgüncelle = new SqlCommand("update tbl_ispaketi set İspaketi=@a1 where ispaketiıd=@a2", baglanti);
                komutgüncelle.Parameters.AddWithValue("@a1", textBox1.Text);
                komutgüncelle.Parameters.AddWithValue("@a2", bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString());

                komutgüncelle.ExecuteNonQuery();
                baglanti.Close();
               /* baglanti.Open();
                SqlCommand g = new SqlCommand("update tbl_is set İspaketi=@k1 where ispaketiid=@k2", baglanti);
                g.Parameters.AddWithValue("@k1", textBox1.Text);
                g.Parameters.AddWithValue("@k2", dataGridView2.CurrentRow.Cells[2].Value.ToString());
                g.ExecuteNonQuery();
                
                baglanti.Close();*/


                MessageBox.Show("İş Paketi Güncellendi!");
                this.tbl_ispaketiTableAdapter.Fill(this.tezDataSet4.tbl_ispaketi);

            }





        }

        private void bunifuCustomDataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
            textBox1.Text= bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
            label1.Text=bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();

            SqlCommand komut = new SqlCommand("SELECT isıd,İs,ispaketiıd,İspaketi From tbl_is INNER JOIN tbl_ispaketi ON tbl_ispaketi.ispaketiıd=tbl_is.ispaketiid where ispaketiıd=@p1 ", baglanti);
            komut.Parameters.AddWithValue("@p1", label1.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            int kayitsayisi;
            kayitsayisi = dataGridView2.RowCount;
            //label3.Text = kayitsayisi.ToString();
            label2.Text = kayitsayisi.ToString();
            if (kayitsayisi > 1)
            {
                label2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            }
            if (kayitsayisi == 1)
            {
                label2.Text = "1";
            }

            for(int i=0;  i<dataGridView2.SelectedRows.Count; i++)
            {
                dataGridView2.Rows[i].Cells[1].Selected = true;
            }
            /* multi select olayını yaptıkran sonra
 
           selectionmode özelliğinide fullrowselect yap.
 
            ondan sonra
 
for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)

{

dataGridView1.SelectedRows.Cells["SERINO"].Value.ToString();

}
                           */


        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int kayitsayisi;
            kayitsayisi= dataGridView2.RowCount;
            label3.Text = kayitsayisi.ToString();
            if(kayitsayisi>1)
            {
                label3.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                MessageBox.Show("Silmek İstediğiniz İş Paketine Ait İş Bulunmaktadır!");
                this.tbl_ispaketiTableAdapter.Fill(this.tezDataSet4.tbl_ispaketi);

            }
            if (kayitsayisi==1)
            {
                label3.Text = "1";
                baglanti.Open();

                SqlCommand komutsil = new SqlCommand("delete from tbl_ispaketi where ispaketiıd=@k1", baglanti);
                komutsil.Parameters.AddWithValue("@k1", label1.Text);
                komutsil.ExecuteNonQuery();
              
                baglanti.Close();
                MessageBox.Show("İş Paketi Silindi!");
                this.tbl_ispaketiTableAdapter.Fill(this.tezDataSet4.tbl_ispaketi);

                textBox1.Text = "";

            }


        }

        private void comboAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
           
            baglanti.Open();
            SqlCommand  komut = new SqlCommand("Select *from tbl_ispaketi where projeadı like '%" + comboAd.Text + "%'", baglanti);
            SqlDataAdapter ara = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            ara.Fill(ds);
            bunifuCustomDataGrid1.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        private void bunifuCustomDataGrid2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            İs isler = new İs();
            this.Hide();
            isler.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = "";
            comboAd.Text = "";
            textBox1.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from tbl_ispaketi where projeadı like '%" + metroTextBox1.Text + "%'", baglanti);
            SqlDataAdapter ara = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            ara.Fill(ds);
            bunifuCustomDataGrid1.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from tbl_ispaketi where projeadı like '%" + metroTextBox1.Text + "%'", baglanti);
            SqlDataAdapter ara = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            ara.Fill(ds);
            bunifuCustomDataGrid1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
