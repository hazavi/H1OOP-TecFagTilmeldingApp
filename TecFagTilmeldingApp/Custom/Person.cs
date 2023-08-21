using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecFagTilmeldingApp.Models;

namespace TecFagTilmeldingApp.Custom
{
    internal class Person
    {
        public PersonModel PersonInfo { get; set; }
        public DateTime Fødselsdag { get; set; }
        public int Alder { get; set; }
        
        public Person(string? fornavn, string? efternavn, DateTime fødselsdag)
        {
            PersonInfo = new() { ForNavn = fornavn, EfterNavn = efternavn };
            Fødselsdag = fødselsdag;
            Alder = new AlderBeregner(fødselsdag).Alder;
        }
    }
}
