using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class UyeIslemleri : Form
    {
        public UyeIslemleri()
        {
            InitializeComponent();
        }


        DataBase db = new DataBase();

        private void UyeIslemleri_Load(object sender, EventArgs e)
        {


            db.UyeGoster(datagUyeislemleri);


        }

        private void datagUyeislemleri_CellEnter(object sender, DataGridViewCellEventArgs e)
        {




            txtUyeIsım.Text = datagUyeislemleri.CurrentRow.Cells[1].Value.ToString();
            txtUyeSoyIsım.Text = datagUyeislemleri.CurrentRow.Cells[2].Value.ToString();
            cmbUyeUnvan.Text = datagUyeislemleri.CurrentRow.Cells[3].Value.ToString();
            txtUyeEmail.Text = datagUyeislemleri.CurrentRow.Cells[4].Value.ToString();
            txtUyeTelofon.Text = datagUyeislemleri.CurrentRow.Cells[5].Value.ToString();
          
             dtpUyeKayitTarihi.Text = datagUyeislemleri.CurrentRow.Cells[6].Value.ToString();
            txtUyeID.Text = datagUyeislemleri.CurrentRow.Cells[0].Value.ToString();






        }

        private void btnEkranTemizle_Click(object sender, EventArgs e)
        {

            txtUyeIsım.Text = string.Empty;
                txtUyeSoyIsım.Text =  string.Empty;
            cmbUyeUnvan.Text = string.Empty;
            txtUyeEmail.Text = string.Empty;
            txtUyeTelofon.Text = string.Empty;
            dtpUyeKayitTarihi.Text = string.Empty;
            txtUyeID.Text = string.Empty;



        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {

            db.UyeEkle(txtUyeIsım, txtUyeSoyIsım, cmbUyeUnvan, txtUyeEmail, txtUyeTelofon, dtpUyeKayitTarihi.Value);
            db.UyeGoster(datagUyeislemleri);





        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            db.UyeSil(txtUyeID);
            db.UyeGoster(datagUyeislemleri);


        }

        private void btnUyeDuzenle_Click(object sender, EventArgs e)
        {
        
            db.UyeDuzenle(txtUyeID, txtUyeIsım, txtUyeSoyIsım, cmbUyeUnvan, txtUyeEmail, txtUyeTelofon, dtpUyeKayitTarihi.Value);
            db.UyeGoster(datagUyeislemleri);
        }

        private void btnMenuDon_Click(object sender, EventArgs e)
        {
            GorevliDashboard g = new GorevliDashboard();

            g.Show();
            this.Hide();


        }
    }
}
