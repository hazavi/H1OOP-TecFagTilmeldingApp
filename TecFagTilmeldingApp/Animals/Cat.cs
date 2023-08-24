using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Animals
{
    internal class Cat : Animal
    {
        SoundPlayer player = new SoundPlayer(@"Animals\cat.wav");

        internal override string MakeSound()
        {
            player.Play();
            return "Cat";
        }
    }
}
