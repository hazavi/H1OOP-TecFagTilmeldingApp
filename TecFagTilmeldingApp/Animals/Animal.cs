using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TecFagTilmeldingApp.Custom;

namespace TecFagTilmeldingApp.Animals
{
    internal class Animal
    {
        internal virtual string MakeSound()
        {
            return "First Choose an animal";
        }
    }
}
