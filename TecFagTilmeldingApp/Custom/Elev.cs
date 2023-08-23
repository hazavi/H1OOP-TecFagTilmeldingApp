using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecFagTilmeldingApp.Models;

namespace TecFagTilmeldingApp.Custom
{
    // Sealed class må ikke arves fra.
    internal sealed class Elev : Person
    {
        public Elev(string? fornavn, string? efternavn, DateTime fødselsdag) : base(fornavn, efternavn, fødselsdag)
        {
            string defaultInfo = ShowAllInfo2();
        }

        protected override string ShowAllInfo()
        {
            return $"{PersonInfo.ForNavn} {PersonInfo.EfterNavn}";
        }

        //SHOWBIRTDATE
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
