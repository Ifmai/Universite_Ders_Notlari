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
    public partial class Form3 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        void Listele()
        {
            //gridview listeleme metodu
            baglanti = new SqlConnection("Data Source=DESKTOP-BML1BV2;Initial Catalog=EmlakOtomasyonum;Integrated Security=True;");
            baglanti.Open();
            da = new SqlDataAdapter("select * from emlaklar order by konutadi", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            ds.Clear();
            da.Fill(ds,"emlaklar");
            baglanti.Close();
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            //form2 ye geri dönüş cancel buttonu
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void f3txt6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void f3txt5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void f3bttn1_Click(object sender, EventArgs e)
        {
            //ekleme butonu
            baglanti.Open();
            string sorgu = "insert into emlaklar (konutadi,kat,binayasi,fiyati,depozito,adres,durumu) values(@kntadi,@kat,@byasi,@fiyati,@dpzito,@adres,@durumu)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kntadi", f3txt1.Text);
            komut.Parameters.AddWithValue("@kat", Convert.ToInt32(f3txt4.Text));
            komut.Parameters.AddWithValue("@byasi", Convert.ToInt32(f3txt6.Text));
            komut.Parameters.AddWithValue("@fiyati", Convert.ToInt32(f3txt2.Text));
            komut.Parameters.AddWithValue("@dpzito", Convert.ToInt32(f3txt5.Text));
            komut.Parameters.AddWithValue("@adres", f3txt3.Text);
            komut.Parameters.AddWithValue("@durumu",Convert.ToInt32(textBox1.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();

            f3txt1.Clear();
            f3txt2.Clear();
            f3txt3.Clear();
            f3txt4.Clear();
            f3txt5.Clear();
            f3txt6.Clear();
        }

        private void f3buttonlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
