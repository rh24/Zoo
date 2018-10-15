using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Mammal : Vertebrata
    {
        protected abstract string Endoskeleton { get; set; }

        public Mammal(string howDeveloped)
        {
            Endoskeleton = howDeveloped;
        }
    }
}
