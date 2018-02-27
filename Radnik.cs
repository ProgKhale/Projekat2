using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class  Radnik
    {
        private string ime, prezime, mjestoRodjenja, jmbg, pol, drzavljanstvo, radnoMjesto;
        private DateTime datumZaposlenja;
        private int staz;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string MjestoRodjenja { get => mjestoRodjenja; set => mjestoRodjenja = value; }
        public string Jmbg { get => jmbg; set => jmbg = value; }
        public string Pol { get => pol; set => pol = value; }
        public string Drzavljanstvo { get => drzavljanstvo; set => drzavljanstvo = value; }
        public string RadnoMjesto { get => radnoMjesto; set => radnoMjesto = value; }
        public DateTime DatumZaposlenja { get => datumZaposlenja; set => datumZaposlenja = value; }
        public int Staz { get => staz; set => staz = value; }
    }
}
