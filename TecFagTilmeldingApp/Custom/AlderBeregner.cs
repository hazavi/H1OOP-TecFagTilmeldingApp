using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Custom
{
    internal class AlderBeregner
    {
        public int Alder { get; set; }

        public AlderBeregner(DateTime fødselsdag)
        {
            Alder = DateTime.Now.Year - fødselsdag.Year;
        }
    }
}
