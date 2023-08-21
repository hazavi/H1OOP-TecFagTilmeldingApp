using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecFagTilmeldingApp.Models;

namespace TecFagTilmeldingApp.Custom
{
    internal class Lærer : Person
    {
        public string? Afdeling { get; set; }

        public Lærer(string? fornavn, string? efternavn, DateTime fødselsdag, string? afdeling) : base (fornavn, efternavn, fødselsdag)
        {
            Afdeling = afdeling;

        }
    }
}
