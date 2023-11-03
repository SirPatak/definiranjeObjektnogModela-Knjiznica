using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace definiranjeObjektnogModela_Knjiznica.Model
{
    internal class ucenik : IComparable
    {
        public string OIB { get; }
        public string ime { get; set; }
        public string prezime { get; set; }

        public int razred { get; set; }

        public string adresa { get; set; }

        public string smjer { get; set; }

        public int CompareTo(object obj)
        {
            int rez = this.prezime.CompareTo(((ucenik)obj).prezime);

            if (rez == 0 ) { rez = this.ime.CompareTo(((ucenik)obj).ime); }
            return rez;
        }

        

        public override string ToString() => prezime + " " + ime + ", " + razred + ", " + smjer;

    }
}
