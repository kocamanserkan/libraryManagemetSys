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
    public partial class GorevliDashboard : Form
    {
        public GorevliDashboard()
        {
            InitializeComponent();
        }

        private void btnEditGiris_Click(object sender, EventArgs e)
        {
              
           
            EserEkle a = new EserEkle();

            a.Show();
            this.Hide();
            




        }

        private void btnEserAtaGiris_Click(object sender, EventArgs e)
        {

            EserAta eserAta = new EserAta();
            eserAta.Show();
            this.Hide();





        }

        private void btneserTeslimiGiris_Click(object sender, EventArgs e)
        {

            EserTeslim eserTeslim = new EserTeslim();
            eserTeslim.Show();
            this.Hide();




        }

        private void btnUyuIslemleriGiris_Click(object sender, EventArgs e)
        {

            UyeIslemleri i = new UyeIslemleri();
            i.Show();
            this.Close();


        }

        private void btnGorevliDasboardCikis_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
