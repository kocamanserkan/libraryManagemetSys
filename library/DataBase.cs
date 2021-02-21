using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public class DataBase
    {


       

        public void EserGoster(DataGridView x)
        {
            SqlConnection baglanti;
            SqlCommand komut;
            SqlDataAdapter da;
            baglanti = new SqlConnection("server=.;Initial Catalog=serkanLibraryDB;Integrated Security=SSPI");

            baglanti.Open();

            da = new SqlDataAdapter("select eserID as 'Eser ID', EserAdi as 'Eser Adı', Tur as 'Tür', Yazar, BasımYılı as 'Basım Yılı', Durum, EklenmeTarih from Eser", baglanti);
           
            DataTable EserTablo = new DataTable();
            da.Fill(EserTablo);
            x.DataSource = EserTablo;
            baglanti.Close();
            
        }

        public void EserEkle(TextBox txtEserNO,TextBox txtEserAdi, TextBox txtEserYazar, TextBox txtEserBasımYıl, ComboBox cmbEserDurum, ComboBox cmbEserTur, DateTime dtmEserEklemeTarih)
        {

            SqlConnection baglanti;
            SqlCommand komut;
            SqlDataAdapter da;
            baglanti = new SqlConnection("server=.;Initial Catalog=serkanLibraryDB;Integrated Security=SSPI");

            string sorgu = "insert into Eser(EserAdi,Tur,Yazar,BasımYılı,Durum,DurumType,EklenmeTarih) values (@Eseradi,@Tur,@Yazar,@BasımYılı,@Durum,@DurumType,@EklemeTarih)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@EserAdi", txtEserAdi.Text);
            komut.Parameters.AddWithValue("@Yazar", txtEserYazar.Text);
            komut.Parameters.AddWithValue("@BasımYılı", Convert.ToInt32(txtEserBasımYıl.Text));
            komut.Parameters.AddWithValue("@Durum", cmbEserDurum.Text);
            komut.Parameters.AddWithValue("@Tur", cmbEserTur.Text);
            if (cmbEserDurum.Text == "Müsait")
            {
                komut.Parameters.AddWithValue("@DurumType", 0);
            }
            else
            {
                komut.Parameters.AddWithValue("@DurumType", 1);
            }

            komut.Parameters.AddWithValue("@EklemeTarih", dtmEserEklemeTarih);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Eser database'e eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            




        }


        public void EserSil(TextBox txtEserNO)
        {

            if (string.IsNullOrEmpty(txtEserNO.Text))
            {
                MessageBox.Show("Silmek isteğiniz Eserin ID sini ekranda gösteriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection baglanti;
                SqlCommand komut;
                SqlDataAdapter da;
                baglanti = new SqlConnection("server=.;Initial Catalog=serkanLibraryDB;Integrated Security=SSPI");

                string sorgu = "Delete From Eser Where eserID = @eserID";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@eserID", Convert.ToInt32(txtEserNO.Text));

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Eser database'den silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

       

        }


        public void EserDuzenle(TextBox txtEserAdi, TextBox txtEserYazar, TextBox txtEserBasımYıl, ComboBox cmbEserDurum, ComboBox cmbEserTur, DateTime dtmEserEklemeTarih, TextBox txtEserNO)
        {


            SqlConnection baglanti;
            SqlCommand komut;
            SqlDataAdapter da;
            baglanti = new SqlConnection("server=.;Initial Catalog=serkanLibraryDB;Integrated Security=SSPI");

            string sorgu = "UPDATE Eser Set EserAdi=@EserAdi, Tur=@Tur,Yazar=@Yazar,BasımYılı=@BasımYılı,Durum=@Durum,EklenmeTarih=@EklenmeTarih where eserID=@eserID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@eserID", Convert.ToInt32(txtEserNO.Text));
            komut.Parameters.AddWithValue("@EserAdi", txtEserAdi.Text);
            komut.Parameters.AddWithValue("@Yazar", txtEserYazar.Text);
            komut.Parameters.AddWithValue("@BasımYılı", Convert.ToInt32(txtEserBasımYıl.Text));
            komut.Parameters.AddWithValue("@Durum", cmbEserDurum.Text);
            komut.Parameters.AddWithValue("@Tur", cmbEserTur.Text);
            if (cmbEserDurum.Text == "Müsait")
            {
                komut.Parameters.AddWithValue("@DurumType", 0);
            }
            else
            {
                komut.Parameters.AddWithValue("@DurumType", 1);
            }

            komut.Parameters.AddWithValue("@EklenmeTarih", dtmEserEklemeTarih);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Eser Düzenlendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }


        public void EserMusait(DataGridView DataGrid)
        {


            SqlConnection baglanti;
            SqlCommand komut;
            SqlDataAdapter da;
            baglanti = new SqlConnection("server=.;Initial Catalog=serkanLibraryDB;Integrated Security=SSPI");

            baglanti.Open();

            da = new SqlDataAdapter("select eserId as 'Eser ID', EserAdi as 'Eser Adı', Yazar, Durum  from Eser where Durum = 'Müsait'", baglanti);
            DataTable EserTablo = new DataTable();
            da.Fill(EserTablo);
            DataGrid.DataSource = EserTablo;
            baglanti.Close();




        }

        public void EserAta(TextBox eserID, TextBox PersonID, DateTime alinmaTarih, DateTime teslimTarih)
        {

            SqlConnection baglanti;
            SqlCommand komut;
            SqlDataAdapter da;
            baglanti = new SqlConnection("server=.;Initial Catalog=serkanLibraryDB;Integrated Security=SSPI");

            string sorgu = "insert into EserKullanım(eserID,alanPersonID,alınmaTarih,teslimTarih) values (@eserID,@alanPersonID,@alınmaTarih,@teslimTarih)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@eserID",Convert.ToInt32(eserID.Text));
            komut.Parameters.AddWithValue("@alanPersonID", Convert.ToInt32(PersonID.Text));

            komut.Parameters.AddWithValue("@alınmaTarih", alinmaTarih);
            komut.Parameters.AddWithValue("@teslimTarih", teslimTarih);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Eser Ataması Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void EserAtaGuncelle(TextBox EserID)
        {

            SqlConnection baglanti;
            SqlCommand komut;
            SqlDataAdapter da;
            baglanti = new SqlConnection("server=.;Initial Catalog=serkanLibraryDB;Integrated Security=SSPI");

            string diger = "UPDATE Eser Set Durum=@Durum where eserID=@eserID ";
            komut = new SqlCommand(diger, baglanti);
            komut.Parameters.AddWithValue("@eserId", Convert.ToInt32(EserID.Text));
            komut.Parameters.AddWithValue("@Durum", "Müsait Değil");

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();


        }
        public void PersonBilgi(DataGridView datagrid, string personID)
        {


            SqlConnection baglanti;
            SqlCommand komut;
            SqlDataAdapter da;
            baglanti = new SqlConnection("server=.;Initial Catalog=serkanLibraryDB;Integrated Security=SSPI");

            baglanti.Open();
            da = new SqlDataAdapter("Select P.Ad, P.Soyad, E.eserID,E.EserAdi,k.alınmaTarih,k.teslimTarih from Person P inner join EserKullanım K on P.personID = K.alanPersonId inner join Eser E on K.eserID = E.eserID where P.personID=@search", baglanti);
            da.SelectCommand.Parameters.Add(new SqlParameter
            {
                ParameterName = "@search",
                Value = personID,
                SqlDbType = SqlDbType.NVarChar,
                Size = 2000  
            });

            DataTable EserTablo = new DataTable();
            da.Fill(EserTablo);
            datagrid.DataSource = EserTablo;
            baglanti.Close();
        }

        public void EserMusaitDegil(DataGridView DataGrid)
        {


            SqlConnection baglanti;
            SqlCommand komut;
            SqlDataAdapter da;
            baglanti = new SqlConnection("server=.;Initial Catalog=serkanLibraryDB;Integrated Security=SSPI");

            baglanti.Open();

            da = new SqlDataAdapter("select e.eserID, e.EserAdi, e.Durum, ek.alanPersonId, ek.alınmaTarih, ek.teslimTarih from Eser E  inner join EserKullanım EK on e.eserID = EK.eserID inner join Person P on EK.alanPersonId = p.personID where durum = 'Müsait Değil'", baglanti);
            DataTable EserTablo = new DataTable();
            da.Fill(EserTablo);
            DataGrid.DataSource = EserTablo;
            baglanti.Close();




        }


        public void eserTeslimAL(TextBox eserID)
        {
            SqlConnection baglanti;
            SqlCommand komut;
            SqlDataAdapter da;
            baglanti = new SqlConnection("server=.;Initial Catalog=serkanLibraryDB;Integrated Security=SSPI");

            string sorgu = "Delete From EserKullanım Where eserID = @eserID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@eserID", Convert.ToInt32(eserID.Text));

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Eser Eser Teslim alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        public void eserTeslimalGuncelle(TextBox eserID)
        {


            SqlConnection baglanti;
            SqlCommand komut;
            SqlDataAdapter da;
            baglanti = new SqlConnection("server=.;Initial Catalog=serkanLibraryDB;Integrated Security=SSPI");

            string diger = "UPDATE Eser Set Durum=@Durum where eserID=@eserID ";
            komut = new SqlCommand(diger, baglanti);
            komut.Parameters.AddWithValue("@eserId", Convert.ToInt32(eserID.Text));
            komut.Parameters.AddWithValue("@Durum", "Müsait");

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();




        }
        

        public void UyeGoster(DataGridView datagrid)
        {


            SqlConnection baglanti;
            SqlCommand komut;
            SqlDataAdapter da;
            baglanti = new SqlConnection("server=.;Initial Catalog=serkanLibraryDB;Integrated Security=SSPI");

            baglanti.Open();

            da = new SqlDataAdapter("select * from Person", baglanti);

            DataTable EserTablo = new DataTable();
            da.Fill(EserTablo);
            datagrid.DataSource = EserTablo;
            baglanti.Close();


        }

        public void UyeEkle(TextBox txtUYeAd,TextBox txtUyeSoyad, ComboBox cmbUyeUnvan, TextBox txtUyeEmail,TextBox txtUyeTelefon, DateTime dtpUyeKayitTarih)
        {

            SqlConnection baglanti;
            SqlCommand komut;
            SqlDataAdapter da;
            baglanti = new SqlConnection("server=.;Initial Catalog=serkanLibraryDB;Integrated Security=SSPI");

            string sorgu = "insert into Person(Ad,Soyad,Unvan,Email,Telefon,KayitTarih) values (@Ad,@Soyad,@Unvan,@Email,@Telefon,@KayitTarih)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Ad", txtUYeAd.Text);
            komut.Parameters.AddWithValue("@Soyad", txtUyeSoyad.Text);
            komut.Parameters.AddWithValue("@Unvan", cmbUyeUnvan.Text);
            komut.Parameters.AddWithValue("@Email", txtUyeEmail.Text);
            komut.Parameters.AddWithValue("@Telefon", txtUyeTelefon.Text);
            komut.Parameters.AddWithValue("@KayitTarih", dtpUyeKayitTarih);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye database'e eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }


        public void UyeSil(TextBox uyeID)
        {


            if (string.IsNullOrEmpty(uyeID.Text))
            {
                MessageBox.Show("Silmek isteğiniz Üyenin ID sini ekranda gösteriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection baglanti;
                SqlCommand komut;
                SqlDataAdapter da;
                baglanti = new SqlConnection("server=.;Initial Catalog=serkanLibraryDB;Integrated Security=SSPI");

                string sorgu = "Delete From Person Where personID = @personID";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@personID", Convert.ToInt32(uyeID.Text));

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Üye database'den silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public void UyeDuzenle(TextBox uyeID, TextBox uyeAd, TextBox uyeSoyad, ComboBox uyeUnvan, TextBox uyeEmail,TextBox uyeTelefon, DateTime uyeKayitTarih)
        {


            SqlConnection baglanti;
            SqlCommand komut;
            SqlDataAdapter da;
            baglanti = new SqlConnection("server=.;Initial Catalog=serkanLibraryDB;Integrated Security=SSPI");

            string sorgu = "UPDATE Person Set Ad=@Ad,Soyad=@Soyad,Unvan=@Unvan,Email=@Email,Telefon=@Telefon,KayitTarih=@KayitTarih where personID=@personID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@personID", Convert.ToInt32(uyeID.Text));
            komut.Parameters.AddWithValue("@Ad", uyeAd.Text);
            komut.Parameters.AddWithValue("@Soyad", uyeSoyad.Text);
            komut.Parameters.AddWithValue("@Unvan", uyeUnvan.Text);
            komut.Parameters.AddWithValue("@Email", uyeEmail.Text);
            komut.Parameters.AddWithValue("@Telefon", uyeTelefon.Text);
           
            komut.Parameters.AddWithValue("@KayitTarih", uyeKayitTarih);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Düzenlendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }









    }
}
