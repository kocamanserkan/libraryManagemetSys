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
    public partial class EserTeslim : Form
    {
        public EserTeslim()
        {
            InitializeComponent();
        }

        DataBase db = new DataBase();

        private void EserTeslim_Load(object sender, EventArgs e)
        {


            db.EserMusaitDegil(datagEserTeslim);




        }

        private void datagEserTeslim_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtEserIdTeslim.Text = datagEserTeslim.CurrentRow.Cells[0].Value.ToString();
            txtEserIsmiTeslim.Text = datagEserTeslim.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnEserTeslimAl_Click(object sender, EventArgs e)
        {

            db.eserTeslimAL(txtEserIdTeslim);
            db.eserTeslimalGuncelle(txtEserIdTeslim);
            db.EserMusaitDegil(datagEserTeslim);




        }

        private void button1_Click(object sender, EventArgs e)
        {

            GorevliDashboard g = new GorevliDashboard();
            g.Show();
            this.Hide();


        }
    }
}
