using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Rodent : Mammal
    {
        public override int AvgLifeSpanInYears { get; set; } = 5;

        public override string MakeSound()
        {
            return "Squeak";
        }

        public virtual string GrowsUntil()
        {
            return "Size of a tennis ball";
        }
    }
}
