using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Generics
{
    internal class Køretøj
    {
        public string? Mærke { get; set; }
        public string? Model { get; set; }

        public Køretøj(string? mærke, string? model ) 
        {
            Mærke = mærke;
            Model = model;
        }



    }
}
