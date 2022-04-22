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
    public partial class İs : Form
    {
        public İs()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = OEM\\SQLEXPRESS;Initial Catalog = tez; Integrated Security = True");
        void listele()

        {
            SqlCommand komut = new SqlCommand("SELECT isıd,[Proje Adı],İspaketi,İs,[Kişi Ad],Başlangıç,Bitiş,Önem From tbl_is INNER JOIN tbl_kisi ON tbl_is.kisiıd=tbl_kisi.kisiid INNER JOIN tbl_proje ON tbl_is.[Proje Kodu]=tbl_proje.[Proje Kodu] INNER JOIN tbl_ispaketi ON tbl_is.[ispaketiid]=tbl_ispaketi.[ispaketiıd]  ", baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuCustomDataGrid2.DataSource = dt;
            dataGridView1.DataSource = dt;
           // this.bunifuCustomDataGrid2.Columns["ispaketiid"].Visible = false;
            

        }
        private void İs_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tezDataSet8.tbl_kisi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_kisiTableAdapter.Fill(this.tezDataSet8.tbl_kisi);
            // TODO: Bu kod satırı 'tezDataSet7.tbl_ispaketi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_ispaketiTableAdapter.Fill(this.tezDataSet7.tbl_ispaketi);
            // TODO: Bu kod satırı 'tezDataSet6.tbl_proje' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_projeTableAdapter.Fill(this.tezDataSet6.tbl_proje);
            // TODO: Bu kod satırı 'tezDataSet5.tbl_proje' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_projeTableAdapter.Fill(this.tezDataSet5.tbl_proje);



            SqlCommand komut = new SqlCommand("SELECT isıd,[Proje Adı],İspaketi,İs,[Kişi Ad],Başlangıç,Bitiş,Önem From tbl_is INNER JOIN tbl_kisi ON tbl_is.kisiıd=tbl_kisi.kisiid INNER JOIN tbl_proje ON tbl_is.[Proje Kodu]=tbl_proje.[Proje Kodu] INNER JOIN tbl_ispaketi ON tbl_is.[ispaketiid]=tbl_ispaketi.[ispaketiıd]  ", baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuCustomDataGrid2.DataSource = dt;
             dataGridView1.DataSource = dt;
            //this.bunifuCustomDataGrid2.Columns["ispaketiid"].Visible = false;

            bunifuCustomDataGrid2.Columns[0].Visible = false;



        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut=new SqlCommand("insert into tbl_is (İs,ispaketiid,kisiıd,[Proje Kodu]) values (@p1,@p2,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", comboBox1.Text);
           // komut.Parameters.AddWithValue("@p3", comboİspaketi.Text);
            komut.Parameters.AddWithValue("@p4", comboBox3.Text);
            komut.Parameters.AddWithValue("@p5", comboBox10.Text);
           
            komut.ExecuteNonQuery();
            
            baglanti.Close();
            MessageBox.Show("İş Eklendi!");
            listele();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            SqlCommand komutsil = new SqlCommand("delete from tbl_is where isıd=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", bunifuCustomDataGrid2.CurrentRow.Cells[0].Value.ToString());
            komutsil.ExecuteNonQuery();
            komutsil.ExecuteNonQuery();
            baglanti.Close();

           
            MessageBox.Show("İş  Silindi!");
            textBox1.Text = "";
            listele();
           // this.tbl_isTableAdapter.Fill(this.lisansteziDataSet30.tbl_is);
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutgüncelle = new SqlCommand("update tbl_is set İs=@a1, kisiıd=@a3,[Proje Kodu]=@a4 ispaketiıd=@a5  where isıd=@a2", baglanti);
            komutgüncelle.Parameters.AddWithValue("@a1", textBox1.Text);
            komutgüncelle.Parameters.AddWithValue("@a2", bunifuCustomDataGrid2.CurrentRow.Cells[0].Value.ToString());
            komutgüncelle.Parameters.AddWithValue("@a3", comboBox3.Text);
            komutgüncelle.Parameters.AddWithValue("@a4", comboBox10.Text);
            komutgüncelle.Parameters.AddWithValue("@a5", comboBox1.Text);
            // komutgüncelle.Parameters.AddWithValue("@a2", bunifuCustomDataGrid2.CurrentRow.Cells[3].Value.ToString());


            komutgüncelle.ExecuteNonQuery();
            baglanti.Close();
           
            MessageBox.Show("İş Güncellendi!");
            listele();

        }

        private void bunifuCustomDataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // comboİspaketi.Text=bunifuCustomDataGrid2.CurrentRow.Cells[1].Value.ToString();
            textBox1.Text = bunifuCustomDataGrid2.CurrentRow.Cells[3].Value.ToString();
            comboBox2.Text = bunifuCustomDataGrid2.CurrentRow.Cells[4].Value.ToString();
            comboİspaketi.Text = bunifuCustomDataGrid2.CurrentRow.Cells[2].Value.ToString();
            comboBox4.Text = bunifuCustomDataGrid2.CurrentRow.Cells[1].Value.ToString();
            /* SqlCommand kom = new SqlCommand("Select *From tbl_ispaketi where projeadı='" + comboBox4.Text + "' ", baglanti);
             SqlDataAdapter daa = new SqlDataAdapter(kom);
             DataTable d = new DataTable();
             daa.Fill(d);
             comboİspaketi.ValueMember = bunifuCustomDataGrid2.CurrentRow.Cells[3].Value.ToString();
             comboİspaketi.DisplayMember = "İspaketi";
             comboİspaketi.DataSource = d;*/




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kisi kisiler = new Kisi();
            this.Hide();
            kisiler.ShowDialog();
            this.Show();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)

        {
           
            
            SqlCommand kom = new SqlCommand("Select *From tbl_ispaketi where projeadı='"+comboBox4.Text+"' ", baglanti);
            SqlDataAdapter daa = new SqlDataAdapter(kom);
            DataTable d = new DataTable();
            daa.Fill(d);
            comboİspaketi.ValueMember = "ispaketiıd";
            comboİspaketi.DisplayMember = "İspaketi";
            comboİspaketi.DataSource = d;
            comboBox6.Text = comboBox4.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboİspaketi.Text = comboBox5.Text;
            comboBox4.Text = comboBox6.Text;
          /* baglanti.Open();

            SqlCommand komut = new SqlCommand("Select *from tbl_ispaketi where ispaketiıd like '%" + comboBox1.Text + "%'", baglanti);
            SqlDataAdapter ara = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            ara.Fill(ds);
            bunifuCustomDataGrid2.DataSource = ds.Tables[0];
            baglanti.Close();*/

           
        }

        private void comboİspaketi_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           iskisi iskis = new iskisi();

            this.Hide();
            iskis.ShowDialog();
            this.Show();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

            baglanti.Open();
             
            SqlCommand komut = new SqlCommand("SELECT [Proje Adı],İspaketi,İs,[Kişi Ad],Başlangıç,Bitiş,Önem From tbl_is INNER JOIN tbl_kisi ON tbl_is.kisiıd=tbl_kisi.kisiid INNER JOIN tbl_proje ON tbl_is.[Proje Kodu]=tbl_proje.[Proje Kodu] INNER JOIN tbl_ispaketi ON tbl_is.[ispaketiid]=tbl_ispaketi.[ispaketiıd]  where ispaketi like '%" + comboBox5.Text + "%'", baglanti);

            //SqlCommand komut = new SqlCommand("Select *from tbl_ispaketi where ispaketi like '%" + comboİspaketi.Text + "%'", baglanti);
             
            SqlDataAdapter ara = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            ara.Fill(ds);
            bunifuCustomDataGrid2.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox2.Text = "";
            textBox1.Text = "";
            SqlCommand komut = new SqlCommand("SELECT isıd,[Proje Adı],İspaketi,İs,[Kişi Ad],Başlangıç,Bitiş,Önem From tbl_is INNER JOIN tbl_kisi ON tbl_is.kisiıd=tbl_kisi.kisiid INNER JOIN tbl_proje ON tbl_is.[Proje Kodu]=tbl_proje.[Proje Kodu] INNER JOIN tbl_ispaketi ON tbl_is.[ispaketiid]=tbl_ispaketi.[ispaketiıd]  ", baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuCustomDataGrid2.DataSource = dt;
            dataGridView1.DataSource = dt;
            //this.bunifuCustomDataGrid2.Columns["ispaketiid"].Visible = false;

            bunifuCustomDataGrid2.Columns[0].Visible = false;
        }
    }
}
