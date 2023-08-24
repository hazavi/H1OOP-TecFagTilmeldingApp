using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Køretøjer
{
    //Bilen har 2 base klasser, hvor jeg gjort FireHjulKøretøj til en interface
    internal class Bil : Køretøj, FireHjulKøretøj
    {
        public Køretøj? Properties { get; set; }
        public FireHjulKøretøj? fireHjul { get; set; }
        public decimal BagagerumVolumeIKubikCm { get; set; }

        public Bil(string mærke, string model, decimal bagageRum)
        {
            Properties = new() { Mærk = mærke, Model = model };
            BagagerumVolumeIKubikCm = bagageRum;
        }
    }
}
