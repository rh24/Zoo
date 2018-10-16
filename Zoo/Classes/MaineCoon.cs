using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class MaineCoon
    {
        public string Name { get; set; }
        public override int AvgLifeSpanInYears = 12;
        public override string Cuteness = "Pretty Cute";

        public MaineCoon(string name) : base(name)
        {
            Name = name;
        }
    }
}
