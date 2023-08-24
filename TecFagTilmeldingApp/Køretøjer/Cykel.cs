using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Køretøjer
{
    internal class Cykel : Køretøj
    {
        public Køretøj? Properties{ get; set; }
        public decimal PadalStørrelseICm { get; set; }

        public Cykel(string mærke, string model, decimal  padalStørrelsen)
        {
            Properties = new() { Mærk = mærke, Model = model };
            PadalStørrelseICm = padalStørrelsen;
        }
    }
}
