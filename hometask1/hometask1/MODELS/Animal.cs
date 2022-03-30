using System;
using System.Collections.Generic;
using System.Text;

namespace hometask1.MODELS
{
    interface IAnimal
    {
        void AnimalSound();
    }
    class Pig : IAnimal
    {
        public void AnimalSound()
        {
            Console.WriteLine( " wee wee ");
        }

    }
}
