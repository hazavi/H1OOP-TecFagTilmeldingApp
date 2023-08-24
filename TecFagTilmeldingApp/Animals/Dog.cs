using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Animals
{
    internal class Dog : Animal
    {
        SoundPlayer player = new SoundPlayer(@"Animals\dog.wav");

        internal override string MakeSound()
        {
            player.Play();
            return "Dog";
        }

    }
}
