using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Sphynx : Cat
    {
        public string Name { get; set; }
        public override int AvgLifeSpanInYears = 12;

        public Sphynx(string name) : base(name)
        {
            Name = name;
        }
    }

    //    Sphynx
    //properties:
    //- string Name { get; set; }
    //- (override) int AvgLifeSpanInYears = 12;
    //- (override) bool HairOnSkin = false
    //- (override) string Cuteness = "Not cute"

    //methods:
    //- (override) string GetDemeanor => "Inquisitive and friendly"
}
