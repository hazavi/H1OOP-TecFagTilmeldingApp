using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using TecFagTilmeldingApp.Custom;
using TecFagTilmeldingApp.Models;

namespace TecFagTilmeldingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Tilføjer Lærerer

            Lærer? lære1 = new("Niels", "Olsen", new DateTime(1971, 2, 23), "CIT");
            PersonModel niels = lære1.PersonInfo;

            Lærer? lære2 = new("Henrik", "Paulse", new DateTime(1971, 2, 23), "CIT");
            PersonModel henrik = lære2.PersonInfo;

            Lærer? lære3 = new("Jack", "Baltzer", new DateTime(1971, 2, 23), "CIT");
            PersonModel jack = lære3.PersonInfo;

            Lærer? lære4 = new("Bo", "Elbæk", new DateTime(1971, 2, 23), "CIT");
            PersonModel bo = lære4.PersonInfo;

            //Data | Lister 
            List<Fag> Fagne = new List<Fag>();
            List<Tilmelding> tilmeldelev = new List<Tilmelding>();

            Fagne.Add(new Fag("Grundlæggende Programmering", niels));
            Fagne.Add(new Fag("OOP", niels));
            Fagne.Add(new Fag("Studieteknik", niels));
            Fagne.Add(new Fag("Netværk", henrik));
            Fagne.Add(new Fag("Clientside Programmering", jack));
            Fagne.Add(new Fag("Database Programmering", jack));
            Fagne.Add(new Fag("Computerteknologi", bo));

            // DO-WHILE lykke | gentager programmet
            do
            {
                // Oprettelse af eleven
                Console.Write("ForNavn: ");
                string? ForNavn = Console.ReadLine();

                Console.Write("EfterNavn: ");
                string? EfterNavn = Console.ReadLine();

                Console.Write("Fødselsdag (dd-MM-yyyy): ");
                string? Fødselsdag = Console.ReadLine();

                string format = "dd-MM-yyyy";
                DateTime fødselsdag = DateTime.ParseExact(Fødselsdag, format, null);

                // ID input
                for (int i = 1; i < Fagne.Count; i++)
                {
                    Console.WriteLine($"Fag id: {i}, Fag Navn: {Fagne[i].Navn}");
                }

                Console.Write("Angiv ID for det fag som elev skal have: ");

                if (int.TryParse(Console.ReadLine(), out int ID) && ID >= 0 && ID < Fagne.Count)
                {
                    //Oprette den nye elev
                    Elev nyElev = new Elev(ForNavn, EfterNavn, fødselsdag);
                    PersonModel Eleven = nyElev.PersonInfo;


                    //Valgte ID
                    Fag ValgteFag = Fagne[ID];
                    Console.WriteLine($"{ForNavn} {EfterNavn} er nu tilmeldt '{ValgteFag.Navn}'");

                    // Tilmelder eleven
                    Tilmelding tilmeld = new(nyElev, ValgteFag);
                    tilmeldelev.Add(tilmeld);


                    // JA NEJ
                    Console.Write("[J/N]: ");
                    string? svar = Console.ReadLine();

                    switch (svar.ToUpper())
                    {
                        case "J":
                            Console.Clear();
                            Console.WriteLine($"{ForNavn} {EfterNavn}({nyElev.Alder} år gammel) er tilmeldt '{ValgteFag.Navn}'");
                            Console.WriteLine("--task key for at forsætte--");
                            Console.ReadKey();
                            break;
                        case "N":
                            Console.WriteLine("Du valgte Nej. \n--task key for at forsætte--");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Ugyldigt valg. Prøve igen!");
                            Console.ReadKey();
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Ugyldigt ID. Prøve igen!");
                    Console.ReadKey();

                }
                Console.Clear();

                //Viser alle Tilmelde Elever
                Console.WriteLine("Alle Tilmelde Elever");
                foreach (var tilmelding in tilmeldelev)
                {
                    Console.WriteLine($"{tilmeldelev.Count}. {tilmelding.Elev.PersonInfo.ForNavn} {tilmelding.Elev.PersonInfo.EfterNavn} ({tilmelding.Fag.Navn}) ");
                }
                Console.ReadKey();

                Console.Clear();


            } while (true);

        }

    }

}