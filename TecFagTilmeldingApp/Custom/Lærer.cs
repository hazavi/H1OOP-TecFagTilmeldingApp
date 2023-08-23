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
            string fullname = ShowFullName();
            string defaultInfo = ShowAllInfo2();

        }

        /// Oprindlig metode ligger i base klassen og er en abstrakt metode.
        protected override string ShowAllInfo()
        {
            return $"{PersonInfo.ForNavn} {PersonInfo.EfterNavn}, Afdeling {Afdeling}";
        }

        /// Oprindlig metode ligger i base klassen og er en virtual metode.
        protected override string ShowAllInfo2()
        {
            return $"{PersonInfo.ForNavn} {PersonInfo.EfterNavn}, Afdeling {Afdeling}";
        }

        //ShowBirtDate
        protected internal override string ShowBirthDate()
        {
            string format = "yyyy.MM.dd";
            return $"Format: {CountryCode.EN} \nFødselsdags Dato: {Fødselsdag.ToString(format)}";
        }

        protected internal override string ShowBirthDate(CountryCode brugerDefineretFormat)
        {
            string format = brugerDefineretFormat == CountryCode.EN ? "yyyy.MM.dd" : "dd-MM-yyyy";
            return $"Format: {brugerDefineretFormat} \nFødselsdags Dato: {Fødselsdag.ToString(format)}";
        }
    }
}
