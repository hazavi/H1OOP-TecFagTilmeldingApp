using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecFagTilmeldingApp.Models;

namespace TecFagTilmeldingApp.Custom
{
    internal class Fag
    {
        public string? Navn { get; set; }
        public PersonModel? Lærer { get; set; }

        public Fag(string? navn, PersonModel? lærer)
        {
            Navn = navn;
            Lærer = lærer;
        }



    }
}
