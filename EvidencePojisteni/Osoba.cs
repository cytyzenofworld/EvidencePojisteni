using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    internal class Osoba
    {
        public string jmeno;
        public string prijmeni;
        public int vek;
        public string tel_cislo;

        public Osoba(string jmeno, string prijmeni, int vek, string tel_cislo)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.vek = vek;
            this.tel_cislo = tel_cislo;

        }

        public override string ToString()
        {
            return $"{jmeno}\t{prijmeni}\t{vek}\t{tel_cislo}";
        }

    }
}
