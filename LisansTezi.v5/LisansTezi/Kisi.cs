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
    public partial class Kisi : Form
    {
        public Kisi()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source = OEM\\SQLEXPRESS;Initial Catalog = tez; Integrated Security = True");

        private void Kisi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tezDataSet9.tbl_kisi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_kisiTableAdapter.Fill(this.tezDataSet9.tbl_kisi);
            // TODO: This line of code loads data into the 'tez_v2DataSet12.tbl_kisi' table. You can move, or remove it, as needed.
            
           
             SqlCommand komut = new SqlCommand("SELECT isıd,ispaketiid,İs,[Kişi Ad] From tbl_is INNER JOIN tbl_kisi ON tbl_is.kisiıd=tbl_kisi.kisiid ", baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
     

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_kisi ([Kişi Ad]) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            
            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kişi Eklendi!");
            this.tbl_kisiTableAdapter.Fill(this.tezDataSet9.tbl_kisi);

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int kayitsayisi;
            kayitsayisi = dataGridView1.RowCount;
            label1.Text = kayitsayisi.ToString();
            if(kayitsayisi>1)
            {
                label1.Text = bunifuCustomDataGrid2.CurrentRow.Cells[0].Value.ToString();
                MessageBox.Show("Silmek İstediğiniz Kişiye Ait İş Bulunmaktadır!");
            }
            else
            {
                baglanti.Open();

                SqlCommand komutsil = new SqlCommand("delete from tbl_kisi where kisiid=@k1", baglanti);
                komutsil.Parameters.AddWithValue("@k1", comboBox2.Text);

                komutsil.ExecuteNonQuery();
                baglanti.Close();


                MessageBox.Show("Kişi Silindi!");
                this.tbl_kisiTableAdapter.Fill(this.tezDataSet9.tbl_kisi);
            }
          
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz İsimi Seçinizi!");

            }
            else
            {
                SqlConnection baglanti = new SqlConnection("Data Source = SERKAN\\SQLEXPRESS; Initial Catalog = tez_v2; Integrated Security = True");
                baglanti.Open();
                SqlCommand komutgüncelle = new SqlCommand("update tbl_kisi set [Kişi Ad]=@a1   where kisiid=@a2", baglanti);
                komutgüncelle.Parameters.AddWithValue("@a1", textBox1.Text);
                komutgüncelle.Parameters.AddWithValue("@a2", comboBox2.Text);
          
                komutgüncelle.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Güncelleme Başarılı!");
                this.tbl_kisiTableAdapter.Fill(this.tezDataSet9.tbl_kisi);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT isıd,İs,[Kişi Ad],kisiid From tbl_is INNER JOIN tbl_kisi ON tbl_is.kisiıd=tbl_kisi.kisiid where kisiid=@p1 ", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBox2.Text);
            SqlDataAdapter ara = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            ara.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
            int kayitsayisi;
            kayitsayisi = dataGridView1.RowCount;
            label1.Text = kayitsayisi.ToString();
        }

        private void bunifuCustomDataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = bunifuCustomDataGrid2.CurrentRow.Cells[1].Value.ToString();
            //comboBox1.Text = textBox1.Text;
        }

        private void gunaControlBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
