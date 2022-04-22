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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        SqlConnection baglanti = new SqlConnection("Data Source = OEM\\SQLEXPRESS;Initial Catalog = tez; Integrated Security = True");
        void listele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from tbl_proje where durum like '%" + textBox1.Text + "%' ", baglanti);
            SqlDataAdapter ara = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            ara.Fill(ds);
            bunifuCustomDataGrid1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        void yıldız()
        {
            int kayitsayisi;
            kayitsayisi = bunifuCustomDataGrid1.RowCount;
            if (kayitsayisi == 1)
            {


                label4.Text = bunifuCustomDataGrid1.Rows[0].Cells[1].Value.ToString();
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";

            }
            if (kayitsayisi == 2)
            {


                label4.Text = bunifuCustomDataGrid1.Rows[0].Cells[1].Value.ToString();
                label5.Text = bunifuCustomDataGrid1.Rows[1].Cells[1].Value.ToString();
                label6.Text = "";
                label7.Text = "";

            }
            if (kayitsayisi == 3)
            {

                label4.Text = bunifuCustomDataGrid1.Rows[0].Cells[1].Value.ToString();
                label5.Text = bunifuCustomDataGrid1.Rows[1].Cells[1].Value.ToString();
                label6.Text = bunifuCustomDataGrid1.Rows[2].Cells[1].Value.ToString();
                label7.Text = "";


            }
            if (kayitsayisi == 4)
            {

                label4.Text = bunifuCustomDataGrid1.Rows[0].Cells[1].Value.ToString();
                label5.Text = bunifuCustomDataGrid1.Rows[1].Cells[1].Value.ToString();
                label6.Text = bunifuCustomDataGrid1.Rows[2].Cells[1].Value.ToString();
                label7.Text = bunifuCustomDataGrid1.Rows[3].Cells[1].Value.ToString();


            }

        }
        private void kategoriler_Click(object sender, EventArgs e)
        {

            Kategoriler kategori = new Kategoriler();
            this.Hide();
            kategori.ShowDialog();
            this.Show();
        }

        private void projedüzenle_Click(object sender, EventArgs e)
        {
            Projedüzenle  yenisayfa = new Projedüzenle();
            this.Hide();
            yenisayfa.ShowDialog();
            this.Show();
        }

        private void görevlerim_Click(object sender, EventArgs e)
        {/*
            Görevlerim görevsayfası = new Görevlerim();
            this.Hide();
            görevsayfası.ShowDialog();
            this.Show();*/
            İspaketi islerim = new İspaketi();

            this.Hide();
            islerim.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.tbl_projeTableAdapter.Fill(this.tezDataSet.tbl_proje);
           

            DateTime d1;
            DateTime d2;
            for (int i = 0; i < bunifuCustomDataGrid1.RowCount - 1; i++)
            {
                d1 = Convert.ToDateTime(bunifuCustomDataGrid1.Rows[i].Cells[4].Value);
                d2 = Convert.ToDateTime(dateTimePicker1.Value);
                TimeSpan ts = d1 - d2;
               // bunifuCustomDataGrid1.Rows[i].Cells[7].Value = ts.Days;
               if(ts.Days<0)
                {
                  //  bunifuCustomDataGrid1.Rows[i].Cells[7].Value = 0;
                }
                if(ts.Days<7)
                

                    notifyIcon1.ShowBalloonTip(1000000000, "Bildirim", "Yaklaşan yada Süersi Geçmiş Projeleriniz Var", ToolTipIcon.Info);


                 
                
            }
          
            //textBox3.Text = Convert.ToString(textBox3.Text);
            
            metroCheckBox1.Checked = true;
            timer.Start();


        }
       
        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source = OEM\\SQLEXPRESS;Initial Catalog = tez; Integrated Security = True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from tbl_proje where [Proje Adı] like '%" + metroTextBox1.Text + "%'or durum like '%" + metroTextBox1.Text + "%'", baglanti);
            SqlDataAdapter ara = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            ara.Fill(ds);
            bunifuCustomDataGrid1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = "";
            metroCheckBox1.Checked = true;
            metroCheckBox2.Checked = false;
            metroCheckBox3.Checked = false;
            metroCheckBox4.Checked = false;
            metroCheckBox5.Checked = false;
            metroCheckBox6.Checked = false;

            SqlConnection baglanti = new SqlConnection("Data Source = OEM\\SQLEXPRESS;Initial Catalog = tez; Integrated Security = True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from tbl_proje where [Proje Adı] like '%" + metroTextBox1.Text + "%'or durum like '%" + metroTextBox1.Text + "%'", baglanti);
            SqlDataAdapter ara = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            ara.Fill(ds);
            bunifuCustomDataGrid1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void bunifuRating1_onValueChanged(object sender, EventArgs e)
        {
            if (bunifuRating1.Value == 0)
            {
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";

            }
            if (bunifuRating1.Value == 1)
            {
                textBox1.Text = "1";

            }
            if (bunifuRating1.Value == 2)
            {
                textBox1.Text = "2";

            }
            if (bunifuRating1.Value == 3)
            {
                textBox1.Text = "3";

            }
            if (bunifuRating1.Value == 4)
            {
                textBox1.Text = "4";

            }
            if (bunifuRating1.Value == 5)
            {
                textBox1.Text = "5";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (bunifuRating1.Value == 1)
            {
                textBox1.Text = "1";

            }
            if (bunifuRating1.Value == 2)
            {
                textBox1.Text = "2";

            }
            if (bunifuRating1.Value == 3)
            {
                textBox1.Text = "3";

            }
            if (bunifuRating1.Value == 4)
            {
                textBox1.Text = "4";

            }
            if (bunifuRating1.Value == 5)
            {
                textBox1.Text = "5";

            }
            SqlConnection baglanti = new SqlConnection("Data Source = OEM\\SQLEXPRESS;Initial Catalog = tez; Integrated Security = True");

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from tbl_proje where önem like '%" + textBox1.Text + "%' ", baglanti);
            SqlDataAdapter ara = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            ara.Fill(ds);
            bunifuCustomDataGrid1.DataSource = ds.Tables[0];
            baglanti.Close();
            int kayitsayisi;
            kayitsayisi = bunifuCustomDataGrid1.RowCount;
            if (kayitsayisi <= 4)
            {


                if (textBox1.Text == "1")
                {

                    yıldız();

                }
                if (textBox1.Text == "2")
                {

                    yıldız();

                }
                if (textBox1.Text == "3")
                {

                    yıldız();

                }
                if (textBox1.Text == "4")
                {

                    yıldız();

                }
                if (textBox1.Text == "5")
                {

                    yıldız();

                }
            }
            else
            {
               // label4.Text = bunifuCustomDataGrid1.Rows[0].Cells[1].Value.ToString();
               label4.Text = bunifuCustomDataGrid1.Rows[0].Cells[1].Value.ToString();
                label5.Text = bunifuCustomDataGrid1.Rows[1].Cells[1].Value.ToString();
                label6.Text = bunifuCustomDataGrid1.Rows[2].Cells[1].Value.ToString();
                label7.Text = bunifuCustomDataGrid1.Rows[3].Cells[1].Value.ToString();
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {/*  İspaketi islerim = new İspaketi();

            this.Hide();
            islerim.ShowDialog();
            this.Show();*/
            İs isler = new İs();
            this.Hide();
            isler.ShowDialog();
            this.Show();

            
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBox1.Checked==true)
            {
                textBox1.Text = "";
                metroCheckBox2.Checked = false;
                metroCheckBox3.Checked = false;
                metroCheckBox4.Checked = false;
                metroCheckBox5.Checked = false;
                metroCheckBox6.Checked = false;
            }
            
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
         if(metroCheckBox2.Checked==true)
            {
                textBox1.Text = "haz";
                listele();
                metroCheckBox1.Checked = false;
                metroCheckBox3.Checked = false;
                metroCheckBox4.Checked = false;
                metroCheckBox5.Checked = false;
                metroCheckBox6.Checked = false;
            }
             


        }

        private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBox3.Checked==true)
            {
                textBox1.Text = "onay";
                listele();
                metroCheckBox1.Checked = false;
                metroCheckBox2.Checked = false;
                metroCheckBox4.Checked = false;
                metroCheckBox5.Checked = false;
                metroCheckBox6.Checked = false;
            }
          
        }

        private void metroCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBox4.Checked==true)
            {
                textBox1.Text = "ask";
                listele();
                metroCheckBox1.Checked = false;
                metroCheckBox3.Checked = false;
                metroCheckBox2.Checked = false;
                metroCheckBox5.Checked = false;
                metroCheckBox6.Checked = false;
            }
           
        }

        private void metroCheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBox5.Checked==true)
            {
                textBox1.Text = "Edildi";
                listele();
                metroCheckBox1.Checked = false;
                metroCheckBox3.Checked = false;
                metroCheckBox4.Checked = false;
                metroCheckBox2.Checked = false;
                metroCheckBox6.Checked = false;
            }
           
        }
        
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from tbl_proje where durum like '%" + textBox1.Text + "%' ", baglanti);
            SqlDataAdapter ara = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            ara.Fill(ds);
            bunifuCustomDataGrid1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void metroCheckBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void metroCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBox6.Checked==true)
            {
                textBox1.Text = "tamamland";
                listele();
                metroCheckBox1.Checked = false;
                metroCheckBox3.Checked = false;
                metroCheckBox4.Checked = false;
                metroCheckBox5.Checked = false;
                metroCheckBox2.Checked = false;
            }
           
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
