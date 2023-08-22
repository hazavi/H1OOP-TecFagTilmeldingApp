using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecFagTilmeldingApp.Custom;

namespace TecFagTilmeldingApp.Models
{
    internal class Tilmelding
    {
        public Elev Elev { get; set; }
        public Fag? Fag { get; set; }
        public Tilmelding(Elev elev, Fag? fag)
        {
            Elev = elev;
            Fag = fag;
        }



    }
}
