using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Rodent : Mammal
    {
        public override int AvgLifeSpanInYears { get; set; } = 5;
        protected virtual string Size { get; set; } = "tennis ball";

        public override string MakeSound()
        {
            return "Squeak";
        }

        public virtual string GrowsUntil()
        {
            return $"Size of a {Size}";
        }
    }
}
