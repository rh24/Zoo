using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public abstract class Cat : Mammal, IEatable, IApproachable
    {
        // Properties from pt.1 of Lab
        public virtual bool Limber { get; } = true;
        public virtual bool MarvelousHearing { get; set; } = true;
        public abstract string Name { get; set; }
        public virtual string Ears { get; set; } = "Straight";
        public override int AvgLifeSpanInYears { get; set; } = 15;
        public abstract string Cuteness { get; set; }

        // Properies from pt.2 IEatable implementation
        public bool Diseased { get; set; } = false;
        public int DeliciousRating { get; set; } = 1;
        public bool FattyMeat { get; set; } = false;

        // Properties from pt.2 IApproachable implementation
        public bool ReceivedShots { get; set; } = true;
        public bool WillBite { get; set; } = false;
        public bool MightCharge { get; set; } = false;
        public bool LikesAttention { get; set; } = true;

        public override string MakeSound()
        {
            return "Meow";
        }

        public virtual string GetDemeanor()
        {
            return "Playful";
        }

        public virtual string Sleeps()
        {
            return "Cats usually sleep during the day. They are nocturnal.";
        }

        public virtual string Plays()
        {
            return "Likes to play in boxes.";
        }

        public virtual string Moves()
        {
            return "Normally, cats are graceful animals. They move like ballerinas.";
        }

        // Method from pt.2 IApproachable implementation
        public string ShouldTouristApproach()
        {
            if (WillBite || MightCharge) return "Definitely do not go anywhere near this animal. It might bite you and/or charge.";
            if (ReceivedShots && LikesAttention) return "Go ahead and shower this cutie with attention! It's vaccinated and loves hoomans!";

            return "We don't know enough about this animal to recommend you go near it. Err on the safe side.";
        }

        // Method from pt.2 IEatable implementation
        public string ShouldWeEatThis()
        {
            if (Diseased) return "I don't think you want to do that... this animal is diseased.";
            if (FattyMeat && DeliciousRating >= 4) return "We hear good things about it! It's worth trying!";
            if (DeliciousRating == 3 && !FattyMeat) return "It tastes average at best, and it's not fatty meat... It's up to you, but we wouldn't recommend it.";
            if (DeliciousRating < 3) return "This animal tastes terrible. Don't even think about eating it.";
            if (DeliciousRating >= 4) return "This animal tastes good! Make sure it's legally and ethically sourced!";

            return "We don't have any opinons on this animal.";
        }

        public Cat(string name)
        {
            Name = name;
        }
    }
}
