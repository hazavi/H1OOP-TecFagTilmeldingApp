using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Generics
{
    internal class Bil 
    {
        public double MotorStørrelsen { get; set; }

        public Bil(string? mærke, string? model, int motorStørrelsen)
        {
            MotorStørrelsen = motorStørrelsen;
        }
    }
}
