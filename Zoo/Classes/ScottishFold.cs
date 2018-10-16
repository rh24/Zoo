using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class ScottishFold : Cat, IApproachable, IEatable
    {
        // Propeties from pt.1 of OOP Zoo lab
        public override string Cuteness { get; set; } = "Overload";
        public override bool Limber { get => false; }
        public override string Name { get; set; }
        public override string Ears { get => "Folded ears"; }
        public override bool MarvelousHearing { get; set; } = false;

        // Properties from pt.2 IApproachable implementation
        public bool ReceivedShots { get; set; } = true;
        public bool WillBite { get; set; } = false;
        public bool MightCharge { get; set; } = false;
        public bool LikesAttention { get; set; } = true;

        // Properies from pt.2 IEatable implementation
        public bool Diseased { get; set; } = false;
        public int DeliciousRating { get; set; } = 1;
        public bool FattyMeat { get; set; } = false;

        // Methods from pt.1
        public ScottishFold(string name) : base(name)
        {
            Name = name;
        }

        public override string Sleeps() => "But this cat sleeps at night with its hooman.";

        public override string Moves() => $"{base.Moves()} However, this cat has a hereditary cartilage disease that makes moving painful.";

        public override string GetDemeanor() => $"Lazy, affectionate, and, sometimes, {base.GetDemeanor().ToLower()}.";

        // Method from pt.2 IApproachable implementation
        public string ShouldTouristApproach()
        {
            return "Yes";
        }

        // Method from pt.2 IEatable implementation
        public string ShouldWeEatThis()
        {
            return "No";
        }
    }
}
