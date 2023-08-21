using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecFagTilmeldingApp.Models;

namespace TecFagTilmeldingApp.Custom
{
    internal class Elev : Person
    {
        public Elev(string? fornavn, string? efternavn, DateTime fødselsdag) : base(fornavn, efternavn, fødselsdag)
        {

        }

    }
}
