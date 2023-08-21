using TecFagTilmeldingApp.Custom;
using TecFagTilmeldingApp.Models;

namespace TecFagTilmeldingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lærerer
            Lærer? niels = new("Niels", "Olsen", new DateTime(1971, 2, 23), "CIT");
            PersonModel lære1 = niels.PersonInfo;
            //Elever
            Elev peter = new("Peter", "Parker", new DateTime(2003, 6, 12));
            PersonModel elev1 = peter.PersonInfo;

            Fag oop = new("OOP", lære1);

            Console.WriteLine($"LÆRER \nFag: {oop.Navn} \nLærer: {lære1.ForNavn} {lære1.EfterNavn} \nAlder: {niels.Alder}");

            Console.WriteLine($"\nELEVER \nNavn: {elev1.ForNavn} {elev1.EfterNavn} \nAlder: {peter.Alder}");
        }
    }
}