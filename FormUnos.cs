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
    public partial class FormUnos : Form
    {
        public FormUnos()
        {
            InitializeComponent();
            //btnUnos.Enabled = false;
        }

        private void clickUnos(object sender, EventArgs e)
        {
            zaposleni radnik = new zaposleni();
            radnik.Ime = txtIme.Text;
            radnik.Prezime = txtPrezime.Text;
            radnik.JMBG = txtJMBG.Text;
            radnik.MjestoRodjenja = txtMjestoRodjenja.Text;
            radnik.Pol = txtPol.Text;
            radnik.RadnoMjesto = txtRadnoMjesto.Text;
            radnik.Staz = int.Parse(txtStaz.Text);
            radnik.DatumZaposlenja = Convert.ToDateTime(txtDatumZaposlenja.Text);
            radnik.Drzavljanstvo = txtDrzavljanstvo.Text;
            radnik.DatumRodjenja = Convert.ToDateTime(txtDatumRodjenja.Text);

            zaposleniDataContext db = new zaposleniDataContext();
            db.zaposlenis.InsertOnSubmit(radnik);
            db.SubmitChanges();
        }

        private void txtDatumRodjenja_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
