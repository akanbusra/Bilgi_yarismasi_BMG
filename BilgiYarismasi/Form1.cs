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

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6QDVVSR\\SQLEXPRESS;Initial Catalog=DbYarisma;Integrated Security=True");

        void listele()
        {
            SqlCommand komut = new SqlCommand("select * from TblSoruCevap  ", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        //LiSTELE BUTONU
        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        //SORU EKLE BUTONU
        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TblSoruCevap (SORU,CEVAP,HARF) values (@p1,@p2,@p3)",baglanti);
            komut.Parameters.AddWithValue("@p1", txtSoru.Text);
            komut.Parameters.AddWithValue("@p2", txtCevap.Text);
            komut.Parameters.AddWithValue("@p3", TxtHarf.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("SORU EKLENDİ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //TEMİZLE BUTONU
        private void BtnSeçimTemizle_Click(object sender, EventArgs e)
        {
            txtıd.Text = " ";
            txtSoru.Text = " ";
            txtCevap.Text = " ";
            TxtHarf.Text = " ";

        }
        //VERİYE ÇİFT TIKLANDIĞINDA UYGUN YERLERE YAZILMASI
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtıd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtSoru.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtCevap.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtHarf.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

        }

        //SORU SİL BUTONU
        private void BtnSoruSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from TblSoruCevap where ID=@p1",baglanti);
            sil.Parameters.AddWithValue("@p1", txtıd.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("SORU SİLİNDİ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listele();
        }

        //SORUYU GÜNCELLE
        private void BtnSoruGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutgüncelle = new SqlCommand("update TblSoruCevap set SORU=@a1, CEVAP=@a2,HARF=@a4 where ID=@a3",baglanti);
            komutgüncelle.Parameters.AddWithValue("@a1", txtSoru.Text);
            komutgüncelle.Parameters.AddWithValue("@a2", txtCevap.Text);
            komutgüncelle.Parameters.AddWithValue("@a4", TxtHarf.Text);
            komutgüncelle.Parameters.AddWithValue("@a3", txtıd.Text);
            komutgüncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("SORU GÜNCELLENDİ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


            listele();
           
        }
    }
}
