using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Sphynx : Cat
    {
        public override string Name { get; set; }
        public override int AvgLifeSpanInYears { get; set; } = 11;
        public override bool HairOnSkin { get; } = false;
        public override string Cuteness { get; set; } = "Not cute";

        // write test to prove inheritance => "Playful, inquistive, and friendly"
        public override string GetDemeanor()
        {
            return $"{base.GetDemeanor()}, inquisitive, and friendly";
        }

        public Sphynx(string name) : base(name)
        {
            Name = name;
        }
    }
}
