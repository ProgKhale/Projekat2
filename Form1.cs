using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Unos(object sender, EventArgs e)
        {
            FormUnos frm = new FormUnos();
            frm.Show();
        }

        private void Pregled(object sender, EventArgs e)
        {
            zaposleniDataContext cntx = new zaposleniDataContext();

            dataGridView1.DataSource = from zaposleni in cntx.zaposlenis
                                       select new
                                       {
                                           zaposleni.Ime,
                                           zaposleni.Prezime,
                                           zaposleni.MjestoRodjenja,
                                           zaposleni.JMBG,
                                           zaposleni.Pol,
                                           zaposleni.RadnoMjesto,
                                           zaposleni.Staz,
                                           zaposleni.Drzavljanstvo,
                                           zaposleni.DatumZaposlenja,
                                           zaposleni.DatumRodjenja
                                       };

        }
    }
}
