using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public abstract class Reptile : Vertebrata, IEdible, IApproachable
    {
        // Properties from pt.1 of lab
        public override string Endoskeleton { get; set; } = "Has a backbone";
        public override string Brain { get; set; } = "Well-developed brain but not as smart as mammals";
        public abstract string MovingSpeed { get; set; }
        public string Skin { get; set; } = "Has scales";

        // Properies from pt.2 IEdible implementation
        public bool Diseased { get; set; } = false;
        public int DeliciousRating { get; set; } = 3;
        public bool FattyMeat { get; set; } = true;

        // Properties from pt.2 IApproachable implementation
        public bool ReceivedShots { get; set; } = true;
        public virtual bool WillBite { get; set; } = true;
        public bool MightCharge { get; set; } = false;
        public virtual bool LikesAttention { get; set; } = false;

        // Methods from pt.1 of lab
        public string BloodTemperature()
        {
            return "I'm cold-blooded!";
        }

        public virtual string GetSkinType()
        {
            return Skin;
        }

        // Method from pt.2 IApproachable implementation
        public string ShouldTouristApproach()
        {
            if (WillBite || MightCharge) return "Definitely do not go anywhere near this animal. It might bite you and/or charge.";
            if (ReceivedShots && LikesAttention) return "Go ahead and shower this cutie with attention! It's vaccinated and loves hoomans!";

            return "We don't know enough about this animal to recommend you go near it. Err on the safe side.";
        }

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
