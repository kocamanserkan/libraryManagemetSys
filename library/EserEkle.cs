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


namespace library
{
    public partial class EserEkle : Form
    {

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public EserEkle()
        {
            InitializeComponent();

            dtmEserEklemeTarih.Text = DateTime.Today.ToString();

            
        }
        DataBase ekle = new DataBase();
        DataBase a = new DataBase();
        //void EserGetir()
        //{

        //    baglanti = new SqlConnection("server=.;Initial Catalog=serkanLibraryDB;Integrated Security=SSPI");
        //    baglanti.Open();
        //    da = new SqlDataAdapter("select eserID as 'Eser ID', eserNo as 'Eser Numarası', EserAdi as 'Eser Adı', Tur as 'Tür', Yazar, BasımYılı as 'Basım Yılı', Durum, EklenmeTarih from Eser", baglanti);
        //    DataTable EserTablo = new DataTable();
        //    da.Fill(EserTablo);
        //    datagridEser.DataSource = EserTablo;
        //    baglanti.Close();
         
        //}


         private void EserEkle_Load(object sender, EventArgs e)
        {

            a.EserGoster(datagridEser);


            //EserGetir();


        }

        private void btnEserEkle_Click(object sender, EventArgs e)
        {

            //string sorgu = "insert into Eser(eserNo,EserAdi,Tur,Yazar,BasımYılı,Durum,DurumType,EklenmeTarih) values (@eserNo,@Eseradi,@Tur,@Yazar,@BasımYılı,@Durum,@DurumType,@EklemeTarih)";
            //komut = new SqlCommand(sorgu, baglanti);
            //komut.Parameters.AddWithValue("@eserNo", Convert.ToInt32(txtEserNO.Text));
            //komut.Parameters.AddWithValue("@EserAdi",txtEserAdi.Text);
            //komut.Parameters.AddWithValue("@Yazar", txtEserYazar.Text);
            //komut.Parameters.AddWithValue("@BasımYılı", Convert.ToInt32(txtEserBasımYıl.Text));
            //komut.Parameters.AddWithValue("@Durum", cmbEserDurum.Text);
            //komut.Parameters.AddWithValue("@Tur", cmbEserTur.Text);
            //if (cmbEserDurum.Text == "Müsait")
            //{
            //    komut.Parameters.AddWithValue("@DurumType", 0);
            //}
            //else
            //{
            //    komut.Parameters.AddWithValue("@DurumType", 1);
            //}
            
            //komut.Parameters.AddWithValue("@EklemeTarih", dtmEserEklemeTarih.Value);

            //baglanti.Open();
            //komut.ExecuteNonQuery();
            //baglanti.Close();
            //MessageBox.Show("Eser databaseye eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //EserGetir();

            

            a.EserEkle(txtEserNO, txtEserAdi, txtEserYazar, txtEserBasımYıl, cmbEserDurum, cmbEserTur, dtmEserEklemeTarih.Value);
            a.EserGoster(datagridEser);






        }

        private void datagridEser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datagridEser_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (checkBox1.Checked)
            {

                txtEserAdi.Text = datagridEser.CurrentRow.Cells[1].Value.ToString();
                txtEserNO.Text = datagridEser.CurrentRow.Cells[0].Value.ToString();
                cmbEserTur.Text = datagridEser.CurrentRow.Cells[2].Value.ToString();
                txtEserYazar.Text = datagridEser.CurrentRow.Cells[3].Value.ToString();
                txtEserBasımYıl.Text = datagridEser.CurrentRow.Cells[4].Value.ToString();
                cmbEserDurum.Text = datagridEser.CurrentRow.Cells[5].Value.ToString();
                dtmEserEklemeTarih.Text = datagridEser.CurrentRow.Cells[6].Value.ToString();

            }
            else
            {

            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            
        }

        private void btnEkranTemizle_Click(object sender, EventArgs e)
        {



            txtEserAdi.Text = string.Empty;
            txtEserNO.Text = string.Empty;
            cmbEserTur.Text = string.Empty;
            txtEserYazar.Text = string.Empty;
            txtEserBasımYıl.Text = string.Empty;
            cmbEserDurum.Text = string.Empty;
            dtmEserEklemeTarih.Text = string.Empty;






        }

        private void BtnEserSil_Click(object sender, EventArgs e)
        {

            a.EserSil(txtEserNO);
            a.EserGoster(datagridEser);



        }

        private void btnEserDuzenle_Click(object sender, EventArgs e)
        {


            a.EserDuzenle(txtEserAdi, txtEserYazar, txtEserBasımYıl, cmbEserDurum, cmbEserTur, dtmEserEklemeTarih.Value,txtEserNO);
            a.EserGoster(datagridEser);
        }

        private void btnMenuDon_Click(object sender, EventArgs e)
        {

            this.Hide();
            GorevliDashboard m = new GorevliDashboard();
            m.Show();
            




        }
    }
}

