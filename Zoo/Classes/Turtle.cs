using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Turtle : Reptile
    {
        public override string MovingSpeed { get; set; } = "slow";

        public override string GetSkinType()
        {
            return $"{Skin} that has hardened.";
        }

        public abstract string LikesCats();
    }
}
