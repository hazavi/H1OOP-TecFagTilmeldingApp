using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Køretøjer
{
    internal class PerdriodiskSyn : Bil
    {
        const int _synInterval = 2;

        public PerdriodiskSyn(string mærke, string model, decimal bagageRum) : base(mærke, model, bagageRum)
        {
        }
    }
}
