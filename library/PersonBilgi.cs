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
    public partial class PersonBilgi : Form
    {
        public PersonBilgi(string personID)
        {
            InitializeComponent();
            txtPersonID.Text = personID;

        }

        DataBase a = new DataBase();
        

        private void PersonBilgi_Load(object sender, EventArgs e)
        {


            a.PersonBilgi(datagPersonEserBilgi,txtPersonID.Text);



        }

        private void datagPersonEserBilgi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            txtPersonAd.Text = datagPersonEserBilgi.CurrentRow.Cells[0].Value.ToString();
            txtPersonSoyad.Text = datagPersonEserBilgi.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
