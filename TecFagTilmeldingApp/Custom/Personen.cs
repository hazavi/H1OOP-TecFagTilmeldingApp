using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Custom
{
    internal class Personen
    {
        public string SayHello(string ElevEllerLærer)
        {
            return $"Hej, jeg er en {ElevEllerLærer}.";
        }

        public string SayHello(string ElevEllerLærer, string Navn)
        {
            return $"Hej, jeg er en {ElevEllerLærer} og jeg hedder {Navn}";
        }

    }
}
