using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Rat : Rodent
    {
        public string Name { get; set; }
        // test for inheritance => 1
        // test for overriding: shouldn't be able to set AvgLifeSpanInYears of new Rat object
        public override int AvgLifeSpanInYears { get => base.AvgLifeSpanInYears; }
        protected override string Size { get; set; } = "football";

        // test for inheritance => "Size of a football"
        public override string GrowsUntil()
        {
            return $"{base.GrowsUntil()} {Size}";
        }

        public Rat(string name)
        {
            Name = name;
        }
    }
}
