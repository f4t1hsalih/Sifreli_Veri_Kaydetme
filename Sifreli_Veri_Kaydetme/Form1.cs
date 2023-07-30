using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Sifreli_Veri_Kaydetme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] degerler = new string[5];
        SqlConnection cnn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=krsDbSifreliKayit;Integrated Security=True");

        void ListeleSifreli()
        {
            SqlDataAdapter da = new SqlDataAdapter("select Ad as 'AD', Soyad as ' SOYAD', Mail as 'MAÝL', Sifre as 'ÞÝFRE', HesapNo as 'HESAP NO' from tbl_Veriler", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void ListeleSifresiz()
        {
            dataGridView1.Rows.Clear();

            cnn.Open();
            SqlCommand cmd = new SqlCommand("select Ad, Soyad, Mail, Sifre, HesapNo from tbl_Veriler", cnn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                degerler[0] = SifreCoz(dr.GetString(0));
                degerler[1] = SifreCoz(dr.GetString(1));
                degerler[2] = SifreCoz(dr.GetString(2));
                degerler[3] = SifreCoz(dr.GetString(3));
                degerler[4] = SifreCoz(dr.GetString(4));

                dataGridView1.Rows.Add(degerler);
            }

            dr.Close();
            cnn.Close();
        }

        string Sifrele(string deger)
        {
            byte[] dizi = ASCIIEncoding.ASCII.GetBytes(deger);
            string sifreli = Convert.ToBase64String(dizi);
            return sifreli;
        }

        string SifreCoz(string deger)
        {
            byte[] dizi = Convert.FromBase64String(deger);
            string sonuc = ASCIIEncoding.ASCII.GetString(dizi);
            return sonuc;
        }

        void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtMail.Clear();
            txtSifre.Clear();
            txtHesapNo.Clear();
            dataGridView1.Rows.Clear();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_Veriler(Ad,Soyad,Mail,Sifre,HesapNo) values (@p1,@p2,@p3,@p4,@p5)", cnn);
            cmd.Parameters.AddWithValue("@p1", Sifrele(txtAd.Text));
            cmd.Parameters.AddWithValue("@p2", Sifrele(txtSoyad.Text));
            cmd.Parameters.AddWithValue("@p3", Sifrele(txtMail.Text));
            cmd.Parameters.AddWithValue("@p4", Sifrele(txtSifre.Text));
            cmd.Parameters.AddWithValue("@p5", Sifrele(txtHesapNo.Text));
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Mesajýnýz Baþarýyla Kaydedilmiþtir");

            Temizle();
            //ListeleSifreli();
            ListeleSifresiz();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ListeleSifreli();

            DataGridViewTextBoxColumn ad = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn soyad = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn mail = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn sifre = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn hesapNo = new DataGridViewTextBoxColumn();

            dataGridView1.Columns.Add(ad);
            dataGridView1.Columns.Add(soyad);
            dataGridView1.Columns.Add(mail);
            dataGridView1.Columns.Add(sifre);
            dataGridView1.Columns.Add(hesapNo);

            ad.HeaderText = "AD";
            soyad.HeaderText = "SOYAD";
            mail.HeaderText = "MAÝL";
            sifre.HeaderText = "ÞÝFRE";
            hesapNo.HeaderText = "HESAP NO";

            ListeleSifresiz();
        }
    }
}