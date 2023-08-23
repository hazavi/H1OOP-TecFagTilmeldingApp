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


        /// Denne metode har en metode signatur som følgende: string

        public string WriteText()
        {
            return "Hello world!";
        }
        /// Denne metode har en metode signatur som følgende: string, string

        public string WriteText(string valueToDisplay)
        {
            return $"Hello {valueToDisplay}!";
        }

        /// Denne metode har en metode signatur som følgende: string, string, int

        public string WriteText(string valueToDisplay, int alder)
        {
            return $"Hello {valueToDisplay}!, du er {alder.ToString()} år gammel.";
        }

    }
}
