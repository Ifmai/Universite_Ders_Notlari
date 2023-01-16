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
    
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            baglanti=new SqlConnection("Data Source=DESKTOP-BML1BV2;Initial Catalog=EmlakOtomasyonum;Integrated Security=True;");
            komut = new SqlCommand("select * from admin where adminad='" +kulLb.Text + "'and adminsifre='" +pasLB.Text + "'", baglanti);
            baglanti.Open();
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Başaryla Giriş Yaptınız");
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Hatali Griş!");
            }

        }

    }
}
