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

namespace OtomasyonGorselProgProje
{
    
    public partial class Form5 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        SqlDataReader dr;
        SqlCommand komut2;
        void Listele()
        {
            //gridview1 listeleme metodu
            baglanti = new SqlConnection("Data Source=DESKTOP-BML1BV2;Initial Catalog=EmlakOtomasyonum;Integrated Security=True;");
            baglanti.Open();
            da = new SqlDataAdapter("select * from emlaklar where durumu=1", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            ds.Clear();
            da.Fill(ds, "emlaklar");
            baglanti.Close();
        }
        void Listele2()
        {
            //gridview2 listeleme metodu
            baglanti = new SqlConnection("Data Source=DESKTOP-BML1BV2;Initial Catalog=EmlakOtomasyonum;Integrated Security=True;");
            baglanti.Open();
            da = new SqlDataAdapter("select * from musteri order by ad", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            ds.Clear();
            da.Fill(ds, "musteri");
            baglanti.Close();
        }
        void comboliste()
        {
            comboBox1.Items.Clear();
            baglanti=new SqlConnection("Data Source=DESKTOP-BML1BV2;Initial Catalog=EmlakOtomasyonum;Integrated Security=True;");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from emlaklar where durumu=1", baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["konutadi"]);
            }
            baglanti.Close();
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Listele();
            Listele2();
            comboliste();
        }


        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "insert into musteri (TCNo,email,ad,soyad,telefon_no,konutadi) values(@tc,@mail,@ad,@soyad,@phone,@kntadi)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tc", f5txt1.Text);
            komut.Parameters.AddWithValue("@mail", f5txt2.Text);
            komut.Parameters.AddWithValue("@ad", f5txt2.Text);
            komut.Parameters.AddWithValue("@soyad", f5txt3.Text);
            komut.Parameters.AddWithValue("@phone", f5txt4.Text);
            komut.Parameters.AddWithValue("@kntadi", comboBox1.SelectedItem);
            komut.ExecuteNonQuery();
            Listele2();
            baglanti.Open();
            string sorgu2 = "update emlaklar set konutadi=@kntadi,durumu=@durumu where konutadi=@kntadi";
            komut2 = new SqlCommand(sorgu2, baglanti);
            komut2.Parameters.AddWithValue("@kntadi", comboBox1.SelectedItem);
            komut2.Parameters.AddWithValue("@durumu", Convert.ToInt32(textBox1.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            Listele();
            comboliste();
            f5txt1.Clear();
            f5txt2.Clear();
            f5txt3.Clear();
            f5txt4.Clear();
            f5txt5.Clear();
            textBox1.Clear();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void f5txt1_TextChanged(object sender, EventArgs e)
        {
            int u = f5txt1.TextLength;
            if (u == 12)
            {
                MessageBox.Show("TC Kimlik Numarası 11 Hanelidir Lütfen 11 Haneli TC Kimlik Numarası Giriniz.");
            }

        }

        private void f5txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void f5txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void f5lb5_Click(object sender, EventArgs e)
        {

        }

        private void f5lb4_Click(object sender, EventArgs e)
        {

        }

        private void f5lb3_Click(object sender, EventArgs e)
        {

        }

        private void f5lb2_Click(object sender, EventArgs e)
        {

        }

        private void f5lb6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
