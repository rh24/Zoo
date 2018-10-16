using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Mammal : Vertebrata
    {
        public override string Endoskeleton { get; set; } = "Has a backbone";
        public override string Brain { get; set; } = "Well-developed brain";
        protected virtual int AvgLifeSpanInYears;
        protected virtual bool HairOnSkin = true;

        public string BloodTemperature()
        {
            return "I'm warm-blooded!";
        }

        public abstract string MakeSound() { }

        public Mammal()
        {
        }
    }
}
