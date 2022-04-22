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
    public partial class Projedüzenle : Form
    {
        public Projedüzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = OEM\\SQLEXPRESS;Initial Catalog = tez; Integrated Security = True");

        void listele()
        {
            SqlCommand komut = new SqlCommand("SELECT [Proje Kodu],[Proje Adı],Kategori,Başlangıç,Bitiş,Durum,Önem From tbl_proje INNER JOIN tbl_kategori ON tbl_proje.kategoriid=tbl_kategori.kategoriıd ", baglanti);
            // komut.Parameters.AddWithValue("@p1", labelıd.Text);
            // SqlCommand komut = new SqlCommand("SELECT kategori ad ,[Proje Kodu],[Proje Adı],Kategori From tbl_proje INNER JOIN tbl_kategori ON tbl_proje.kategoriid=tbl_kategori.kategoriıd where kategoriid like '%" + label2.Text.ToString() + "%'", baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
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

        private void Projedüzenle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tezDataSet12.tbl_proje' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_projeTableAdapter.Fill(this.tezDataSet12.tbl_proje);
            // TODO: Bu kod satırı 'tezDataSet11.tbl_proje' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           
            // TODO: Bu kod satırı 'tezDataSet5.tbl_proje' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           
            // TODO: Bu kod satırı 'tezDataSet2.tbl_kategori' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_kategoriTableAdapter.Fill(this.tezDataSet2.tbl_kategori);
            // TODO: This line of code loads data into the 'tez_v2DataSet4.tbl_proje' table. You can move, or remove it, as needed.
           
           
          
            // TODO: Bu kod satırı 'lisansteziDataSet19.tbl_kategori' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            /* SqlCommand komut = new SqlCommand("SELECT ispaketiad,projeadı,[Proje Adı],[Proje Kodu],Başlangıç,Bitiş,Durum From tbl_ispaketi INNER JOIN tbl_proje ON tbl_proje.[Proje Kodu]=tbl_ispaketi.projekodu  ", baglanti);
             SqlDataAdapter da = new SqlDataAdapter(komut);
             DataTable dt = new DataTable();
             da.Fill(dt);
             // dataGridView2.DataSource = dt;
            // bunifuCustomDataGrid2.DataSource = dt;
             int kayitsayisi;
             kayitsayisi = dataGridView2.RowCount;
             label3.Text = kayitsayisi.ToString();
             if (kayitsayisi > 1)
             {
                 label3.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
             }
             if (kayitsayisi == 1)
             {
                 label3.Text = "1";
             }*/

            SqlCommand komut = new SqlCommand("SELECT [Proje Kodu],[Proje Adı],Kategori,Başlangıç,Bitiş,Durum,Önem From tbl_proje INNER JOIN tbl_kategori ON tbl_proje.kategoriid=tbl_kategori.kategoriıd ", baglanti);
           // komut.Parameters.AddWithValue("@p1", labelıd.Text);
            // SqlCommand komut = new SqlCommand("SELECT kategori ad ,[Proje Kodu],[Proje Adı],Kategori From tbl_proje INNER JOIN tbl_kategori ON tbl_proje.kategoriid=tbl_kategori.kategoriıd where kategoriid like '%" + label2.Text.ToString() + "%'", baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
            bunifuCustomDataGrid1.Columns[0].Visible = false;
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

        private void butonkaydet_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Değişiklikleri Kaydetmek İstiyormusunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes && txtad.Text == string.Empty || cmbkatagori.Text == string.Empty || bunifuRating1.Value == 0 || label1.Text == "")

            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");

               
            }
            if (secenek == DialogResult.Yes && txtad.Text != string.Empty && cmbkatagori.Text != string.Empty && bunifuRating1.Value != 0 && label1.Text != "")
            {
                if (dateTimePicker2.Value > dateTimePicker1.Value)
                {
                    DateTime d1;
                    DateTime d2;
                    d1 = Convert.ToDateTime(dateTimePicker2.Value); //bitiş
                    d2 = Convert.ToDateTime(dateTimePicker3.Value);  //bugün
                    TimeSpan ts = d1 - d2;
                    if(ts.Days>0)
                    {
                        baglanti.Open();
                        // label1.Text = "Onay Bekleniyor";
                        SqlCommand komut = new SqlCommand("insert into tbl_proje ([proje adı],başlangıç,bitiş,durum,önem,kategoriid,[kalan gün]) values (@p1,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
                        komut.Parameters.AddWithValue("@p1", txtad.Text);
                        // komut.Parameters.AddWithValue("@p2", cmbkatagori.Text);
                        komut.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
                        komut.Parameters.AddWithValue("@p4", dateTimePicker2.Value);
                        komut.Parameters.AddWithValue("@p5", label1.Text);
                        komut.Parameters.AddWithValue("@p6", bunifuRating1.Value);
                        komut.Parameters.AddWithValue("@p7", comboBox2.Text);
                        komut.Parameters.AddWithValue("@p8", ts.Days);



                        komut.ExecuteNonQuery();


                        baglanti.Close();
                        MessageBox.Show("Proje Eklendi");
                        this.tbl_projeTableAdapter.Fill(this.tezDataSet12.tbl_proje);
                        listele();
                    }
                    if(ts.Days<0)
                    {
                        label5.Text = "0";
                        baglanti.Open();
                        // label1.Text = "Onay Bekleniyor";
                        SqlCommand komut = new SqlCommand("insert into tbl_proje ([proje adı],başlangıç,bitiş,durum,önem,kategoriid,[kalan gün]) values (@p1,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
                        komut.Parameters.AddWithValue("@p1", txtad.Text);
                        // komut.Parameters.AddWithValue("@p2", cmbkatagori.Text);
                        komut.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
                        komut.Parameters.AddWithValue("@p4", dateTimePicker2.Value);
                        komut.Parameters.AddWithValue("@p5", label1.Text);
                        komut.Parameters.AddWithValue("@p6", bunifuRating1.Value);
                        komut.Parameters.AddWithValue("@p7", comboBox2.Text);
                        komut.Parameters.AddWithValue("@p8", label5.Text);



                        komut.ExecuteNonQuery();


                        baglanti.Close();
                        MessageBox.Show("Proje Eklendi");
                        this.tbl_projeTableAdapter.Fill(this.tezDataSet12.tbl_proje);
                        listele();
                    }
                   




                }
                if (dateTimePicker2.Value < dateTimePicker1.Value)
                {
                    MessageBox.Show("Proje bitiş tarihi baslangıç tarihinden önce olamaz!");
                   
                }


                

            }
        }

        private void onylabtn_Click(object sender, EventArgs e)
        {
            label1.Text = "Onaylandı";
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            label1.Text = "Askıya Alındı";
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            label1.Text = "İptal Edildi";
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            label1.Text = "Tamamlandı";
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            label1.Text = "Hazırlık Aşamasında";
        }

        private void bunifuRating1_onValueChanged(object sender, EventArgs e)
        {

            if (bunifuRating1.Value == 1)
            {
                label2.Text = Convert.ToString(1);
            }
            if (bunifuRating1.Value == 2)
            {
                label2.Text = Convert.ToString(2);
            }
            if (bunifuRating1.Value == 3)
            {
                label2.Text = Convert.ToString(3);
            }
            if (bunifuRating1.Value == 4)
            {
                label2.Text = Convert.ToString(4);
            }
            if (bunifuRating1.Value == 5)
            {
                label2.Text = Convert.ToString(5);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
            if ( txtad.Text == string.Empty || cmbkatagori.Text == string.Empty || bunifuRating1.Value==0)
            {
                MessageBox.Show("Lütfen Silmek istediğiniz projeyi seçiniz!");
            }
           
           else
            {
                int kayitsayisi;
                kayitsayisi = dataGridView2.RowCount;
                label3.Text = kayitsayisi.ToString();
                if (kayitsayisi > 1)
                {
                    label3.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    MessageBox.Show("Silmek İstediğiniz Projeye Ait İş Paketi Bulunmaktadır!");
                }
                if (kayitsayisi == 1)
                {
                    label3.Text = "1";
                    baglanti.Open();
                    SqlCommand komutsil = new SqlCommand("delete from tbl_proje where [Proje Kodu]=@k1", baglanti);
                    komutsil.Parameters.AddWithValue("@k1", lblıdm.Text);
                    komutsil.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Silindi !");
                    this.tbl_projeTableAdapter.Fill(this.tezDataSet12.tbl_proje);
                    listele();
                }
             
                
                


            }


           
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblıdm.Text = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
            txtad.Text= bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
            //cmbkatagori.Text = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
           // comboBox2.Text= bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text= bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker2.Text = bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString();
            label1.Text = bunifuCustomDataGrid1.CurrentRow.Cells[5].Value.ToString();
            label2.Text = bunifuCustomDataGrid1.CurrentRow.Cells[6].Value.ToString();


        
           SqlCommand komut = new SqlCommand("SELECT İspaketi,projeadı,[Proje Adı],[Proje Kodu] From tbl_ispaketi INNER JOIN tbl_proje ON tbl_proje.[Proje Kodu]=tbl_ispaketi.projekodu where [Proje Kodu]=@p1 ", baglanti);
             komut.Parameters.AddWithValue("@p1", lblıdm.Text);
           // SqlCommand komut = new SqlCommand("SELECT ispaketiad,projeadı,[Proje Adı],[Proje Kodu] From tbl_ispaketi INNER JOIN tbl_proje ON tbl_proje.[Proje Kodu]=tbl_ispaketi.projekodu  ", baglanti);  
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
             dataGridView2.DataSource = dt;
           // bunifuCustomDataGrid2.DataSource = dt;
            int kayitsayisi;
            kayitsayisi = dataGridView2.RowCount;
            label3.Text = kayitsayisi.ToString();
            if (kayitsayisi > 1)
            {
                label3.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            }
            if (kayitsayisi == 1)
            {
                label3.Text = "1";
            }

            // label3.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();

            if (label2.Text == "1")
            {
                bunifuRating1.Value = 1;

            }

            if (label2.Text == "2")
            {
                bunifuRating1.Value = 2;

            }

            if (label2.Text == "3")
            {
                bunifuRating1.Value = 3;

            }

            if (label2.Text == "4")
            {
                bunifuRating1.Value = 4;

            }

            if (label2.Text == "5")
            {
                bunifuRating1.Value = 5;

            }
            if (label2.Text == "")
            {
                bunifuRating1.Value = 0;
            }


        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            int kayitsayisi;
            kayitsayisi = dataGridView2.RowCount;

            if (dateTimePicker2.Value>dateTimePicker1.Value)
            {
                if (label3.Text == "1")
                {
                    
                    DateTime d1;
                    DateTime d2;
                    d1 = Convert.ToDateTime(dateTimePicker2.Value); //bitiş
                    d2 = Convert.ToDateTime(dateTimePicker3.Value);  //bugün
                    TimeSpan ts = d1 - d2;
                    if(ts.Days>0)
                    {
                        baglanti.Open();
                        SqlCommand güncelle = new SqlCommand("update tbl_proje set [proje adı]=@a1,kategoriid=@a2,başlangıç=@a3,bitiş=@a4,önem=@a6,durum=@a7,[kalan gün]=@p8 where [Proje Kodu]=@a5", baglanti);
                        güncelle.Parameters.AddWithValue("@a1", txtad.Text);
                        güncelle.Parameters.AddWithValue("@a2", comboBox2.Text);
                        güncelle.Parameters.AddWithValue("@a3", dateTimePicker1.Value);
                        güncelle.Parameters.AddWithValue("@a4", dateTimePicker2.Value);
                        güncelle.Parameters.AddWithValue("@a5", lblıdm.Text);
                        güncelle.Parameters.AddWithValue("@a6", label2.Text);
                        güncelle.Parameters.AddWithValue("@a7", label1.Text);
                        güncelle.Parameters.AddWithValue("@p8", ts.Days);

                        güncelle.ExecuteNonQuery();
                        baglanti.Close();

                        MessageBox.Show("Güncelleme Başarılı");
                        this.tbl_projeTableAdapter.Fill(this.tezDataSet12.tbl_proje);
                        listele();
                    }
                    if(ts.Days<0)
                    {
                        label5.Text = "0";
                        baglanti.Open();
                        SqlCommand güncelle = new SqlCommand("update tbl_proje set [proje adı]=@a1,kategoriid=@a2,başlangıç=@a3,bitiş=@a4,önem=@a6,durum=@a7,[kalan gün]=@p8 where [Proje Kodu]=@a5", baglanti);
                        güncelle.Parameters.AddWithValue("@a1", txtad.Text);
                        güncelle.Parameters.AddWithValue("@a2", comboBox2.Text);
                        güncelle.Parameters.AddWithValue("@a3", dateTimePicker1.Value);
                        güncelle.Parameters.AddWithValue("@a4", dateTimePicker2.Value);
                        güncelle.Parameters.AddWithValue("@a5", lblıdm.Text);
                        güncelle.Parameters.AddWithValue("@a6", label2.Text);
                        güncelle.Parameters.AddWithValue("@a7", label1.Text);
                        güncelle.Parameters.AddWithValue("@p8", label5.Text);

                        güncelle.ExecuteNonQuery();
                        baglanti.Close();

                        MessageBox.Show("Güncelleme Başarılı");
                        this.tbl_projeTableAdapter.Fill(this.tezDataSet12.tbl_proje);
                        listele();
                    }
                  
                }
                else
                {
                    DateTime d1;
                    DateTime d2;
                    d1 = Convert.ToDateTime(dateTimePicker2.Value); //bitiş
                    d2 = Convert.ToDateTime(dateTimePicker3.Value);  //bugün
                    TimeSpan ts = d1 - d2;
                    if(ts.Days>0)
                    {
                       
                        baglanti.Open();
                        SqlCommand komutgüncelle = new SqlCommand("update tbl_proje set [proje adı]=@a1,kategoriid=@a2,başlangıç=@a3,bitiş=@a4,önem=@a6,durum=@a7,[kalan gün]=@p8 where [Proje Kodu]=@a5", baglanti);
                        komutgüncelle.Parameters.AddWithValue("@a1", txtad.Text);
                        komutgüncelle.Parameters.AddWithValue("@a2", comboBox2.Text);
                        komutgüncelle.Parameters.AddWithValue("@a3", dateTimePicker1.Value);
                        komutgüncelle.Parameters.AddWithValue("@a4", dateTimePicker2.Value);
                        komutgüncelle.Parameters.AddWithValue("@a5", lblıdm.Text);
                        komutgüncelle.Parameters.AddWithValue("@a6", label2.Text);
                        komutgüncelle.Parameters.AddWithValue("@a7", label1.Text);
                        komutgüncelle.Parameters.AddWithValue("@p8", ts.Days);

                        komutgüncelle.ExecuteNonQuery();
                        baglanti.Close();

                        baglanti.Open();
                        SqlCommand g = new SqlCommand("update tbl_ispaketi set projeadı=@k1 where projekodu=@k2", baglanti);
                        g.Parameters.AddWithValue("@k1", txtad.Text);
                        g.Parameters.AddWithValue("@k2", dataGridView2.CurrentRow.Cells[3].Value.ToString());
                        g.ExecuteNonQuery();



                        baglanti.Close();

                        MessageBox.Show("Güncelleme Başarılı");
                        this.tbl_kategoriTableAdapter.Fill(this.tezDataSet2.tbl_kategori);
                        listele();
                    }
                    if(ts.Days<0)
                    {
                        label5.Text = "0";
                        baglanti.Open();
                        SqlCommand komutgüncelle = new SqlCommand("update tbl_proje set [proje adı]=@a1,kategoriid=@a2,başlangıç=@a3,bitiş=@a4,önem=@a6,durum=@a7,[kalan gün]=@p8 where [Proje Kodu]=@a5", baglanti);
                        komutgüncelle.Parameters.AddWithValue("@a1", txtad.Text);
                        komutgüncelle.Parameters.AddWithValue("@a2", comboBox2.Text);
                        komutgüncelle.Parameters.AddWithValue("@a3", dateTimePicker1.Value);
                        komutgüncelle.Parameters.AddWithValue("@a4", dateTimePicker2.Value);
                        komutgüncelle.Parameters.AddWithValue("@a5", lblıdm.Text);
                        komutgüncelle.Parameters.AddWithValue("@a6", label2.Text);
                        komutgüncelle.Parameters.AddWithValue("@a7", label1.Text);
                        komutgüncelle.Parameters.AddWithValue("@p8", label5.Text);

                        komutgüncelle.ExecuteNonQuery();
                        baglanti.Close();

                        baglanti.Open();
                        SqlCommand g = new SqlCommand("update tbl_ispaketi set projeadı=@k1 where projekodu=@k2", baglanti);
                        g.Parameters.AddWithValue("@k1", txtad.Text);
                        g.Parameters.AddWithValue("@k2", dataGridView2.CurrentRow.Cells[3].Value.ToString());
                        g.ExecuteNonQuery();



                        baglanti.Close();


                        MessageBox.Show("Güncelleme Başarılı");
                        this.tbl_projeTableAdapter.Fill(this.tezDataSet12.tbl_proje);
                        listele();
                    }
                    
                }
              



            }
            if(dateTimePicker2.Value<dateTimePicker1.Value)
            {
                MessageBox.Show("Proje bitiş tarihi baslangıç tarihinden önce olamaz!");
               
            }
        }

        private void bunifuCustomDataGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            İspaketi islerim = new İspaketi();
         
            this.Hide();
            islerim.ShowDialog();
            this.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
