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
    public partial class iskisi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source = OEM\\SQLEXPRESS;Initial Catalog = tez; Integrated Security = True");
        public iskisi()
        {
            InitializeComponent();
        }
        void listele()

        {
          /*  SqlCommand komut = new SqlCommand("SELECT isıd,İs,[Kişi Ad],ispaketiid From tbl_is INNER JOIN tbl_kisi ON tbl_is.kisiid=tbl_kisi.kisiıd ", baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView1.DataSource = dt;
            this.dataGridView2.Columns["ispaketiid"].Visible = false;*/


        }

        private void iskisi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tezDataSet10.tbl_kisi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_kisiTableAdapter.Fill(this.tezDataSet10.tbl_kisi);
            // TODO: This line of code loads data into the 'tez_v2DataSet18.tbl_kisi' table. You can move, or remove it, as needed.
            // this.tbl_kisiTableAdapter.Fill(this.tez_v2DataSet18.tbl_kisi);
            // TODO: This line of code loads data into the 'tez_v2DataSet17.tbl_is' table. You can move, or remove it, as needed.
            //this.tbl_isTableAdapter.Fill(this.tez_v2DataSet17.tbl_is);
            // TODO: This line of code loads data into the 'tez_v2DataSet16.tbl_is' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'tez_v2DataSet14.tbl_is' table. You can move, or remove it, as needed.
            SqlCommand komut = new SqlCommand("SELECT isıd,İs,[Kişi Ad],ispaketiid From tbl_is INNER JOIN tbl_kisi ON tbl_is.kisiıd=tbl_kisi.kisiid ", baglanti);

               SqlDataAdapter da = new SqlDataAdapter(komut);
               DataTable dt = new DataTable();
               da.Fill(dt);
               dataGridView2.DataSource = dt;
               dataGridView1.DataSource = dt;
               this.dataGridView2.Columns["ispaketiid"].Visible = false;

               dataGridView2.Columns[0].Visible = false;

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT isıd,İs,[Kişi Ad],ispaketiid From tbl_is INNER JOIN tbl_kisi ON tbl_is.kisiıd=tbl_kisi.kisiid  where İs like '%" + textBox1.Text + "%'", baglanti);
            

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView1.DataSource = dt;
            this.dataGridView2.Columns["ispaketiid"].Visible = false;

            dataGridView2.Columns[0].Visible = false;
            baglanti.Close();



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT isıd,İs,[Kişi Ad],ispaketiid From tbl_is INNER JOIN tbl_kisi ON tbl_is.kisiıd=tbl_kisi.kisiid  where [Kişi Ad] like '%" + textBox2.Text + "%'", baglanti);


            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView1.DataSource = dt;
            this.dataGridView2.Columns["ispaketiid"].Visible = false;

            dataGridView2.Columns[0].Visible = false;
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT isıd,İs,[Kişi Ad],ispaketiid From tbl_is INNER JOIN tbl_kisi ON tbl_is.kisiıd=tbl_kisi.kisiid  where [Kişi Ad] like '%" + comboBox1.Text + "%'", baglanti);


            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView1.DataSource = dt;
            this.dataGridView2.Columns["ispaketiid"].Visible = false;

            dataGridView2.Columns[0].Visible = false;
            baglanti.Close();
        }
    }
}
