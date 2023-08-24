using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
        public override List<string> GetInfo(List<Tilmelding> tilmeldings)
        {
            List<string> info = new();
            foreach (Tilmelding tilmeldinger in tilmeldings)
            {
                if (tilmeldinger.Elev.PersonInfo.ForNavn == PersonInfo.ForNavn && tilmeldinger.Elev.PersonInfo.EfterNavn == PersonInfo.EfterNavn)
                {
                    info.Add(tilmeldinger.Fag.Navn);
                }
            }

            return info;
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

        //KøreTøjer OPG

        protected override string ShowMyIdentity()
        {
            return $"Jeg er en Elev";
        }
    }
}
