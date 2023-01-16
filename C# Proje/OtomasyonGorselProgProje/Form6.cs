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
    public partial class Form6 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        int sira = 0;
        void Listele()
        {
            //gridview listeleme metodu
            baglanti = new SqlConnection("Data Source=DESKTOP-BML1BV2;Initial Catalog=EmlakOtomasyonum;Integrated Security=True;");
            baglanti.Open();
            da = new SqlDataAdapter("select konutadi,kat,binayasi,fiyati,depozito from emlaklar order by konutadi", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            ds.Clear();
            da.Fill(ds, "emlaklar");
            DataRow kayit = ds.Tables["emlaklar"].Rows[sira];
            textBox1.Text = kayit.ItemArray.GetValue(0).ToString();
            textBox2.Text = kayit.ItemArray.GetValue(1).ToString();
            textBox3.Text = kayit.ItemArray.GetValue(2).ToString();
            textBox4.Text = kayit.ItemArray.GetValue(3).ToString();
            textBox5.Text = kayit.ItemArray.GetValue(4).ToString();
            baglanti.Close();
        }
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "update emlaklar set konutadi=@kntadi,kat=@kat,binayasi=@bnyasi,fiyati=@fiyati,depozito=@dpzito where konutadi=@kntadi";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kntadi", textBox1.Text);
            komut.Parameters.AddWithValue("@kat", Convert.ToInt32(textBox2.Text));
            komut.Parameters.AddWithValue("@bnyasi", Convert.ToInt32(textBox3.Text));
            komut.Parameters.AddWithValue("@fiyati", Convert.ToInt32(textBox4.Text));
            komut.Parameters.AddWithValue("@dpzito", Convert.ToInt32(textBox5.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
