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
    public partial class EserAta : Form
    {
        public EserAta()
        {
            InitializeComponent();
        }

        DataBase a = new DataBase();
        private void EserAta_Load(object sender, EventArgs e)
        {



            a.EserMusait(datagEserAta);



        }

        private void datagEserAta_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtEserID.Text = datagEserAta.CurrentRow.Cells[0].Value.ToString();
            txtEserAdı.Text = datagEserAta.CurrentRow.Cells[1].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            a.EserAta(txtEserID, txtPersonID, dtpeserAtamaTarih.Value, dtpEserTeslimTarih.Value);
            a.EserAtaGuncelle(txtEserID);
            a.EserMusait(datagEserAta);


        }

        private void btnPersonBilgi_Click(object sender, EventArgs e)
        {

            string personID = txtPersonID.Text;

            PersonBilgi personbilgi = new PersonBilgi(personID);
            personbilgi.Show();





        }

        private void datagEserAta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDonMenu_Click(object sender, EventArgs e)
        {

            GorevliDashboard m = new GorevliDashboard();

            m.Show();
            this.Hide();


        }
    }
}
