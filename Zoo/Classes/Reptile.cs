using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public abstract class Reptile : Vertebrata, IEatable
    {
        public override string Endoskeleton { get; set; } = "Has a backbone";
        public override string Brain { get; set; } = "Well-developed brain but not as smart as mammals";
        public abstract string MovingSpeed { get; set; }
        public string Skin { get; set; } = "Has scales";
        public

        public string BloodTemperature()
        {
            return "I'm cold-blooded!";
        }

        public virtual string GetSkinType()
        {
            return Skin;
        }

        public Reptile()
        {
        }
    }
}
