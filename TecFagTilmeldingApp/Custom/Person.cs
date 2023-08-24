using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecFagTilmeldingApp.Models;

namespace TecFagTilmeldingApp.Custom
{
    enum CountryCode
    {
        DK,
        EN
    }

    // Abstract er tilføjet for at man ikke kan istantierer en base klasse. Og
    // denne klasse er base klasse for Teacher og Student.
    internal abstract class Person
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
        public abstract List<string> GetInfo(List<Tilmelding> tilmeldings);

        /// Brug af protected modifier for at metoden er "public" internt i arven
        /// men private for alle andre types(klasse).
        protected string ShowFullName()
        {
            return $"{PersonInfo.ForNavn} {PersonInfo.EfterNavn}";
        }

        protected abstract string ShowAllInfo();

        protected virtual string ShowAllInfo2()
        {
            return $"{PersonInfo.ForNavn} {PersonInfo.EfterNavn}";
        }

        //SHOWBIRTDATE
        protected internal virtual string ShowBirthDate()
        {
            string format = "yyyy.MM.dd";
            return $"Format: {CountryCode.EN} \nFødselsdags Dato: {Fødselsdag.ToString(format)}";
        }

        protected internal virtual string ShowBirthDate(CountryCode brugerDefineretFormat)
        {
            string format = brugerDefineretFormat == CountryCode.EN ? "yyyy.MM.dd" : "dd-MM-yyyy";
            return $"Format: {brugerDefineretFormat} \nFødselsdags Dato: {Fødselsdag.ToString(format)}";
        }


        //KøreTøjer OPG 
        

        // Show My Identity | abstract metode 
        protected abstract string ShowMyIdentity();


    }
}
