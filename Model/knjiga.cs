using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace definiranjeObjektnogModela_Knjiznica.Model
{
    internal class knjiga : IComparable
    {
        public string ISBN { get; set; }
        public string naslov { get; set; }
        public string autor { get; set; }
        public int godina_izdanja { get; set; }
        public int broj_primjeraka { get; set; }

        //public int compareTo(object obj) => this.autor.CompareTo(((knjiga)obj).autor);

        public int CompareTo(object obj)
        {
            int rez = this.autor.CompareTo(((knjiga)obj).autor);

            if (rez == 0) { rez = this.naslov.CompareTo(((knjiga)obj).naslov); }
            return rez;
        }

        public override string ToString() => ISBN + " " + naslov + ", " + autor + ", " + godina_izdanja  + ", " + broj_primjeraka;
    }
}
