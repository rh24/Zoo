using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Vertebrata
    {
        public abstract string Endoskeleton { get; set; }
        public abstract string Brain { get; set; }

        public string VertebrateGretting()
        {
            return "I have a spine!";
        }
    }
}