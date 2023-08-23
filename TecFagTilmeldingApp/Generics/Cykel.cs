using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Generics
{
    internal class Cykel : Køretøj
    {
        public string? HøjdeStørrelse { get; set; }

        public Cykel(string? mærke, string? model, string? højdeStørrelse) : base(mærke, model)
        {
            HøjdeStørrelse = højdeStørrelse;
        }
    }
}
