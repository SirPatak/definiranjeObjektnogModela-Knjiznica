using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace definiranjeObjektnogModela_Knjiznica.Model
{
    internal class posudba: IComparable
    {
        ucenik ucenici { get; set; }
        knjiga knjige { get; set; }
        DateTime datum_posudbe {  get; set; }
        int broj_dana {  get; set; }
        DateTime datum_povracanja { get; }

        public int CompareTo(object obj)
        {
            int rez = this.datum_posudbe.CompareTo(((posudba)obj).datum_posudbe);

            return rez;
        }

        public override string ToString() => datum_posudbe + " - " + datum_povracanja + ": " + knjige + " -> " + ucenici;

    }
}
