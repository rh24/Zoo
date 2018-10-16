using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public abstract class Mammal : Vertebrata, IEdible
    {
        // Poperties from pt.1 of lab
        public override string Endoskeleton { get; set; } = "Has a backbone";
        public override string Brain { get; set; } = "Well-developed brain";
        public virtual int AvgLifeSpanInYears { get; set; }
        public virtual bool HairOnSkin { get; } = true;

        // Properies from pt.2 IEatable implementation
        public bool Diseased { get; set; } = false;
        public int DeliciousRating { get; set; } = 1;
        public bool FattyMeat { get; set; } = false;

        // Methods from pt.1 of lab
        public string BloodTemperature()
        {
            return "I'm warm-blooded!";
        }

        public abstract string MakeSound();


        // Method from pt.2 IEdible implementation
        public string ShouldWeEatThis()
        {
            if (Diseased) return "I don't think you want to do that... this animal is diseased.";
            if (FattyMeat && DeliciousRating >= 4) return "We hear good things about it! It's worth trying!";
            if (DeliciousRating == 3 && !FattyMeat) return "It tastes average at best, and it's not fatty meat... It's up to you, but we wouldn't recommend it.";
            if (DeliciousRating < 3) return "This animal tastes terrible. Don't even think about eating it.";
            if (DeliciousRating >= 4) return "This animal tastes good! Make sure it's legally and ethically sourced!";

            return "We don't have any opinons on this animal.";
        }
    }
}
