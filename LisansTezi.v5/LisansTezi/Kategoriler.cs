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
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source = OEM\\SQLEXPRESS;Initial Catalog = tez; Integrated Security = True");
        void temizle()
        {
            comboBox1.Text = "";
            metroTextBox1.Text = "";
            comboBox2.Text = "";



        }
        bool durum;
        void mukerrer()   //aynı isimli kategori engelleme metodu
        {
            baglanti.Open();
            SqlCommand kayit = new SqlCommand("Select *from tbl_kategori where Kategori=@p1", baglanti);
            kayit.Parameters.AddWithValue("@p1", metroTextBox1.Text);
            SqlDataReader dr = kayit.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglanti.Close();
        }

        private void Kategoriler_Load(object sender, EventArgs e)
        {
           
            this.tbl_kategoriTableAdapter1.Fill(this.tezDataSet1.tbl_kategori);
          
           // bunifuCustomDataGrid2.Columns[0].Visible = false;





        }

        private void btnkategoriekle_Click(object sender, EventArgs e)
        {
            mukerrer();
            if(durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into tbl_kategori (Kategori) values (@p1)", baglanti);
                komut.Parameters.AddWithValue("@p1", metroTextBox1.Text);
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kategori Eklendi!");

                this.tbl_kategoriTableAdapter1.Fill(this.tezDataSet1.tbl_kategori);
            }
            else
            {
                MessageBox.Show("Aynı kategori zaten mevcut!", "tbl_kategori2", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int kayitsayisi;
            kayitsayisi = dataGridView1.RowCount;
            if(kayitsayisi==1)
            {
               // metroTextBox1.Text = "";
                if(metroTextBox1.Text=="")
                {
                    MessageBox.Show("Lütfen Silmek İstediğiniz Kategoriyi Seçiniz!");
                }
                else
                {
                    baglanti.Open();

                    SqlCommand komutsil = new SqlCommand("delete from tbl_kategori where kategoriıd=@k1", baglanti);
                    komutsil.Parameters.AddWithValue("@k1", labelıd.Text);
                    komutsil.ExecuteNonQuery();

                    baglanti.Close();

                    MessageBox.Show("Kategori Silindi!");
                    this.tbl_kategoriTableAdapter1.Fill(this.tezDataSet1.tbl_kategori);
                    temizle();
                    
                }
               

            }
            else
            {
                MessageBox.Show("Silmek İstediğiniz Kategori Bir Projeye Ait!");
                this.tbl_kategoriTableAdapter1.Fill(this.tezDataSet1.tbl_kategori);
            }
            
          
           



        }

        private void bunifuCustomDataGrid2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            labelıd.Text = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBox1.Text= bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[1].Value.ToString();
           metroTextBox1.Text= bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "")
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Kategoriyi Seçiniz!");
            }
            else
            {
                baglanti.Open();
                SqlCommand komutgüncelle = new SqlCommand("update tbl_kategori set Kategori=@a1   where kategoriıd=@a2", baglanti);
                komutgüncelle.Parameters.AddWithValue("@a1", metroTextBox1.Text);
                komutgüncelle.Parameters.AddWithValue("@a2", labelıd.Text);
                // SqlCommand güncelle = new SqlCommand("update tbl_proje set kategori=@a1   where [Proje Kodu]=@a2", baglanti);
                // güncelle.Parameters.AddWithValue("@a1", metroTextBox1.Text);
                // güncelle.Parameters.AddWithValue("@a2", label2.Text);
                komutgüncelle.ExecuteNonQuery();
                // güncelle.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kategori Güncellendi!");
                this.tbl_kategoriTableAdapter1.Fill(this.tezDataSet1.tbl_kategori);
                temizle();
            }
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
              metroTextBox1.Text = comboBox2.Text;
            labelıd.Text = comboBox1.Text;

               SqlCommand komut = new SqlCommand("SELECT Kategori ,kategoriid,[Proje Kodu],[Proje Adı] From tbl_proje INNER JOIN tbl_kategori ON tbl_proje.kategoriid=tbl_kategori.kategoriıd where kategoriıd=@p1", baglanti);
               // SqlCommand komut = new SqlCommand("SELECT kategoriad,kategoriıd,[Proje Kodu],[Proje Adı] From tbl_proje INNER JOIN tbl_kategori ON tbl_proje.kategoriid=tbl_kategori.kategoriıd where kategoriıd=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", labelıd.Text);
                // SqlCommand komut = new SqlCommand("SELECT kategori ad ,[Proje Kodu],[Proje Adı],Kategori From tbl_proje INNER JOIN tbl_kategori ON tbl_proje.kategoriid=tbl_kategori.kategoriıd where kategoriid like '%" + label2.Text.ToString() + "%'", baglanti);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                int kayitsayisi;
                kayitsayisi = dataGridView1.RowCount;
                if (kayitsayisi > 1)
                {
                    label2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                }
                if (kayitsayisi == 1)
                {
                    label2.Text = "1";
                }

           


        }

        private void bunifuCustomDataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metroTextBox1.Text = comboBox1.Text;



              SqlCommand komut = new SqlCommand("SELECT Kategori,kategoriıd,[Proje Kodu],[Proje Adı] From tbl_proje INNER JOIN tbl_kategori ON tbl_proje.kategoriid=tbl_kategori.kategoriıd where kategoriıd=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", labelıd.Text);
           // SqlCommand komut = new SqlCommand("SELECT kategori ad ,[Proje Kodu],[Proje Adı],Kategori From tbl_proje INNER JOIN tbl_kategori ON tbl_proje.kategoriid=tbl_kategori.kategoriıd where kategoriid like '%" + label2.Text.ToString() + "%'", baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            int kayitsayisi;
            kayitsayisi = dataGridView1.RowCount;
            if(kayitsayisi>1)
            {
                label2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            if(kayitsayisi==1)
            {
                label2.Text = "1";
            }
           
           // label2.Text = kayitsayisi.ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroTextBox1.Text = comboBox2.Text;
        }
    }
}
